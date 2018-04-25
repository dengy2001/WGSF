/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-08-29
 * 时间: 20:12
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
	/// Description of MetersBLL.
	/// </summary>
	public class MetersBLL
	{
		public MetersBLL()
		{
		}
		
		//添加新的
		public static void AddMeter(Meters tNew)
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
		
		//查询MeterID修改后是否循环
		public static bool IsLoopMeter(int i_MeterID,int i_constMeterID)
		{			
			if(i_MeterID == i_constMeterID)
			{
				return true;
			}
			ISession session = NHibernateHelper.OpenSession();
			Meters tm = session.Get<Meters>(i_MeterID);
			if(tm.MeterPID != null)
			{
				return IsLoopMeter(Convert.ToInt32(tm.MeterPID.ToString()),i_constMeterID);
			}
			return false;
		}
		
		//修改
		public static void UpdateMeter(Meters tNew)
		{
			ISession session = NHibernateHelper.OpenSession();
			try
			{				
				ITransaction tx = session.BeginTransaction();
				Meters tModify = session.Get<Meters>(tNew.MeterID);
				//检查是否会循环
				if(tNew.MeterPID != null)
				{
					if(IsLoopMeter(Convert.ToInt32(tNew.MeterPID.ToString()),tModify.MeterID))
					{
						MessageBox.Show("计量表循环！","提示信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
						return;
					}
				}
				tModify.MeterPID = tNew.MeterPID;
				tModify.MeterClass = tNew.MeterClass;
				tModify.MeterName = tNew.MeterName;
				tModify.MeterUsing = tNew.MeterUsing;
				tModify.MeterCanSharing = tNew.MeterCanSharing;
				tModify.MeterSelfUse = tNew.MeterSelfUse;
				tModify.MeterMulti = tNew.MeterMulti;
				tModify.MeterMaxNumber = tNew.MeterMaxNumber;
				tModify.RateID = tNew.RateID;
				tModify.WyID = tNew.WyID;

				tx.Commit();
			}
			catch(Exception e)
			{
				Debug.Assert(false,e.Message);
			}
			session.Close();
		}
		
		//获取Meters
		public static DataSet GetAllMeters()
		{
			DataSet ds = new DataSet();
			ds = SQLiteHelper.ExecuteDataSet("SELECT MeterID,MeterPID,MeterClass,MeterName,MeterUsing,MeterCanSharing,MeterSelfUse,MeterMulti,MeterMaxNumber,RateID,WyID FROM Meters");
			return ds;
		}
		
		//获取指定Meter
		public static Meters GetMeter(int i_MeterID)
		{
			ISession session = NHibernateHelper.OpenSession();
			Meters tClass = new Meters();
			try
			{
				tClass = session.Get<Meters>(i_MeterID);
			}
			catch(Exception e)
			{
				Debug.Assert(false,e.Message);
			}
			session.Close();
			return tClass;
		}
		
		//删除
		public static void DelMeter(int  i_MeterID)
		{
			//ISessionFactory sessionFactory = new Configuration().Configure().BuildSessionFactory();
			ISession session = NHibernateHelper.OpenSession();
			ITransaction tx = session.BeginTransaction();
			Meters toDelete = session.Get<Meters>(i_MeterID);
				
			try
			{
				if(!CanDelMeter(i_MeterID))
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
		
		
		//指定的计量表能删除？
		private static bool CanDelMeter(int i_MeterID)
		{
			ISession session = NHibernateHelper.sessionFactory.OpenSession();
			int i_rtn = 0;
			//查询，Meters中是否存在
			i_rtn = Convert.ToInt32(SQLiteHelper.ExecuteScalar("SELECT Count(*) FROM Meters WHERE MeterPID = @MeterID",i_MeterID));
			if(i_rtn > 0)
			{
				MessageBox.Show("要删除的计量表中有下级表，不能删除！","提示信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
				session.Close();
				return false;
			}
			
			session.Close();
			return true;
		}
		
		//获取所有未对应收费项目的表
		public static DataSet GetNoRateIDMeters()
		{
			DataSet ds = new DataSet();
			ds = SQLiteHelper.ExecuteDataSet("select MeterID,MeterName From Meters Where RateID is NULL");
			return ds;
		}
		
		//获取所有未对应物业的表
		public static DataSet GetNoWyIDMeters()
		{
			DataSet ds = new DataSet();
			ds = SQLiteHelper.ExecuteDataSet("select MeterID,MeterName From Meters Where WyID is NULL");
			return ds;
		}
		
		
		
	}
}
