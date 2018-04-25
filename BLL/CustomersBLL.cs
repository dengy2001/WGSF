/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-08-29
 * 时间: 16:56
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
	/// Description of CustomersBLL.
	/// </summary>
	public class CustomersBLL
	{
		public CustomersBLL()
		{
		}
		
		//添加新的
		public static void AddCustomer(Customers tNew)
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
		public static void UpdateCustomer(Customers tNew)
		{
			ISession session = NHibernateHelper.OpenSession();
			try
			{				
				ITransaction tx = session.BeginTransaction();
				Customers tModify = session.Get<Customers>(tNew.CustomerID);
				tModify.CustomerName = tNew.CustomerName;
				tModify.CustomerLinkMan = tNew.CustomerLinkMan;
				tModify.CustomerLinkDetail = tNew.CustomerLinkDetail;

				tx.Commit();
			}
			catch(Exception e)
			{
				Debug.Assert(false,e.Message);
			}
			session.Close();
		}
		
		//获取Customers
		public static DataSet GetAllCustomers()
		{
			DataSet ds = new DataSet();
			ds = SQLiteHelper.ExecuteDataSet("SELECT CustomerID,CustomerName,CustomerLinkMan,CustomerLinkDetail FROM Customers ");
			return ds;
		}
		
		//获取指定Customer
		public static Customers GetCustomer(int i_CustomerID)
		{
			ISession session = NHibernateHelper.OpenSession();
			Customers tClass = new Customers();
			try
			{
				tClass = session.Get<Customers>(i_CustomerID);
			}
			catch(Exception e)
			{
				Debug.Assert(false,e.Message);
			}
			session.Close();
			return tClass;
		}
		
		//删除
		public static void DelCustomer(int  i_CustomerID)
		{
			//ISessionFactory sessionFactory = new Configuration().Configure().BuildSessionFactory();
			ISession session = NHibernateHelper.OpenSession();
			ITransaction tx = session.BeginTransaction();
			Customers toDelete = session.Get<Customers>(i_CustomerID);
				
			try
			{
				if(!CanDelCustomer(i_CustomerID))
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
		
		
		//指定的缴费对象能删除？
		private static bool CanDelCustomer(int i_CustomerID)
		{
			ISession session = NHibernateHelper.sessionFactory.OpenSession();
			int i_rtn = 0;
			//查询，WyInfos中是否存在
			i_rtn = Convert.ToInt32(SQLiteHelper.ExecuteScalar("SELECT Count(*) FROM WyInfos WHERE CustomerID = @CustomerID",i_CustomerID));
			if(i_rtn > 0)
			{
				MessageBox.Show("要删除的缴费对象在物业信息表中有使用，不能删除！","提示信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
				session.Close();
				return false;
			}
			
			session.Close();
			return true;
		}
		
		
		//将DataTable数据填充到数据库表中
		public static void FillCustomers(DataTable tDt)
		{
			ISession session = NHibernateHelper.sessionFactory.OpenSession();
			ITransaction tx = session.BeginTransaction();
			try
			{
				DataRow[] drs;
		        drs = tDt.Select("1=1");
	            for (int i = 0; i < drs.Length; i++)
	            {
	            	Customers tNew = new Customers();
	            	
	            	tNew.CustomerName = drs[i]["CustomerName"].ToString();
	            	tNew.CustomerLinkMan = drs[i]["CustomerLinkMan"].ToString();
	            	tNew.CustomerLinkDetail = drs[i]["CustomerLinkDetail"].ToString();

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
		
		
		
		
		
		
		
	}
}
