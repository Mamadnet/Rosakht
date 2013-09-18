using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;


namespace zirsakht_stock
{
    public partial class frmLogin : Form
    {
        /// <summary>
        /// Key for the crypto provider
        /// </summary>
        private static readonly byte[] _key = { 0xA1, 0xF1, 0xA6, 0xBB, 0xA2, 0x5A, 0x37, 0x6F, 0x81, 0x2E, 0x17, 0x41, 0x72, 0x2C, 0x43, 0x27 };
        /// <summary>
        /// Initialization vector for the crypto provider
        /// </summary>
        private static readonly byte[] _initVector = { 0xE1, 0xF1, 0xA6, 0xBB, 0xA9, 0x5B, 0x31, 0x2F, 0x81, 0x2E, 0x17, 0x4C, 0xA2, 0x81, 0x53, 0x61 };
        lqStockDataContext lq = new lqStockDataContext();
        public frmLogin()
        {
            InitializeComponent();
            
        }


#if (DEBUG) //Only compile this method for local debugging.
        /// <summary>
        /// Decrypt a string
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        private static string Decrypt(string Value)
        {
            SymmetricAlgorithm mCSP;
            ICryptoTransform ct = null;
            MemoryStream ms = null;
            CryptoStream cs = null;
            byte[] byt;
            byte[] _result;

            mCSP = new RijndaelManaged();

            try
            {
                mCSP.Key = _key;
                mCSP.IV = _initVector;
                ct = mCSP.CreateDecryptor(mCSP.Key, mCSP.IV);


                byt = Convert.FromBase64String(Value);

                ms = new MemoryStream();
                cs = new CryptoStream(ms, ct, CryptoStreamMode.Write);
                cs.Write(byt, 0, byt.Length);
                cs.FlushFinalBlock();

                cs.Close();
                _result = ms.ToArray();
            }
            catch
            {
                _result = null;
            }
            finally
            {
                if (ct != null)
                    ct.Dispose();
                if (ms != null)
                    ms.Dispose();
                if (cs != null)
                    cs.Dispose();
            }

            return ASCIIEncoding.UTF8.GetString(_result);
        }
#endif

        /// <summary>
        /// Encrypt a string
        /// </summary>
        /// <param name="Password"></param>
        /// <returns></returns>
        private static string Encrypt(string Password)
        {
            
            if (string.IsNullOrEmpty(Password))
                return string.Empty;

            byte[] Value = Encoding.UTF8.GetBytes(Password);
            SymmetricAlgorithm mCSP = new RijndaelManaged();
            mCSP.Key = _key;
            mCSP.IV = _initVector;
            using (ICryptoTransform ct = mCSP.CreateEncryptor(mCSP.Key, mCSP.IV))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, ct, CryptoStreamMode.Write))
                    {
                        cs.Write(Value, 0, Value.Length);
                        cs.FlushFinalBlock();
                        cs.Close();
                        return Convert.ToBase64String(ms.ToArray());
                    }
                }
            }
        }

        /// <summary>
        /// Looks up the users password crypto string in the database
        /// </summary>
        /// <param name="Username"></param>
        /// <returns></returns>
        public  bool LookupUser(string username, string password)
        {
            // I don't validate password here (see TODO below)
          
            var user =lq.tblUsers.FirstOrDefault(u => u.Username.Equals(username) && u.Password.Equals(password) && u.Status==true);

            if (user != null)
            {
             //   var rehash = Hashing.Hash(password, user.PasswordSalt); // PasswordSalt is a byte array
              //  if (rehash.SequenceEqual(user.Password))
                if(user.Password.Equals("123456"))
                {
                    return true;
                }
                else
                {
                    //Logger.LogUnsuccessfulAuthentication(user);

                    // TODO: Increase user-login failure count and system-wide failure count
                }
            }

            return false;
        }

        /// <summary>
        /// Obviously the .Focus() code doesn't apply to ASP.NET
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUsername.Text))
            {
                //Focus box before showing a message
                textBoxUsername.Focus();
                MessageBox.Show("Enter your username", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Focus again afterwards, sometimes people double click message boxes and select another control accidentally
                textBoxUsername.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                textBoxPassword.Focus();
                MessageBox.Show("Enter your password", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxPassword.Focus();
                return;
            }

            //if (textBoxPassword.Text == "123456")
            //{
            //    //Form1 m = new Form1();
            //    //this.Visible = false;

            //    //m.ShowDialog();
            //    //this.Close();

            //}

            //OK they enter a user and pass, lets see if they can authenticate
            //using (DataTable dt = LookupUser(textBoxUsername.Text))
            //{
            //    if (dt.Rows.Count == 0)
            //    {
            //        textBoxUsername.Focus();
            //        MessageBox.Show("Invalid username.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        textBoxUsername.Focus();
            //        return;
            //    }
            //    else
            //    {
            //        //Always compare the resulting crypto string or hash value, never the decrypted value
            //        //By doing that you never make a call to Decrypt() and the application is harder to
            //        //reverse engineer. I included the Decrypt() method here for informational purposes
            //        //only. I do not recommend shipping an assembly with Decrypt() methods.

            //        string dbPassword = Convert.ToString(dt.Rows[0]["Password"]);
            //        string appPassword = Encrypt(textBoxPassword.Text); //we store the password as encrypted in the DB
            if (LookupUser(textBoxUsername.Text,textBoxPassword.Text)==true)
            {
                Form1 mn = new Form1();
                this.Visible = false;

                mn.ShowDialog();
                this.Close();
            }
            else
            {
                //You may want to use the same error message so they can't tell which field they got wrong
                textBoxPassword.Focus();
                MessageBox.Show("Invalid Password", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxPassword.Focus();
                return;
            }
            //    }
            //}
        }

        protected void RePaint()
        {

            GraphicsPath graphicpath = new GraphicsPath();

            graphicpath.StartFigure();

            graphicpath.AddArc(0, 0, 25, 25, 180, 90);

            graphicpath.AddLine(25, 0, this.Width - 25, 0);

            graphicpath.AddArc(this.Width - 25, 0, 25, 25, 270, 90);

            graphicpath.AddLine(this.Width, 25, this.Width, this.Height - 25);

            graphicpath.AddArc(this.Width - 25, this.Height - 25, 25, 25, 0, 90);

            graphicpath.AddLine(this.Width - 25, this.Height, 25, this.Height);

            graphicpath.AddArc(0, this.Height - 25, 25, 25, 90, 90);

            graphicpath.CloseFigure();

            this.Region = new Region(graphicpath);

        }

        private void MyPaintEventHandler(object sender, System.Windows.Forms.PaintEventArgs args)
        {
            RePaint();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBoxUsername;
        }

        

       

        

      

      

        
    }
}
