﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.8670
//     Support: http://www.cnblogs.com/huxj
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------


using System;
using System.Data;
using System.Data.Common;
using Dos.ORM;


namespace AhnqIot.Hxj.DbModel
{

	/// <summary>
	/// 实体类Farm 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Farm : Entity 
	{
		public Farm():base("Farm") {}

		#region Model
		private string _Serialnum;
		private DateTime _CreateTime;
		private string _CreateSysUserSerialnum;
		private DateTime _UpdateTime;
		private string _UpdateSysUserSerialnum;
		private string _Name;
		private string _SysDepartmentSerialnum;
		private string _CompanySerialnum;
		private string _AreaStationSerialnum;
		private string _UploadPassword;
		private string _APIKey;
		private string _Address;
		private string _Location;
		private string _Lotitude;
		private string _Latitude;
		private string _Introduce;
		private string _PhotoUrl;
		private string _ContactMan;
		private string _ContactPhone;
		private bool _Status;
		private int _Sort;
		private string _Remark;
		/// <summary>
		/// 编码
		/// </summary>
		public string Serialnum
		{
			get{ return _Serialnum; }
			set
			{
				this.OnPropertyValueChange(_.Serialnum,_Serialnum,value);
				this._Serialnum=value;
			}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime CreateTime
		{
			get{ return _CreateTime; }
			set
			{
				this.OnPropertyValueChange(_.CreateTime,_CreateTime,value);
				this._CreateTime=value;
			}
		}
		/// <summary>
		/// 创建用户
		/// </summary>
		public string CreateSysUserSerialnum
		{
			get{ return _CreateSysUserSerialnum; }
			set
			{
				this.OnPropertyValueChange(_.CreateSysUserSerialnum,_CreateSysUserSerialnum,value);
				this._CreateSysUserSerialnum=value;
			}
		}
		/// <summary>
		/// 更新时间
		/// </summary>
		public DateTime UpdateTime
		{
			get{ return _UpdateTime; }
			set
			{
				this.OnPropertyValueChange(_.UpdateTime,_UpdateTime,value);
				this._UpdateTime=value;
			}
		}
		/// <summary>
		/// 更新用户
		/// </summary>
		public string UpdateSysUserSerialnum
		{
			get{ return _UpdateSysUserSerialnum; }
			set
			{
				this.OnPropertyValueChange(_.UpdateSysUserSerialnum,_UpdateSysUserSerialnum,value);
				this._UpdateSysUserSerialnum=value;
			}
		}
		/// <summary>
		/// 名称
		/// </summary>
		public string Name
		{
			get{ return _Name; }
			set
			{
				this.OnPropertyValueChange(_.Name,_Name,value);
				this._Name=value;
			}
		}
		/// <summary>
		/// 机构
		/// </summary>
		public string SysDepartmentSerialnum
		{
			get{ return _SysDepartmentSerialnum; }
			set
			{
				this.OnPropertyValueChange(_.SysDepartmentSerialnum,_SysDepartmentSerialnum,value);
				this._SysDepartmentSerialnum=value;
			}
		}
		/// <summary>
		/// 企业
		/// </summary>
		public string CompanySerialnum
		{
			get{ return _CompanySerialnum; }
			set
			{
				this.OnPropertyValueChange(_.CompanySerialnum,_CompanySerialnum,value);
				this._CompanySerialnum=value;
			}
		}
		/// <summary>
		/// 关联气象站
		/// </summary>
		public string AreaStationSerialnum
		{
			get{ return _AreaStationSerialnum; }
			set
			{
				this.OnPropertyValueChange(_.AreaStationSerialnum,_AreaStationSerialnum,value);
				this._AreaStationSerialnum=value;
			}
		}
		/// <summary>
		/// 上传密码
		/// </summary>
		public string UploadPassword
		{
			get{ return _UploadPassword; }
			set
			{
				this.OnPropertyValueChange(_.UploadPassword,_UploadPassword,value);
				this._UploadPassword=value;
			}
		}
		/// <summary>
		/// 数据接口访问KEY
		/// </summary>
		public string APIKey
		{
			get{ return _APIKey; }
			set
			{
				this.OnPropertyValueChange(_.APIKey,_APIKey,value);
				this._APIKey=value;
			}
		}
		/// <summary>
		/// 地址
		/// </summary>
		public string Address
		{
			get{ return _Address; }
			set
			{
				this.OnPropertyValueChange(_.Address,_Address,value);
				this._Address=value;
			}
		}
		/// <summary>
		/// 位置
		/// </summary>
		public string Location
		{
			get{ return _Location; }
			set
			{
				this.OnPropertyValueChange(_.Location,_Location,value);
				this._Location=value;
			}
		}
		/// <summary>
		/// 经度
		/// </summary>
		public string Lotitude
		{
			get{ return _Lotitude; }
			set
			{
				this.OnPropertyValueChange(_.Lotitude,_Lotitude,value);
				this._Lotitude=value;
			}
		}
		/// <summary>
		/// 纬度
		/// </summary>
		public string Latitude
		{
			get{ return _Latitude; }
			set
			{
				this.OnPropertyValueChange(_.Latitude,_Latitude,value);
				this._Latitude=value;
			}
		}
		/// <summary>
		/// 基地介绍
		/// </summary>
		public string Introduce
		{
			get{ return _Introduce; }
			set
			{
				this.OnPropertyValueChange(_.Introduce,_Introduce,value);
				this._Introduce=value;
			}
		}
		/// <summary>
		/// 形象图片
		/// </summary>
		public string PhotoUrl
		{
			get{ return _PhotoUrl; }
			set
			{
				this.OnPropertyValueChange(_.PhotoUrl,_PhotoUrl,value);
				this._PhotoUrl=value;
			}
		}
		/// <summary>
		/// 联系人
		/// </summary>
		public string ContactMan
		{
			get{ return _ContactMan; }
			set
			{
				this.OnPropertyValueChange(_.ContactMan,_ContactMan,value);
				this._ContactMan=value;
			}
		}
		/// <summary>
		/// 联系电话
		/// </summary>
		public string ContactPhone
		{
			get{ return _ContactPhone; }
			set
			{
				this.OnPropertyValueChange(_.ContactPhone,_ContactPhone,value);
				this._ContactPhone=value;
			}
		}
		/// <summary>
		/// 状态
		/// </summary>
		public bool Status
		{
			get{ return _Status; }
			set
			{
				this.OnPropertyValueChange(_.Status,_Status,value);
				this._Status=value;
			}
		}
		/// <summary>
		/// 排序
		/// </summary>
		public int Sort
		{
			get{ return _Sort; }
			set
			{
				this.OnPropertyValueChange(_.Sort,_Sort,value);
				this._Sort=value;
			}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Remark
		{
			get{ return _Remark; }
			set
			{
				this.OnPropertyValueChange(_.Remark,_Remark,value);
				this._Remark=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.Serialnum};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.Serialnum,
				_.CreateTime,
				_.CreateSysUserSerialnum,
				_.UpdateTime,
				_.UpdateSysUserSerialnum,
				_.Name,
				_.SysDepartmentSerialnum,
				_.CompanySerialnum,
				_.AreaStationSerialnum,
				_.UploadPassword,
				_.APIKey,
				_.Address,
				_.Location,
				_.Lotitude,
				_.Latitude,
				_.Introduce,
				_.PhotoUrl,
				_.ContactMan,
				_.ContactPhone,
				_.Status,
				_.Sort,
				_.Remark};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._Serialnum,
				this._CreateTime,
				this._CreateSysUserSerialnum,
				this._UpdateTime,
				this._UpdateSysUserSerialnum,
				this._Name,
				this._SysDepartmentSerialnum,
				this._CompanySerialnum,
				this._AreaStationSerialnum,
				this._UploadPassword,
				this._APIKey,
				this._Address,
				this._Location,
				this._Lotitude,
				this._Latitude,
				this._Introduce,
				this._PhotoUrl,
				this._ContactMan,
				this._ContactPhone,
				this._Status,
				this._Sort,
				this._Remark};
		}
		/// <summary>
		/// 给当前实体赋值
		/// </summary>
		public override void SetPropertyValues(IDataReader reader)
		{
			this._Serialnum = DataUtils.ConvertValue<string>(reader["Serialnum"]);
			this._CreateTime = DataUtils.ConvertValue<DateTime>(reader["CreateTime"]);
			this._CreateSysUserSerialnum = DataUtils.ConvertValue<string>(reader["CreateSysUserSerialnum"]);
			this._UpdateTime = DataUtils.ConvertValue<DateTime>(reader["UpdateTime"]);
			this._UpdateSysUserSerialnum = DataUtils.ConvertValue<string>(reader["UpdateSysUserSerialnum"]);
			this._Name = DataUtils.ConvertValue<string>(reader["Name"]);
			this._SysDepartmentSerialnum = DataUtils.ConvertValue<string>(reader["SysDepartmentSerialnum"]);
			this._CompanySerialnum = DataUtils.ConvertValue<string>(reader["CompanySerialnum"]);
			this._AreaStationSerialnum = DataUtils.ConvertValue<string>(reader["AreaStationSerialnum"]);
			this._UploadPassword = DataUtils.ConvertValue<string>(reader["UploadPassword"]);
			this._APIKey = DataUtils.ConvertValue<string>(reader["APIKey"]);
			this._Address = DataUtils.ConvertValue<string>(reader["Address"]);
			this._Location = DataUtils.ConvertValue<string>(reader["Location"]);
			this._Lotitude = DataUtils.ConvertValue<string>(reader["Lotitude"]);
			this._Latitude = DataUtils.ConvertValue<string>(reader["Latitude"]);
			this._Introduce = DataUtils.ConvertValue<string>(reader["Introduce"]);
			this._PhotoUrl = DataUtils.ConvertValue<string>(reader["PhotoUrl"]);
			this._ContactMan = DataUtils.ConvertValue<string>(reader["ContactMan"]);
			this._ContactPhone = DataUtils.ConvertValue<string>(reader["ContactPhone"]);
			this._Status = DataUtils.ConvertValue<bool>(reader["Status"]);
			this._Sort = DataUtils.ConvertValue<int>(reader["Sort"]);
			this._Remark = DataUtils.ConvertValue<string>(reader["Remark"]);
		}
		/// <summary>
		/// 给当前实体赋值
		/// </summary>
		public override void SetPropertyValues(DataRow row)
		{
			this._Serialnum = DataUtils.ConvertValue<string>(row["Serialnum"]);
			this._CreateTime = DataUtils.ConvertValue<DateTime>(row["CreateTime"]);
			this._CreateSysUserSerialnum = DataUtils.ConvertValue<string>(row["CreateSysUserSerialnum"]);
			this._UpdateTime = DataUtils.ConvertValue<DateTime>(row["UpdateTime"]);
			this._UpdateSysUserSerialnum = DataUtils.ConvertValue<string>(row["UpdateSysUserSerialnum"]);
			this._Name = DataUtils.ConvertValue<string>(row["Name"]);
			this._SysDepartmentSerialnum = DataUtils.ConvertValue<string>(row["SysDepartmentSerialnum"]);
			this._CompanySerialnum = DataUtils.ConvertValue<string>(row["CompanySerialnum"]);
			this._AreaStationSerialnum = DataUtils.ConvertValue<string>(row["AreaStationSerialnum"]);
			this._UploadPassword = DataUtils.ConvertValue<string>(row["UploadPassword"]);
			this._APIKey = DataUtils.ConvertValue<string>(row["APIKey"]);
			this._Address = DataUtils.ConvertValue<string>(row["Address"]);
			this._Location = DataUtils.ConvertValue<string>(row["Location"]);
			this._Lotitude = DataUtils.ConvertValue<string>(row["Lotitude"]);
			this._Latitude = DataUtils.ConvertValue<string>(row["Latitude"]);
			this._Introduce = DataUtils.ConvertValue<string>(row["Introduce"]);
			this._PhotoUrl = DataUtils.ConvertValue<string>(row["PhotoUrl"]);
			this._ContactMan = DataUtils.ConvertValue<string>(row["ContactMan"]);
			this._ContactPhone = DataUtils.ConvertValue<string>(row["ContactPhone"]);
			this._Status = DataUtils.ConvertValue<bool>(row["Status"]);
			this._Sort = DataUtils.ConvertValue<int>(row["Sort"]);
			this._Remark = DataUtils.ConvertValue<string>(row["Remark"]);
		}
		#endregion

		#region _Field
		/// <summary>
		/// 字段信息
		/// </summary>
		public class _
		{
			/// <summary>
			/// * 
			/// </summary>
			public readonly static Field All = new Field("*","Farm");
			/// <summary>
			/// 编码
			/// </summary>
			public readonly static Field Serialnum = new Field("Serialnum","Farm","编码");
			/// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CreateTime = new Field("CreateTime","Farm","创建时间");
			/// <summary>
			/// 创建用户
			/// </summary>
			public readonly static Field CreateSysUserSerialnum = new Field("CreateSysUserSerialnum","Farm","创建用户");
			/// <summary>
			/// 更新时间
			/// </summary>
			public readonly static Field UpdateTime = new Field("UpdateTime","Farm","更新时间");
			/// <summary>
			/// 更新用户
			/// </summary>
			public readonly static Field UpdateSysUserSerialnum = new Field("UpdateSysUserSerialnum","Farm","更新用户");
			/// <summary>
			/// 名称
			/// </summary>
			public readonly static Field Name = new Field("Name","Farm","名称");
			/// <summary>
			/// 机构
			/// </summary>
			public readonly static Field SysDepartmentSerialnum = new Field("SysDepartmentSerialnum","Farm","机构");
			/// <summary>
			/// 企业
			/// </summary>
			public readonly static Field CompanySerialnum = new Field("CompanySerialnum","Farm","企业");
			/// <summary>
			/// 关联气象站
			/// </summary>
			public readonly static Field AreaStationSerialnum = new Field("AreaStationSerialnum","Farm","关联气象站");
			/// <summary>
			/// 上传密码
			/// </summary>
			public readonly static Field UploadPassword = new Field("UploadPassword","Farm","上传密码");
			/// <summary>
			/// 数据接口访问KEY
			/// </summary>
			public readonly static Field APIKey = new Field("APIKey","Farm","数据接口访问KEY");
			/// <summary>
			/// 地址
			/// </summary>
			public readonly static Field Address = new Field("Address","Farm","地址");
			/// <summary>
			/// 位置
			/// </summary>
			public readonly static Field Location = new Field("Location","Farm","位置");
			/// <summary>
			/// 经度
			/// </summary>
			public readonly static Field Lotitude = new Field("Lotitude","Farm","经度");
			/// <summary>
			/// 纬度
			/// </summary>
			public readonly static Field Latitude = new Field("Latitude","Farm","纬度");
			/// <summary>
			/// 基地介绍
			/// </summary>
			public readonly static Field Introduce = new Field("Introduce","Farm","基地介绍");
			/// <summary>
			/// 形象图片
			/// </summary>
			public readonly static Field PhotoUrl = new Field("PhotoUrl","Farm","形象图片");
			/// <summary>
			/// 联系人
			/// </summary>
			public readonly static Field ContactMan = new Field("ContactMan","Farm","联系人");
			/// <summary>
			/// 联系电话
			/// </summary>
			public readonly static Field ContactPhone = new Field("ContactPhone","Farm","联系电话");
			/// <summary>
			/// 状态
			/// </summary>
			public readonly static Field Status = new Field("Status","Farm","状态");
			/// <summary>
			/// 排序
			/// </summary>
			public readonly static Field Sort = new Field("Sort","Farm","排序");
			/// <summary>
			/// 备注
			/// </summary>
			public readonly static Field Remark = new Field("Remark","Farm","备注");
		}
		#endregion


	}
}
