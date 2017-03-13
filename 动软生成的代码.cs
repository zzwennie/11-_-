using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// 学生:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class 学生
	{
		public 学生()
		{}
		#region Model
		private string _学生号;
		private string _密码;
		private string _姓名;
		private string _性别;
		private int _年级;
		private string _专业;
		/// <summary>
		/// 
		/// </summary>
		public string 学生号
		{
			set{ _学生号=value;}
			get{return _学生号;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 密码
		{
			set{ _密码=value;}
			get{return _密码;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 姓名
		{
			set{ _姓名=value;}
			get{return _姓名;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 性别
		{
			set{ _性别=value;}
			get{return _性别;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int 年级
		{
			set{ _年级=value;}
			get{return _年级;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 专业
		{
			set{ _专业=value;}
			get{return _专业;}
		}
		#endregion Model

	}
}

