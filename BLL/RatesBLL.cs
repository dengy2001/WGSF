/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-08-27
 * 时间: 18:15
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
	/// Description of RatesBLL.
	/// </summary>
	public class RatesBLL
	{
		public RatesBLL()
		{
		}
		
		//添加新的
		public static void AddRates(Rates tNew)
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
		public static void UpdateRates(Rates tNew)
		{
			ISession session = NHibernateHelper.OpenSession();
			try
			{				
				ITransaction tx = session.BeginTransaction();
				Rates tModify = session.Get<Rates>(tNew.RateID);
				tModify.RateName = tNew.RateName;
				tModify.RateBrief = tNew.RateBrief;
				tModify.RateUnit = tNew.RateUnit;
				tModify.RateClass = tNew.RateClass;
				tModify.RateValue = tNew.RateValue;

				tx.Commit();
			}
			catch(Exception e)
			{
				Debug.Assert(false,e.Message);
			}
			session.Close();
		}
		
		//获取Rates
		public static DataSet GetAllRates()
		{
			DataSet ds = new DataSet();
			ds = SQLiteHelper.ExecuteDataSet("SELECT RateID,RateName,RateBrief,RateUnit,RateClass,RateValue FROM Rates ORDER BY RateClass");
			return ds;
		}
		
		//获取计量表Rates
		public static DataSet GetAllMeterRates()
		{
			DataSet ds = new DataSet();
			ds = SQLiteHelper.ExecuteDataSet("SELECT RateID,RateName,RateBrief,RateUnit,RateClass,RateValue FROM Rates WHERE RateClass = '表计量收费' ORDER BY RateClass");
			return ds;
		}
		
		//获取非计量表Rates
		public static DataSet GetAllNotMeterRates()
		{
			DataSet ds = new DataSet();
			ds = SQLiteHelper.ExecuteDataSet("SELECT RateID,RateName,RateBrief,RateUnit,RateClass,RateValue FROM Rates WHERE RateClass <> '表计量收费' ORDER BY RateClass");
			return ds;
		}
		
		//获取指定Rates
		public static Rates GetRate(int i_RateID)
		{
			ISession session = NHibernateHelper.OpenSession();
			Rates tClass = new Rates();
			try
			{
				tClass = session.Get<Rates>(i_RateID);
			}
			catch(Exception e)
			{
				Debug.Assert(false,e.Message);
			}
			session.Close();
			return tClass;
		}
		
		//删除
		public static void DelRate(int  i_RateID)
		{
			//ISessionFactory sessionFactory = new Configuration().Configure().BuildSessionFactory();
			ISession session = NHibernateHelper.OpenSession();
			ITransaction tx = session.BeginTransaction();
			Rates toDelete = session.Get<Rates>(i_RateID);
				
			try
			{
				if(!CanDelRate(i_RateID))
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
		
		
		//指定的收支项目能删除？
		private static bool CanDelRate(int i_RateID)
		{
			ISession session = NHibernateHelper.sessionFactory.OpenSession();
			int i_rtn = 0;
			//查询，Meters中是否存在
			i_rtn = Convert.ToInt32(SQLiteHelper.ExecuteScalar("SELECT Count(*) FROM Meters WHERE RateID = @RateID",i_RateID));
			if(i_rtn > 0)
			{
				MessageBox.Show("要删除的收费项在计量表中有使用，不能删除！","提示信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
				session.Close();
				return false;
			}
			//查询，WyRates中是否存在
			i_rtn = Convert.ToInt32(SQLiteHelper.ExecuteScalar("SELECT Count(*) FROM WyRates WHERE RateID = @RateID",i_RateID));
			if(i_rtn > 0)
			{
				MessageBox.Show("要删除的收费项在物业中有使用，不能删除！","提示信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
				session.Close();
				return false;
			}
			session.Close();
			return true;
		}
		
		
	}
}
