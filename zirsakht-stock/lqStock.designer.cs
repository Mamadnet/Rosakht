﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.2012
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace zirsakht_stock
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="stock")]
	public partial class lqStockDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InserttblSite(tblSite instance);
    partial void UpdatetblSite(tblSite instance);
    partial void DeletetblSite(tblSite instance);
    partial void InserttblType(tblType instance);
    partial void UpdatetblType(tblType instance);
    partial void DeletetblType(tblType instance);
    partial void InserttblDelivered(tblDelivered instance);
    partial void UpdatetblDelivered(tblDelivered instance);
    partial void DeletetblDelivered(tblDelivered instance);
    partial void InserttblEquipment(tblEquipment instance);
    partial void UpdatetblEquipment(tblEquipment instance);
    partial void DeletetblEquipment(tblEquipment instance);
    partial void InserttblUnit(tblUnit instance);
    partial void UpdatetblUnit(tblUnit instance);
    partial void DeletetblUnit(tblUnit instance);
    partial void InserttblRecieved(tblRecieved instance);
    partial void UpdatetblRecieved(tblRecieved instance);
    partial void DeletetblRecieved(tblRecieved instance);
    #endregion
		
		public lqStockDataContext() : 
				base(global::zirsakht_stock.Properties.Settings.Default.stockConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public lqStockDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public lqStockDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public lqStockDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public lqStockDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tblSite> tblSites
		{
			get
			{
				return this.GetTable<tblSite>();
			}
		}
		
		public System.Data.Linq.Table<tblType> tblTypes
		{
			get
			{
				return this.GetTable<tblType>();
			}
		}
		
		public System.Data.Linq.Table<tblDelivered> tblDelivereds
		{
			get
			{
				return this.GetTable<tblDelivered>();
			}
		}
		
		public System.Data.Linq.Table<tblEquipment> tblEquipments
		{
			get
			{
				return this.GetTable<tblEquipment>();
			}
		}
		
		public System.Data.Linq.Table<tblUnit> tblUnits
		{
			get
			{
				return this.GetTable<tblUnit>();
			}
		}
		
		public System.Data.Linq.Table<vwKarde> vwKardes
		{
			get
			{
				return this.GetTable<vwKarde>();
			}
		}
		
		public System.Data.Linq.Table<tblRecieved> tblRecieveds
		{
			get
			{
				return this.GetTable<tblRecieved>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblSites")]
	public partial class tblSite : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private string _Ostan;
		
		private EntitySet<tblDelivered> _tblDelivereds;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnOstanChanging(string value);
    partial void OnOstanChanged();
    #endregion
		
		public tblSite()
		{
			this._tblDelivereds = new EntitySet<tblDelivered>(new Action<tblDelivered>(this.attach_tblDelivereds), new Action<tblDelivered>(this.detach_tblDelivereds));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ostan", DbType="NVarChar(50)")]
		public string Ostan
		{
			get
			{
				return this._Ostan;
			}
			set
			{
				if ((this._Ostan != value))
				{
					this.OnOstanChanging(value);
					this.SendPropertyChanging();
					this._Ostan = value;
					this.SendPropertyChanged("Ostan");
					this.OnOstanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblSite_tblDelivered", Storage="_tblDelivereds", ThisKey="ID", OtherKey="SiteID")]
		public EntitySet<tblDelivered> tblDelivereds
		{
			get
			{
				return this._tblDelivereds;
			}
			set
			{
				this._tblDelivereds.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_tblDelivereds(tblDelivered entity)
		{
			this.SendPropertyChanging();
			entity.tblSite = this;
		}
		
		private void detach_tblDelivereds(tblDelivered entity)
		{
			this.SendPropertyChanging();
			entity.tblSite = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblTypes")]
	public partial class tblType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _TypeDesc;
		
		private EntitySet<tblEquipment> _tblEquipments;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTypeDescChanging(string value);
    partial void OnTypeDescChanged();
    #endregion
		
		public tblType()
		{
			this._tblEquipments = new EntitySet<tblEquipment>(new Action<tblEquipment>(this.attach_tblEquipments), new Action<tblEquipment>(this.detach_tblEquipments));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TypeDesc", DbType="NVarChar(50)")]
		public string TypeDesc
		{
			get
			{
				return this._TypeDesc;
			}
			set
			{
				if ((this._TypeDesc != value))
				{
					this.OnTypeDescChanging(value);
					this.SendPropertyChanging();
					this._TypeDesc = value;
					this.SendPropertyChanged("TypeDesc");
					this.OnTypeDescChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblType_tblEquipment", Storage="_tblEquipments", ThisKey="ID", OtherKey="Type")]
		public EntitySet<tblEquipment> tblEquipments
		{
			get
			{
				return this._tblEquipments;
			}
			set
			{
				this._tblEquipments.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_tblEquipments(tblEquipment entity)
		{
			this.SendPropertyChanging();
			entity.tblType = this;
		}
		
		private void detach_tblEquipments(tblEquipment entity)
		{
			this.SendPropertyChanging();
			entity.tblType = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblDelivered")]
	public partial class tblDelivered : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _PartNumber;
		
		private string _Description;
		
		private string _Agent;
		
		private string _Date;
		
		private string _ReceivedBy;
		
		private System.Nullable<int> _SiteID;
		
		private System.Nullable<long> _Tedad;
		
		private System.Nullable<int> _EquipID;
		
		private EntityRef<tblSite> _tblSite;
		
		private EntityRef<tblEquipment> _tblEquipment;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnPartNumberChanging(string value);
    partial void OnPartNumberChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnAgentChanging(string value);
    partial void OnAgentChanged();
    partial void OnDateChanging(string value);
    partial void OnDateChanged();
    partial void OnReceivedByChanging(string value);
    partial void OnReceivedByChanged();
    partial void OnSiteIDChanging(System.Nullable<int> value);
    partial void OnSiteIDChanged();
    partial void OnTedadChanging(System.Nullable<long> value);
    partial void OnTedadChanged();
    partial void OnEquipIDChanging(System.Nullable<int> value);
    partial void OnEquipIDChanged();
    #endregion
		
		public tblDelivered()
		{
			this._tblSite = default(EntityRef<tblSite>);
			this._tblEquipment = default(EntityRef<tblEquipment>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PartNumber", DbType="NVarChar(50)")]
		public string PartNumber
		{
			get
			{
				return this._PartNumber;
			}
			set
			{
				if ((this._PartNumber != value))
				{
					this.OnPartNumberChanging(value);
					this.SendPropertyChanging();
					this._PartNumber = value;
					this.SendPropertyChanged("PartNumber");
					this.OnPartNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(500)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Agent", DbType="NVarChar(50)")]
		public string Agent
		{
			get
			{
				return this._Agent;
			}
			set
			{
				if ((this._Agent != value))
				{
					this.OnAgentChanging(value);
					this.SendPropertyChanging();
					this._Agent = value;
					this.SendPropertyChanged("Agent");
					this.OnAgentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="NChar(10)")]
		public string Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceivedBy", DbType="NVarChar(50)")]
		public string ReceivedBy
		{
			get
			{
				return this._ReceivedBy;
			}
			set
			{
				if ((this._ReceivedBy != value))
				{
					this.OnReceivedByChanging(value);
					this.SendPropertyChanging();
					this._ReceivedBy = value;
					this.SendPropertyChanged("ReceivedBy");
					this.OnReceivedByChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SiteID", DbType="Int")]
		public System.Nullable<int> SiteID
		{
			get
			{
				return this._SiteID;
			}
			set
			{
				if ((this._SiteID != value))
				{
					if (this._tblSite.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSiteIDChanging(value);
					this.SendPropertyChanging();
					this._SiteID = value;
					this.SendPropertyChanged("SiteID");
					this.OnSiteIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tedad", DbType="BigInt")]
		public System.Nullable<long> Tedad
		{
			get
			{
				return this._Tedad;
			}
			set
			{
				if ((this._Tedad != value))
				{
					this.OnTedadChanging(value);
					this.SendPropertyChanging();
					this._Tedad = value;
					this.SendPropertyChanged("Tedad");
					this.OnTedadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EquipID", DbType="Int")]
		public System.Nullable<int> EquipID
		{
			get
			{
				return this._EquipID;
			}
			set
			{
				if ((this._EquipID != value))
				{
					if (this._tblEquipment.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnEquipIDChanging(value);
					this.SendPropertyChanging();
					this._EquipID = value;
					this.SendPropertyChanged("EquipID");
					this.OnEquipIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblSite_tblDelivered", Storage="_tblSite", ThisKey="SiteID", OtherKey="ID", IsForeignKey=true)]
		public tblSite tblSite
		{
			get
			{
				return this._tblSite.Entity;
			}
			set
			{
				tblSite previousValue = this._tblSite.Entity;
				if (((previousValue != value) 
							|| (this._tblSite.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblSite.Entity = null;
						previousValue.tblDelivereds.Remove(this);
					}
					this._tblSite.Entity = value;
					if ((value != null))
					{
						value.tblDelivereds.Add(this);
						this._SiteID = value.ID;
					}
					else
					{
						this._SiteID = default(Nullable<int>);
					}
					this.SendPropertyChanged("tblSite");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblEquipment_tblDelivered", Storage="_tblEquipment", ThisKey="EquipID", OtherKey="ID", IsForeignKey=true)]
		public tblEquipment tblEquipment
		{
			get
			{
				return this._tblEquipment.Entity;
			}
			set
			{
				tblEquipment previousValue = this._tblEquipment.Entity;
				if (((previousValue != value) 
							|| (this._tblEquipment.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblEquipment.Entity = null;
						previousValue.tblDelivereds.Remove(this);
					}
					this._tblEquipment.Entity = value;
					if ((value != null))
					{
						value.tblDelivereds.Add(this);
						this._EquipID = value.ID;
					}
					else
					{
						this._EquipID = default(Nullable<int>);
					}
					this.SendPropertyChanged("tblEquipment");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblEquipments")]
	public partial class tblEquipment : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Partnumber;
		
		private System.Nullable<int> _Type;
		
		private System.Nullable<int> _UnitID;
		
		private EntitySet<tblDelivered> _tblDelivereds;
		
		private EntitySet<tblRecieved> _tblRecieveds;
		
		private EntityRef<tblType> _tblType;
		
		private EntityRef<tblUnit> _tblUnit;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnPartnumberChanging(string value);
    partial void OnPartnumberChanged();
    partial void OnTypeChanging(System.Nullable<int> value);
    partial void OnTypeChanged();
    partial void OnUnitIDChanging(System.Nullable<int> value);
    partial void OnUnitIDChanged();
    #endregion
		
		public tblEquipment()
		{
			this._tblDelivereds = new EntitySet<tblDelivered>(new Action<tblDelivered>(this.attach_tblDelivereds), new Action<tblDelivered>(this.detach_tblDelivereds));
			this._tblRecieveds = new EntitySet<tblRecieved>(new Action<tblRecieved>(this.attach_tblRecieveds), new Action<tblRecieved>(this.detach_tblRecieveds));
			this._tblType = default(EntityRef<tblType>);
			this._tblUnit = default(EntityRef<tblUnit>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Partnumber", DbType="NVarChar(50)")]
		public string Partnumber
		{
			get
			{
				return this._Partnumber;
			}
			set
			{
				if ((this._Partnumber != value))
				{
					this.OnPartnumberChanging(value);
					this.SendPropertyChanging();
					this._Partnumber = value;
					this.SendPropertyChanged("Partnumber");
					this.OnPartnumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="Int")]
		public System.Nullable<int> Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				if ((this._Type != value))
				{
					if (this._tblType.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTypeChanging(value);
					this.SendPropertyChanging();
					this._Type = value;
					this.SendPropertyChanged("Type");
					this.OnTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UnitID", DbType="Int")]
		public System.Nullable<int> UnitID
		{
			get
			{
				return this._UnitID;
			}
			set
			{
				if ((this._UnitID != value))
				{
					if (this._tblUnit.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUnitIDChanging(value);
					this.SendPropertyChanging();
					this._UnitID = value;
					this.SendPropertyChanged("UnitID");
					this.OnUnitIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblEquipment_tblDelivered", Storage="_tblDelivereds", ThisKey="ID", OtherKey="EquipID")]
		public EntitySet<tblDelivered> tblDelivereds
		{
			get
			{
				return this._tblDelivereds;
			}
			set
			{
				this._tblDelivereds.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblEquipment_tblRecieved", Storage="_tblRecieveds", ThisKey="ID", OtherKey="EquipID")]
		public EntitySet<tblRecieved> tblRecieveds
		{
			get
			{
				return this._tblRecieveds;
			}
			set
			{
				this._tblRecieveds.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblType_tblEquipment", Storage="_tblType", ThisKey="Type", OtherKey="ID", IsForeignKey=true)]
		public tblType tblType
		{
			get
			{
				return this._tblType.Entity;
			}
			set
			{
				tblType previousValue = this._tblType.Entity;
				if (((previousValue != value) 
							|| (this._tblType.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblType.Entity = null;
						previousValue.tblEquipments.Remove(this);
					}
					this._tblType.Entity = value;
					if ((value != null))
					{
						value.tblEquipments.Add(this);
						this._Type = value.ID;
					}
					else
					{
						this._Type = default(Nullable<int>);
					}
					this.SendPropertyChanged("tblType");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblUnit_tblEquipment", Storage="_tblUnit", ThisKey="UnitID", OtherKey="ID", IsForeignKey=true)]
		public tblUnit tblUnit
		{
			get
			{
				return this._tblUnit.Entity;
			}
			set
			{
				tblUnit previousValue = this._tblUnit.Entity;
				if (((previousValue != value) 
							|| (this._tblUnit.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblUnit.Entity = null;
						previousValue.tblEquipments.Remove(this);
					}
					this._tblUnit.Entity = value;
					if ((value != null))
					{
						value.tblEquipments.Add(this);
						this._UnitID = value.ID;
					}
					else
					{
						this._UnitID = default(Nullable<int>);
					}
					this.SendPropertyChanged("tblUnit");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_tblDelivereds(tblDelivered entity)
		{
			this.SendPropertyChanging();
			entity.tblEquipment = this;
		}
		
		private void detach_tblDelivereds(tblDelivered entity)
		{
			this.SendPropertyChanging();
			entity.tblEquipment = null;
		}
		
		private void attach_tblRecieveds(tblRecieved entity)
		{
			this.SendPropertyChanging();
			entity.tblEquipment = this;
		}
		
		private void detach_tblRecieveds(tblRecieved entity)
		{
			this.SendPropertyChanging();
			entity.tblEquipment = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblUnits")]
	public partial class tblUnit : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Unit;
		
		private string _Description;
		
		private EntitySet<tblEquipment> _tblEquipments;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnUnitChanging(string value);
    partial void OnUnitChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    #endregion
		
		public tblUnit()
		{
			this._tblEquipments = new EntitySet<tblEquipment>(new Action<tblEquipment>(this.attach_tblEquipments), new Action<tblEquipment>(this.detach_tblEquipments));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Unit", DbType="NVarChar(50)")]
		public string Unit
		{
			get
			{
				return this._Unit;
			}
			set
			{
				if ((this._Unit != value))
				{
					this.OnUnitChanging(value);
					this.SendPropertyChanging();
					this._Unit = value;
					this.SendPropertyChanged("Unit");
					this.OnUnitChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NChar(10)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblUnit_tblEquipment", Storage="_tblEquipments", ThisKey="ID", OtherKey="UnitID")]
		public EntitySet<tblEquipment> tblEquipments
		{
			get
			{
				return this._tblEquipments;
			}
			set
			{
				this._tblEquipments.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_tblEquipments(tblEquipment entity)
		{
			this.SendPropertyChanging();
			entity.tblUnit = this;
		}
		
		private void detach_tblEquipments(tblEquipment entity)
		{
			this.SendPropertyChanging();
			entity.tblUnit = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.vwKardes")]
	public partial class vwKarde
	{
		
		private int _id;
		
		private string _partnumber;
		
		private string _date;
		
		private System.Nullable<long> _tedad;
		
		private System.Nullable<int> _equipid;
		
		private string _dahande;
		
		private string _receivedby;
		
		private int _status;
		
		public vwKarde()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL")]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this._id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_partnumber", DbType="NVarChar(50)")]
		public string partnumber
		{
			get
			{
				return this._partnumber;
			}
			set
			{
				if ((this._partnumber != value))
				{
					this._partnumber = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date", DbType="NVarChar(50)")]
		public string date
		{
			get
			{
				return this._date;
			}
			set
			{
				if ((this._date != value))
				{
					this._date = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tedad", DbType="BigInt")]
		public System.Nullable<long> tedad
		{
			get
			{
				return this._tedad;
			}
			set
			{
				if ((this._tedad != value))
				{
					this._tedad = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_equipid", DbType="Int")]
		public System.Nullable<int> equipid
		{
			get
			{
				return this._equipid;
			}
			set
			{
				if ((this._equipid != value))
				{
					this._equipid = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dahande", DbType="NVarChar(50)")]
		public string dahande
		{
			get
			{
				return this._dahande;
			}
			set
			{
				if ((this._dahande != value))
				{
					this._dahande = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_receivedby", DbType="NVarChar(50)")]
		public string receivedby
		{
			get
			{
				return this._receivedby;
			}
			set
			{
				if ((this._receivedby != value))
				{
					this._receivedby = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="Int NOT NULL")]
		public int status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this._status = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblRecieved")]
	public partial class tblRecieved : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _PartNumber;
		
		private string _Date;
		
		private string _Ersal;
		
		private string _Description;
		
		private System.Nullable<long> _Tedad;
		
		private System.Nullable<int> _EquipID;
		
		private string _ReceivedBy;
		
		private EntityRef<tblEquipment> _tblEquipment;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnPartNumberChanging(string value);
    partial void OnPartNumberChanged();
    partial void OnDateChanging(string value);
    partial void OnDateChanged();
    partial void OnErsalChanging(string value);
    partial void OnErsalChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnTedadChanging(System.Nullable<long> value);
    partial void OnTedadChanged();
    partial void OnEquipIDChanging(System.Nullable<int> value);
    partial void OnEquipIDChanged();
    partial void OnReceivedByChanging(string value);
    partial void OnReceivedByChanged();
    #endregion
		
		public tblRecieved()
		{
			this._tblEquipment = default(EntityRef<tblEquipment>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PartNumber", DbType="NVarChar(50)")]
		public string PartNumber
		{
			get
			{
				return this._PartNumber;
			}
			set
			{
				if ((this._PartNumber != value))
				{
					this.OnPartNumberChanging(value);
					this.SendPropertyChanging();
					this._PartNumber = value;
					this.SendPropertyChanged("PartNumber");
					this.OnPartNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="NVarChar(50)")]
		public string Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ersal", DbType="NVarChar(50)")]
		public string Ersal
		{
			get
			{
				return this._Ersal;
			}
			set
			{
				if ((this._Ersal != value))
				{
					this.OnErsalChanging(value);
					this.SendPropertyChanging();
					this._Ersal = value;
					this.SendPropertyChanged("Ersal");
					this.OnErsalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(300)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tedad", DbType="BigInt")]
		public System.Nullable<long> Tedad
		{
			get
			{
				return this._Tedad;
			}
			set
			{
				if ((this._Tedad != value))
				{
					this.OnTedadChanging(value);
					this.SendPropertyChanging();
					this._Tedad = value;
					this.SendPropertyChanged("Tedad");
					this.OnTedadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EquipID", DbType="Int")]
		public System.Nullable<int> EquipID
		{
			get
			{
				return this._EquipID;
			}
			set
			{
				if ((this._EquipID != value))
				{
					if (this._tblEquipment.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnEquipIDChanging(value);
					this.SendPropertyChanging();
					this._EquipID = value;
					this.SendPropertyChanged("EquipID");
					this.OnEquipIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceivedBy", DbType="NVarChar(50)")]
		public string ReceivedBy
		{
			get
			{
				return this._ReceivedBy;
			}
			set
			{
				if ((this._ReceivedBy != value))
				{
					this.OnReceivedByChanging(value);
					this.SendPropertyChanging();
					this._ReceivedBy = value;
					this.SendPropertyChanged("ReceivedBy");
					this.OnReceivedByChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblEquipment_tblRecieved", Storage="_tblEquipment", ThisKey="EquipID", OtherKey="ID", IsForeignKey=true)]
		public tblEquipment tblEquipment
		{
			get
			{
				return this._tblEquipment.Entity;
			}
			set
			{
				tblEquipment previousValue = this._tblEquipment.Entity;
				if (((previousValue != value) 
							|| (this._tblEquipment.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblEquipment.Entity = null;
						previousValue.tblRecieveds.Remove(this);
					}
					this._tblEquipment.Entity = value;
					if ((value != null))
					{
						value.tblRecieveds.Add(this);
						this._EquipID = value.ID;
					}
					else
					{
						this._EquipID = default(Nullable<int>);
					}
					this.SendPropertyChanged("tblEquipment");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
