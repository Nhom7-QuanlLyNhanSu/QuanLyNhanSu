﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QL_NHANSU")]
	public partial class DataTaiKhoanDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTAIKHOAN(TAIKHOAN instance);
    partial void UpdateTAIKHOAN(TAIKHOAN instance);
    partial void DeleteTAIKHOAN(TAIKHOAN instance);
    #endregion
		
		public DataTaiKhoanDataContext() : 
				base(global::DAL.Properties.Settings.Default.QL_NHANSUConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataTaiKhoanDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataTaiKhoanDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataTaiKhoanDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataTaiKhoanDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TAIKHOAN> TAIKHOANs
		{
			get
			{
				return this.GetTable<TAIKHOAN>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TAIKHOAN")]
	public partial class TAIKHOAN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MANV;
		
		private string _MAKHAU;
		
		private System.Nullable<int> _TRANGTHAI;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMANVChanging(string value);
    partial void OnMANVChanged();
    partial void OnMAKHAUChanging(string value);
    partial void OnMAKHAUChanged();
    partial void OnTRANGTHAIChanging(System.Nullable<int> value);
    partial void OnTRANGTHAIChanged();
    #endregion
		
		public TAIKHOAN()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MANV", DbType="Char(6) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MANV
		{
			get
			{
				return this._MANV;
			}
			set
			{
				if ((this._MANV != value))
				{
					this.OnMANVChanging(value);
					this.SendPropertyChanging();
					this._MANV = value;
					this.SendPropertyChanged("MANV");
					this.OnMANVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAKHAU", DbType="Char(6)")]
		public string MAKHAU
		{
			get
			{
				return this._MAKHAU;
			}
			set
			{
				if ((this._MAKHAU != value))
				{
					this.OnMAKHAUChanging(value);
					this.SendPropertyChanging();
					this._MAKHAU = value;
					this.SendPropertyChanged("MAKHAU");
					this.OnMAKHAUChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TRANGTHAI", DbType="Int")]
		public System.Nullable<int> TRANGTHAI
		{
			get
			{
				return this._TRANGTHAI;
			}
			set
			{
				if ((this._TRANGTHAI != value))
				{
					this.OnTRANGTHAIChanging(value);
					this.SendPropertyChanging();
					this._TRANGTHAI = value;
					this.SendPropertyChanged("TRANGTHAI");
					this.OnTRANGTHAIChanged();
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
