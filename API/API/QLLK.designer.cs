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

namespace API
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QL_CUAHANGLINHKIENMAYTINH")]
	public partial class QLLKDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertChiTietHoaDon(ChiTietHoaDon instance);
    partial void UpdateChiTietHoaDon(ChiTietHoaDon instance);
    partial void DeleteChiTietHoaDon(ChiTietHoaDon instance);
    partial void InsertSanPham(SanPham instance);
    partial void UpdateSanPham(SanPham instance);
    partial void DeleteSanPham(SanPham instance);
    partial void InsertKhachHang(KhachHang instance);
    partial void UpdateKhachHang(KhachHang instance);
    partial void DeleteKhachHang(KhachHang instance);
    #endregion
		
		public QLLKDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["QL_CUAHANGLINHKIENMAYTINHConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QLLKDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLLKDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLLKDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLLKDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<View_GioHang> View_GioHangs
		{
			get
			{
				return this.GetTable<View_GioHang>();
			}
		}
		
		public System.Data.Linq.Table<View_BieuMauGio> View_BieuMauGios
		{
			get
			{
				return this.GetTable<View_BieuMauGio>();
			}
		}
		
		public System.Data.Linq.Table<View_Anh> View_Anhs
		{
			get
			{
				return this.GetTable<View_Anh>();
			}
		}
		
		public System.Data.Linq.Table<ChiTietHoaDon> ChiTietHoaDons
		{
			get
			{
				return this.GetTable<ChiTietHoaDon>();
			}
		}
		
		public System.Data.Linq.Table<SanPham> SanPhams
		{
			get
			{
				return this.GetTable<SanPham>();
			}
		}
		
		public System.Data.Linq.Table<View_KH> View_KHs
		{
			get
			{
				return this.GetTable<View_KH>();
			}
		}
		
		public System.Data.Linq.Table<KhachHang> KhachHangs
		{
			get
			{
				return this.GetTable<KhachHang>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.View_GioHang")]
	public partial class View_GioHang
	{
		
		private int _MaHoaDon;
		
		private System.Nullable<int> _MaSanPham;
		
		private string _Gmail;
		
		private System.Nullable<int> _SoLuong;
		
		private System.Nullable<int> _TongTien;
		
		private System.Nullable<decimal> _TongTienHoaDon;
		
		private System.Nullable<System.DateTime> _NgayLapHoaDon;
		
		private string _Image;
		
		public View_GioHang()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHoaDon", DbType="Int NOT NULL")]
		public int MaHoaDon
		{
			get
			{
				return this._MaHoaDon;
			}
			set
			{
				if ((this._MaHoaDon != value))
				{
					this._MaHoaDon = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSanPham", DbType="Int")]
		public System.Nullable<int> MaSanPham
		{
			get
			{
				return this._MaSanPham;
			}
			set
			{
				if ((this._MaSanPham != value))
				{
					this._MaSanPham = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gmail", DbType="NVarChar(50)")]
		public string Gmail
		{
			get
			{
				return this._Gmail;
			}
			set
			{
				if ((this._Gmail != value))
				{
					this._Gmail = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="Int")]
		public System.Nullable<int> SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this._SoLuong = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TongTien", DbType="Int")]
		public System.Nullable<int> TongTien
		{
			get
			{
				return this._TongTien;
			}
			set
			{
				if ((this._TongTien != value))
				{
					this._TongTien = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TongTienHoaDon", DbType="Money")]
		public System.Nullable<decimal> TongTienHoaDon
		{
			get
			{
				return this._TongTienHoaDon;
			}
			set
			{
				if ((this._TongTienHoaDon != value))
				{
					this._TongTienHoaDon = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayLapHoaDon", DbType="Date")]
		public System.Nullable<System.DateTime> NgayLapHoaDon
		{
			get
			{
				return this._NgayLapHoaDon;
			}
			set
			{
				if ((this._NgayLapHoaDon != value))
				{
					this._NgayLapHoaDon = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image", DbType="NVarChar(100)")]
		public string Image
		{
			get
			{
				return this._Image;
			}
			set
			{
				if ((this._Image != value))
				{
					this._Image = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.View_BieuMauGio")]
	public partial class View_BieuMauGio
	{
		
		private string _TenSanPham;
		
		private System.Nullable<int> _SoLuong;
		
		private System.Nullable<int> _TongTien;
		
		private System.Nullable<decimal> _TongTienHoaDon;
		
		private System.Nullable<System.DateTime> _NgayLapHoaDon;
		
		private string _Gmail;
		
		public View_BieuMauGio()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSanPham", DbType="NVarChar(200)")]
		public string TenSanPham
		{
			get
			{
				return this._TenSanPham;
			}
			set
			{
				if ((this._TenSanPham != value))
				{
					this._TenSanPham = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="Int")]
		public System.Nullable<int> SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this._SoLuong = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TongTien", DbType="Int")]
		public System.Nullable<int> TongTien
		{
			get
			{
				return this._TongTien;
			}
			set
			{
				if ((this._TongTien != value))
				{
					this._TongTien = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TongTienHoaDon", DbType="Money")]
		public System.Nullable<decimal> TongTienHoaDon
		{
			get
			{
				return this._TongTienHoaDon;
			}
			set
			{
				if ((this._TongTienHoaDon != value))
				{
					this._TongTienHoaDon = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayLapHoaDon", DbType="Date")]
		public System.Nullable<System.DateTime> NgayLapHoaDon
		{
			get
			{
				return this._NgayLapHoaDon;
			}
			set
			{
				if ((this._NgayLapHoaDon != value))
				{
					this._NgayLapHoaDon = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gmail", DbType="NVarChar(50)")]
		public string Gmail
		{
			get
			{
				return this._Gmail;
			}
			set
			{
				if ((this._Gmail != value))
				{
					this._Gmail = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.View_Anh")]
	public partial class View_Anh
	{
		
		private string _KetQua;
		
		private string _Anh;
		
		public View_Anh()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KetQua", DbType="NVarChar(100)")]
		public string KetQua
		{
			get
			{
				return this._KetQua;
			}
			set
			{
				if ((this._KetQua != value))
				{
					this._KetQua = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Anh", DbType="NVarChar(100)")]
		public string Anh
		{
			get
			{
				return this._Anh;
			}
			set
			{
				if ((this._Anh != value))
				{
					this._Anh = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ChiTietHoaDon")]
	public partial class ChiTietHoaDon : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaHoaDon;
		
		private System.Nullable<int> _MaSanPham;
		
		private string _Gmail;
		
		private System.Nullable<int> _SoLuong;
		
		private System.Nullable<int> _TongTien;
		
		private System.Nullable<int> _TongTienHoaDon;
		
		private System.Nullable<System.DateTime> _NgayLapHoaDon;
		
		private System.Nullable<int> _MaNhanVien;
		
		private EntityRef<SanPham> _SanPham;
		
		private EntityRef<KhachHang> _KhachHang;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHoaDonChanging(int value);
    partial void OnMaHoaDonChanged();
    partial void OnMaSanPhamChanging(System.Nullable<int> value);
    partial void OnMaSanPhamChanged();
    partial void OnGmailChanging(string value);
    partial void OnGmailChanged();
    partial void OnSoLuongChanging(System.Nullable<int> value);
    partial void OnSoLuongChanged();
    partial void OnTongTienChanging(System.Nullable<int> value);
    partial void OnTongTienChanged();
    partial void OnTongTienHoaDonChanging(System.Nullable<int> value);
    partial void OnTongTienHoaDonChanged();
    partial void OnNgayLapHoaDonChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayLapHoaDonChanged();
    partial void OnMaNhanVienChanging(System.Nullable<int> value);
    partial void OnMaNhanVienChanged();
    #endregion
		
		public ChiTietHoaDon()
		{
			this._SanPham = default(EntityRef<SanPham>);
			this._KhachHang = default(EntityRef<KhachHang>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHoaDon", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaHoaDon
		{
			get
			{
				return this._MaHoaDon;
			}
			set
			{
				if ((this._MaHoaDon != value))
				{
					this.OnMaHoaDonChanging(value);
					this.SendPropertyChanging();
					this._MaHoaDon = value;
					this.SendPropertyChanged("MaHoaDon");
					this.OnMaHoaDonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSanPham", DbType="Int")]
		public System.Nullable<int> MaSanPham
		{
			get
			{
				return this._MaSanPham;
			}
			set
			{
				if ((this._MaSanPham != value))
				{
					if (this._SanPham.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaSanPhamChanging(value);
					this.SendPropertyChanging();
					this._MaSanPham = value;
					this.SendPropertyChanged("MaSanPham");
					this.OnMaSanPhamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gmail", DbType="NVarChar(50)")]
		public string Gmail
		{
			get
			{
				return this._Gmail;
			}
			set
			{
				if ((this._Gmail != value))
				{
					if (this._KhachHang.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnGmailChanging(value);
					this.SendPropertyChanging();
					this._Gmail = value;
					this.SendPropertyChanged("Gmail");
					this.OnGmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="Int")]
		public System.Nullable<int> SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this.OnSoLuongChanging(value);
					this.SendPropertyChanging();
					this._SoLuong = value;
					this.SendPropertyChanged("SoLuong");
					this.OnSoLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TongTien", DbType="Int")]
		public System.Nullable<int> TongTien
		{
			get
			{
				return this._TongTien;
			}
			set
			{
				if ((this._TongTien != value))
				{
					this.OnTongTienChanging(value);
					this.SendPropertyChanging();
					this._TongTien = value;
					this.SendPropertyChanged("TongTien");
					this.OnTongTienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TongTienHoaDon", DbType="Int")]
		public System.Nullable<int> TongTienHoaDon
		{
			get
			{
				return this._TongTienHoaDon;
			}
			set
			{
				if ((this._TongTienHoaDon != value))
				{
					this.OnTongTienHoaDonChanging(value);
					this.SendPropertyChanging();
					this._TongTienHoaDon = value;
					this.SendPropertyChanged("TongTienHoaDon");
					this.OnTongTienHoaDonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayLapHoaDon", DbType="Date")]
		public System.Nullable<System.DateTime> NgayLapHoaDon
		{
			get
			{
				return this._NgayLapHoaDon;
			}
			set
			{
				if ((this._NgayLapHoaDon != value))
				{
					this.OnNgayLapHoaDonChanging(value);
					this.SendPropertyChanging();
					this._NgayLapHoaDon = value;
					this.SendPropertyChanged("NgayLapHoaDon");
					this.OnNgayLapHoaDonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNhanVien", DbType="Int")]
		public System.Nullable<int> MaNhanVien
		{
			get
			{
				return this._MaNhanVien;
			}
			set
			{
				if ((this._MaNhanVien != value))
				{
					this.OnMaNhanVienChanging(value);
					this.SendPropertyChanging();
					this._MaNhanVien = value;
					this.SendPropertyChanged("MaNhanVien");
					this.OnMaNhanVienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SanPham_ChiTietHoaDon", Storage="_SanPham", ThisKey="MaSanPham", OtherKey="MaSanPham", IsForeignKey=true)]
		public SanPham SanPham
		{
			get
			{
				return this._SanPham.Entity;
			}
			set
			{
				SanPham previousValue = this._SanPham.Entity;
				if (((previousValue != value) 
							|| (this._SanPham.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SanPham.Entity = null;
						previousValue.ChiTietHoaDons.Remove(this);
					}
					this._SanPham.Entity = value;
					if ((value != null))
					{
						value.ChiTietHoaDons.Add(this);
						this._MaSanPham = value.MaSanPham;
					}
					else
					{
						this._MaSanPham = default(Nullable<int>);
					}
					this.SendPropertyChanged("SanPham");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhachHang_ChiTietHoaDon", Storage="_KhachHang", ThisKey="Gmail", OtherKey="Gmail", IsForeignKey=true)]
		public KhachHang KhachHang
		{
			get
			{
				return this._KhachHang.Entity;
			}
			set
			{
				KhachHang previousValue = this._KhachHang.Entity;
				if (((previousValue != value) 
							|| (this._KhachHang.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KhachHang.Entity = null;
						previousValue.ChiTietHoaDons.Remove(this);
					}
					this._KhachHang.Entity = value;
					if ((value != null))
					{
						value.ChiTietHoaDons.Add(this);
						this._Gmail = value.Gmail;
					}
					else
					{
						this._Gmail = default(string);
					}
					this.SendPropertyChanged("KhachHang");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SanPham")]
	public partial class SanPham : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaSanPham;
		
		private System.Nullable<int> _MaNhaPhanPhoi;
		
		private string _TenSanPham;
		
		private System.Nullable<int> _LoaiSanPham;
		
		private System.Nullable<int> _HangSanXuat;
		
		private System.Nullable<int> _GiaBan;
		
		private int _TonKho;
		
		private string _Image;
		
		private EntitySet<ChiTietHoaDon> _ChiTietHoaDons;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaSanPhamChanging(int value);
    partial void OnMaSanPhamChanged();
    partial void OnMaNhaPhanPhoiChanging(System.Nullable<int> value);
    partial void OnMaNhaPhanPhoiChanged();
    partial void OnTenSanPhamChanging(string value);
    partial void OnTenSanPhamChanged();
    partial void OnLoaiSanPhamChanging(System.Nullable<int> value);
    partial void OnLoaiSanPhamChanged();
    partial void OnHangSanXuatChanging(System.Nullable<int> value);
    partial void OnHangSanXuatChanged();
    partial void OnGiaBanChanging(System.Nullable<int> value);
    partial void OnGiaBanChanged();
    partial void OnTonKhoChanging(int value);
    partial void OnTonKhoChanged();
    partial void OnImageChanging(string value);
    partial void OnImageChanged();
    #endregion
		
		public SanPham()
		{
			this._ChiTietHoaDons = new EntitySet<ChiTietHoaDon>(new Action<ChiTietHoaDon>(this.attach_ChiTietHoaDons), new Action<ChiTietHoaDon>(this.detach_ChiTietHoaDons));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSanPham", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaSanPham
		{
			get
			{
				return this._MaSanPham;
			}
			set
			{
				if ((this._MaSanPham != value))
				{
					this.OnMaSanPhamChanging(value);
					this.SendPropertyChanging();
					this._MaSanPham = value;
					this.SendPropertyChanged("MaSanPham");
					this.OnMaSanPhamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNhaPhanPhoi", DbType="Int")]
		public System.Nullable<int> MaNhaPhanPhoi
		{
			get
			{
				return this._MaNhaPhanPhoi;
			}
			set
			{
				if ((this._MaNhaPhanPhoi != value))
				{
					this.OnMaNhaPhanPhoiChanging(value);
					this.SendPropertyChanging();
					this._MaNhaPhanPhoi = value;
					this.SendPropertyChanged("MaNhaPhanPhoi");
					this.OnMaNhaPhanPhoiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSanPham", DbType="NVarChar(200)")]
		public string TenSanPham
		{
			get
			{
				return this._TenSanPham;
			}
			set
			{
				if ((this._TenSanPham != value))
				{
					this.OnTenSanPhamChanging(value);
					this.SendPropertyChanging();
					this._TenSanPham = value;
					this.SendPropertyChanged("TenSanPham");
					this.OnTenSanPhamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoaiSanPham", DbType="Int")]
		public System.Nullable<int> LoaiSanPham
		{
			get
			{
				return this._LoaiSanPham;
			}
			set
			{
				if ((this._LoaiSanPham != value))
				{
					this.OnLoaiSanPhamChanging(value);
					this.SendPropertyChanging();
					this._LoaiSanPham = value;
					this.SendPropertyChanged("LoaiSanPham");
					this.OnLoaiSanPhamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HangSanXuat", DbType="Int")]
		public System.Nullable<int> HangSanXuat
		{
			get
			{
				return this._HangSanXuat;
			}
			set
			{
				if ((this._HangSanXuat != value))
				{
					this.OnHangSanXuatChanging(value);
					this.SendPropertyChanging();
					this._HangSanXuat = value;
					this.SendPropertyChanged("HangSanXuat");
					this.OnHangSanXuatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaBan", DbType="Int")]
		public System.Nullable<int> GiaBan
		{
			get
			{
				return this._GiaBan;
			}
			set
			{
				if ((this._GiaBan != value))
				{
					this.OnGiaBanChanging(value);
					this.SendPropertyChanging();
					this._GiaBan = value;
					this.SendPropertyChanged("GiaBan");
					this.OnGiaBanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TonKho", DbType="Int NOT NULL")]
		public int TonKho
		{
			get
			{
				return this._TonKho;
			}
			set
			{
				if ((this._TonKho != value))
				{
					this.OnTonKhoChanging(value);
					this.SendPropertyChanging();
					this._TonKho = value;
					this.SendPropertyChanged("TonKho");
					this.OnTonKhoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image", DbType="NVarChar(100)")]
		public string Image
		{
			get
			{
				return this._Image;
			}
			set
			{
				if ((this._Image != value))
				{
					this.OnImageChanging(value);
					this.SendPropertyChanging();
					this._Image = value;
					this.SendPropertyChanged("Image");
					this.OnImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SanPham_ChiTietHoaDon", Storage="_ChiTietHoaDons", ThisKey="MaSanPham", OtherKey="MaSanPham")]
		public EntitySet<ChiTietHoaDon> ChiTietHoaDons
		{
			get
			{
				return this._ChiTietHoaDons;
			}
			set
			{
				this._ChiTietHoaDons.Assign(value);
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
		
		private void attach_ChiTietHoaDons(ChiTietHoaDon entity)
		{
			this.SendPropertyChanging();
			entity.SanPham = this;
		}
		
		private void detach_ChiTietHoaDons(ChiTietHoaDon entity)
		{
			this.SendPropertyChanging();
			entity.SanPham = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.View_KH")]
	public partial class View_KH
	{
		
		private string _Gmail;
		
		private string _Pass;
		
		private string _TenKhachHang;
		
		private System.Nullable<System.DateTime> _Ngaysinh;
		
		private string _GioiTinh;
		
		private string _DiaChi;
		
		private string _SDT;
		
		public View_KH()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gmail", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Gmail
		{
			get
			{
				return this._Gmail;
			}
			set
			{
				if ((this._Gmail != value))
				{
					this._Gmail = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pass", DbType="NVarChar(50)")]
		public string Pass
		{
			get
			{
				return this._Pass;
			}
			set
			{
				if ((this._Pass != value))
				{
					this._Pass = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKhachHang", DbType="NVarChar(50)")]
		public string TenKhachHang
		{
			get
			{
				return this._TenKhachHang;
			}
			set
			{
				if ((this._TenKhachHang != value))
				{
					this._TenKhachHang = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ngaysinh", DbType="Date")]
		public System.Nullable<System.DateTime> Ngaysinh
		{
			get
			{
				return this._Ngaysinh;
			}
			set
			{
				if ((this._Ngaysinh != value))
				{
					this._Ngaysinh = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioiTinh", DbType="NVarChar(10)")]
		public string GioiTinh
		{
			get
			{
				return this._GioiTinh;
			}
			set
			{
				if ((this._GioiTinh != value))
				{
					this._GioiTinh = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(50)")]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this._DiaChi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="VarChar(11)")]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this._SDT = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KhachHang")]
	public partial class KhachHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Gmail;
		
		private string _Pass;
		
		private string _TenKhachHang;
		
		private System.Nullable<System.DateTime> _Ngaysinh;
		
		private string _GioiTinh;
		
		private string _DiaChi;
		
		private string _SDT;
		
		private EntitySet<ChiTietHoaDon> _ChiTietHoaDons;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnGmailChanging(string value);
    partial void OnGmailChanged();
    partial void OnPassChanging(string value);
    partial void OnPassChanged();
    partial void OnTenKhachHangChanging(string value);
    partial void OnTenKhachHangChanged();
    partial void OnNgaysinhChanging(System.Nullable<System.DateTime> value);
    partial void OnNgaysinhChanged();
    partial void OnGioiTinhChanging(string value);
    partial void OnGioiTinhChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    #endregion
		
		public KhachHang()
		{
			this._ChiTietHoaDons = new EntitySet<ChiTietHoaDon>(new Action<ChiTietHoaDon>(this.attach_ChiTietHoaDons), new Action<ChiTietHoaDon>(this.detach_ChiTietHoaDons));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gmail", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Gmail
		{
			get
			{
				return this._Gmail;
			}
			set
			{
				if ((this._Gmail != value))
				{
					this.OnGmailChanging(value);
					this.SendPropertyChanging();
					this._Gmail = value;
					this.SendPropertyChanged("Gmail");
					this.OnGmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pass", DbType="NVarChar(50)")]
		public string Pass
		{
			get
			{
				return this._Pass;
			}
			set
			{
				if ((this._Pass != value))
				{
					this.OnPassChanging(value);
					this.SendPropertyChanging();
					this._Pass = value;
					this.SendPropertyChanged("Pass");
					this.OnPassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKhachHang", DbType="NVarChar(50)")]
		public string TenKhachHang
		{
			get
			{
				return this._TenKhachHang;
			}
			set
			{
				if ((this._TenKhachHang != value))
				{
					this.OnTenKhachHangChanging(value);
					this.SendPropertyChanging();
					this._TenKhachHang = value;
					this.SendPropertyChanged("TenKhachHang");
					this.OnTenKhachHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ngaysinh", DbType="Date")]
		public System.Nullable<System.DateTime> Ngaysinh
		{
			get
			{
				return this._Ngaysinh;
			}
			set
			{
				if ((this._Ngaysinh != value))
				{
					this.OnNgaysinhChanging(value);
					this.SendPropertyChanging();
					this._Ngaysinh = value;
					this.SendPropertyChanged("Ngaysinh");
					this.OnNgaysinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioiTinh", DbType="NVarChar(10)")]
		public string GioiTinh
		{
			get
			{
				return this._GioiTinh;
			}
			set
			{
				if ((this._GioiTinh != value))
				{
					this.OnGioiTinhChanging(value);
					this.SendPropertyChanging();
					this._GioiTinh = value;
					this.SendPropertyChanged("GioiTinh");
					this.OnGioiTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(50)")]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="VarChar(11)")]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhachHang_ChiTietHoaDon", Storage="_ChiTietHoaDons", ThisKey="Gmail", OtherKey="Gmail")]
		public EntitySet<ChiTietHoaDon> ChiTietHoaDons
		{
			get
			{
				return this._ChiTietHoaDons;
			}
			set
			{
				this._ChiTietHoaDons.Assign(value);
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
		
		private void attach_ChiTietHoaDons(ChiTietHoaDon entity)
		{
			this.SendPropertyChanging();
			entity.KhachHang = this;
		}
		
		private void detach_ChiTietHoaDons(ChiTietHoaDon entity)
		{
			this.SendPropertyChanging();
			entity.KhachHang = null;
		}
	}
}
#pragma warning restore 1591