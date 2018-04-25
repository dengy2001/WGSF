/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-08-31
 * 时间: 9:48
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Data;
using NHibernate;
//using NHibernate.Cfg;
using DomainModel;
//using System.Data.SQLite;
using DAL;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics;
using System.Configuration;

namespace BLL
{
	/// <summary>
	/// Description of ComBLL.
	/// </summary>
	public class ComBLL
	{
		public ComBLL()
		{
		}
		
		//清空数据
		public static void ClearData()
		{
			//把数据库先备份下
			backupDatabase();
			//删除Meters		
			SQLiteHelper.ExecuteNonQuery("DELETE FROM Meters");
			//删除WyInfos
			SQLiteHelper.ExecuteNonQuery("DELETE FROM WyInfos");
			//删除Customers
			SQLiteHelper.ExecuteNonQuery("DELETE FROM Customers");
			//删除Rates
			SQLiteHelper.ExecuteNonQuery("DELETE FROM Rates");
			//删除WyRates
			SQLiteHelper.ExecuteNonQuery("DELETE FROM WyRates");
			//删除MeterReading
			SQLiteHelper.ExecuteNonQuery("DELETE FROM MeterReading");
			//删除ChargeDetail
			SQLiteHelper.ExecuteNonQuery("DELETE FROM ChargeDetail");
			//删除Charge
			SQLiteHelper.ExecuteNonQuery("DELETE FROM Charge");
			//删除ChargeF
			SQLiteHelper.ExecuteNonQuery("DELETE FROM ChargeF");
						
		}
		
		public static void backupDatabase()
		{
			//
			string sourcefile = ConfigurationManager.AppSettings["SQLiteConnectionString"];
			int startpos = sourcefile.IndexOf('=');
			sourcefile = sourcefile.Substring(startpos+1);
			DateTime dt = new DateTime();
			dt = System.DateTime.Now;
			string newfile = dt.ToString("yyyyMMddHHmmss");
			newfile = newfile + "BAK.db";
			System.IO.File.Copy(sourcefile,newfile);
		}
		
		
		
		
	}
}
