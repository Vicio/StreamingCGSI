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

namespace StreamingSite.AppCode
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="streaming_mensajes")]
	public partial class StreamingDSDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertusuarios(usuarios instance);
    partial void Updateusuarios(usuarios instance);
    partial void Deleteusuarios(usuarios instance);
    #endregion
		
		public StreamingDSDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["streaming_mensajesConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public StreamingDSDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StreamingDSDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StreamingDSDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StreamingDSDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<usuarios> usuarios
		{
			get
			{
				return this.GetTable<usuarios>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.usuarios")]
	public partial class usuarios : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_usuario;
		
		private string _nombre_usuario;
		
		private string _correo_usuario;
		
		private string _hash_usuario;
		
		private string _departamento_usuario;
		
		private string _mensaje_usuario;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_usuarioChanging(int value);
    partial void Onid_usuarioChanged();
    partial void Onnombre_usuarioChanging(string value);
    partial void Onnombre_usuarioChanged();
    partial void Oncorreo_usuarioChanging(string value);
    partial void Oncorreo_usuarioChanged();
    partial void Onhash_usuarioChanging(string value);
    partial void Onhash_usuarioChanged();
    partial void Ondepartamento_usuarioChanging(string value);
    partial void Ondepartamento_usuarioChanged();
    partial void Onmensaje_usuarioChanging(string value);
    partial void Onmensaje_usuarioChanged();
    #endregion
		
		public usuarios()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_usuario", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_usuario
		{
			get
			{
				return this._id_usuario;
			}
			set
			{
				if ((this._id_usuario != value))
				{
					this.Onid_usuarioChanging(value);
					this.SendPropertyChanging();
					this._id_usuario = value;
					this.SendPropertyChanged("id_usuario");
					this.Onid_usuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre_usuario", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string nombre_usuario
		{
			get
			{
				return this._nombre_usuario;
			}
			set
			{
				if ((this._nombre_usuario != value))
				{
					this.Onnombre_usuarioChanging(value);
					this.SendPropertyChanging();
					this._nombre_usuario = value;
					this.SendPropertyChanged("nombre_usuario");
					this.Onnombre_usuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_correo_usuario", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string correo_usuario
		{
			get
			{
				return this._correo_usuario;
			}
			set
			{
				if ((this._correo_usuario != value))
				{
					this.Oncorreo_usuarioChanging(value);
					this.SendPropertyChanging();
					this._correo_usuario = value;
					this.SendPropertyChanged("correo_usuario");
					this.Oncorreo_usuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hash_usuario", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string hash_usuario
		{
			get
			{
				return this._hash_usuario;
			}
			set
			{
				if ((this._hash_usuario != value))
				{
					this.Onhash_usuarioChanging(value);
					this.SendPropertyChanging();
					this._hash_usuario = value;
					this.SendPropertyChanged("hash_usuario");
					this.Onhash_usuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_departamento_usuario", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string departamento_usuario
		{
			get
			{
				return this._departamento_usuario;
			}
			set
			{
				if ((this._departamento_usuario != value))
				{
					this.Ondepartamento_usuarioChanging(value);
					this.SendPropertyChanging();
					this._departamento_usuario = value;
					this.SendPropertyChanged("departamento_usuario");
					this.Ondepartamento_usuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mensaje_usuario", DbType="VarChar(MAX)")]
		public string mensaje_usuario
		{
			get
			{
				return this._mensaje_usuario;
			}
			set
			{
				if ((this._mensaje_usuario != value))
				{
					this.Onmensaje_usuarioChanging(value);
					this.SendPropertyChanging();
					this._mensaje_usuario = value;
					this.SendPropertyChanged("mensaje_usuario");
					this.Onmensaje_usuarioChanged();
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
