/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-08-28
 * 时间: 16:59
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

namespace BLL
{
	/// <summary>
	/// Description of WyInfosBLL.
	/// </summary>
	public class WyInfosBLL
	{
		public WyInfosBLL()
		{
		}
		
		//添加新的
		public static void AddWyInfos(WyInfos tNew)
		{
			ISession session = NHibernateHelper.sessionFactory.OpenSession();
			ITransaction tx = session.BeginTransaction();
			try
			{
				session.Save(tNew);
				tx.Commit();
				session.Close();				
			}
			catch(Exception e)
			{
				Debug.Assert(false,e.Message);
				tx.Rollback();
				session.Close();
			}
		}
		
		
		//修改
		public static void UpdateWyInfos(WyInfos tNew)
		{
			ISession session = NHibernateHelper.OpenSession();
			try
			{				
				ITransaction tx = session.BeginTransaction();
				WyInfos tModify = session.Get<WyInfos>(tNew.WyID);
				tModify.WyName = tNew.WyName;
				tModify.JZArea = tNew.JZArea;
				tModify.TNArea = tNew.TNArea;
				tModify.GTArea = tNew.GTArea;
				tModify.OwnerName = tNew.OwnerName;
				tModify.OwnerDetail = tNew.OwnerDetail;
				tModify.UNIT_No = tNew.UNIT_No;
				tModify.FLOOR_No = tNew.FLOOR_No;
				tModify.ROOM_No = tNew.ROOM_No;
				tModify.CustomerID = tNew.CustomerID;

				tx.Commit();
			}
			catch(Exception e)
			{
				Debug.Assert(false,e.Message);
			}
			session.Close();
		}
		
		//获取WyInfos
		public static DataSet GetAllWyInfos()
		{
			DataSet ds = new DataSet();
			ds = SQLiteHelper.ExecuteDataSet("SELECT WyID,WyName,JZArea,TNArea,GTArea,OwnerName,OwnerDetail,UNIT_No,FLOOR_No,ROOM_No,CustomerID FROM WyInfos");
			return ds;
		}
		
		//获取指定WyInfos
		public static WyInfos GetWyInfo(int i_WyID)
		{
			ISession session = NHibernateHelper.OpenSession();
			WyInfos tClass = new WyInfos();
			try
			{
				tClass = session.Get<WyInfos>(i_WyID);
			}
			catch(Exception e)
			{
				Debug.Assert(false,e.Message);
			}
			session.Close();
			return tClass;
		}
		
		//删除
		public static void DelWyInfo(int  i_WyID)
		{
			//ISessionFactory sessionFactory = new Configuration().Configure().BuildSessionFactory();
			ISession session = NHibernateHelper.OpenSession();
			ITransaction tx = session.BeginTransaction();
			WyInfos toDelete = session.Get<WyInfos>(i_WyID);
				
			try
			{
				if(!CanDelWyInfo(i_WyID))
				{
					session.Close();
					return;
				}
				session.Delete(toDelete);
				tx.Commit();
				session.Close();
			}
			catch(Exception e)
			{
				Debug.Assert(false,e.Message);
				tx.Rollback();
				session.Close();
			}
		}
		
		
		//指定的物业能删除？
		private static bool CanDelWyInfo(int i_WyID)
		{
			ISession session = NHibernateHelper.sessionFactory.OpenSession();
			int i_rtn = 0;
			//查询，Meters中是否存在
			i_rtn = Convert.ToInt32(SQLiteHelper.ExecuteScalar("SELECT Count(*) FROM Meters WHERE WyID = @WyID",i_WyID));
			if(i_rtn > 0)
			{
				MessageBox.Show("要删除的物业在计量表中有使用，不能删除！","提示信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
				session.Close();
				return false;
			}
			//查询，WyRates中是否存在
			i_rtn = Convert.ToInt32(SQLiteHelper.ExecuteScalar("SELECT Count(*) FROM WyRates WHERE WyID = @WyID",i_WyID));
			if(i_rtn > 0)
			{
				MessageBox.Show("要删除的物业在收费项中有使用，不能删除！","提示信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
				session.Close();
				return false;
			}

			session.Close();
			return true;
		}
		
		//将DataTable数据填充到数据库表中
		public static void FillWyInfos(DataTable tDt)
		{
			ISession session = NHibernateHelper.sessionFactory.OpenSession();
			ITransaction tx = session.BeginTransaction();
			try
			{
				DataRow[] drs;
		        drs = tDt.Select("1=1");
	            for (int i = 0; i < drs.Length; i++)
	            {
	            	WyInfos tNew = new WyInfos();
	            	
	            	tNew.WyName = drs[i]["WyName"].ToString();
	            	tNew.JZArea = Convert.ToDecimal(drs[i]["JZArea"].ToString());
	            	tNew.TNArea = Convert.ToDecimal(drs[i]["TNArea"].ToString());
	            	tNew.GTArea = Convert.ToDecimal(drs[i]["GTArea"].ToString());
	            	tNew.OwnerName = drs[i]["OwnerName"].ToString();
	            	tNew.OwnerDetail = drs[i]["OwnerDetail"].ToString();
	            	tNew.UNIT_No = Convert.ToInt32(drs[i]["UNIT_No"].ToString());
	            	tNew.FLOOR_No = Convert.ToInt32(drs[i]["FLOOR_No"].ToString());
	            	tNew.ROOM_No = Convert.ToInt32(drs[i]["ROOM_No"].ToString());

	            	session.Save(tNew);
	            	
	            }
				tx.Commit();
				session.Close();				
			}
			catch(Exception e)
			{
				Debug.Assert(false,e.Message);
				tx.Rollback();
				session.Close();
			}
		}
		
		//添加新的
		public static void AddWyRate(WyRates tNew)
		{
			ISession session = NHibernateHelper.sessionFactory.OpenSession();
			ITransaction tx = session.BeginTransaction();
			try
			{
				session.Save(tNew);
				tx.Commit();
				session.Close();				
			}
			catch(Exception e)
			{
				Debug.Assert(false,e.Message);
				tx.Rollback();
				session.Close();
			}
		}
		
		//删除
		public static void DelWyRate(int  i_WyRateID)
		{
			//ISessionFactory sessionFactory = new Configuration().Configure().BuildSessionFactory();
			ISession session = NHibernateHelper.OpenSession();
			ITransaction tx = session.BeginTransaction();
			WyRates toDelete = session.Get<WyRates>(i_WyRateID);
				
			try
			{

				session.Delete(toDelete);
				tx.Commit();
				session.Close();
			}
			catch(Exception e)
			{
				Debug.Assert(false,e.Message);
				tx.Rollback();
				session.Close();
			}
		}
		
		//获取指定WyID的收费项目，包含该物业的计量表
		public static DataSet GetAllWyRates(int i_WyID)
		{
			//从WyRates表中找
			DataSet ds = new DataSet();
			DataSet ds1 = new DataSet();
			DataSet ds2 = new DataSet();
			ds1 = SQLiteHelper.ExecuteDataSet("SELECT A.WyRateID,A.WyID,'一般收费项' As Brief,A.RateID,B.RateName,B.RateBrief,B.RateUnit,B.RateClass,B.RateValue FROM WyRates A,Rates B WHERE (A.RateID = B.RateID) AND A.WyID = @WyID ORDER By B.RateID",i_WyID);
			ds.Merge(ds1);
			//从物业信息中找
			ds2 = SQLiteHelper.ExecuteDataSet("SELECT 0 As WyRateID,A.WyID,'计量收费项' As Brief,B.RateID,B.RateName,B.RateBrief,B.RateUnit,B.RateClass,B.RateValue FROM Meters A,Rates B WHERE (A.RateID = B.RateID) AND A.WyID = @WyID ORDER By B.RateID",i_WyID);
			ds.Merge(ds2,false,MissingSchemaAction.Ignore);
			return ds;
		}
		
		//获取所有未对应缴费对象的物业
		public static DataSet GetNoCustomerWyInfos()
		{
			DataSet ds = new DataSet();
			ds = SQLiteHelper.ExecuteDataSet("select WyID,WyName From WyInfos Where CustomerID is NULL");
			return ds;
		}
		
		//获取物业缴费项重复的
		public static DataSet GetDupWyInfos()
		{
			DataSet ds = new DataSet();
			ds = SQLiteHelper.ExecuteDataSet("select A.WyRateID,A.WyID,B.WyName,A.RateID from WyRates A,WyInfos B WHERE A.WyID=B.WyID Group by A.WyID,A.RateID having count(*)>1");
			return ds;
		}

	}
}
