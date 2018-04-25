/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-09-02
 * 时间: 14:50
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Data;
using NHibernate;
using NHibernate.Cfg;
using DomainModel;
using System.Data.SQLite;
using DAL;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics;

namespace BLL
{
	/// <summary>
	/// Description of ChargeBLL.
	/// </summary>
	public class ChargeBLL
	{
		public ChargeBLL()
		{
		}
		
		//添加新的
		public static void AddCharge(Charge tNew)
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
		
		//添加新的
		public static int AddCharge1(Charge tNew)
		{
			ISession session = NHibernateHelper.sessionFactory.OpenSession();
			ITransaction tx = session.BeginTransaction();
			try
			{
				session.Save(tNew);
				tx.Commit();
				session.Close();
				return tNew.CID;
			}
			catch(Exception e)
			{
				Debug.Assert(false,e.Message);
				tx.Rollback();
				session.Close();
				return -1;
			}
		}
		
		//添加新的
		public static int AddChargeF1(ChargeF tNew)
		{
			ISession session = NHibernateHelper.sessionFactory.OpenSession();
			ITransaction tx = session.BeginTransaction();
			try
			{
				session.Save(tNew);
				tx.Commit();
				session.Close();
				return tNew.CFID;
			}
			catch(Exception e)
			{
				Debug.Assert(false,e.Message);
				tx.Rollback();
				session.Close();
				return -1;
			}
		}
		
		//添加新的
		public static void AddChargeF(ChargeF tNew)
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
		
		//添加新的
		public static void AddChargeDetail(ChargeDetail tNew)
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
		public static void UpdateCharge(Charge tNew)
		{
			ISession session = NHibernateHelper.OpenSession();
			try
			{
				ITransaction tx = session.BeginTransaction();
				Charge tModify = session.Get<Charge>(tNew.CID);
				tModify.PeriodNo = tNew.PeriodNo;
				tModify.ChargeTotal = tNew.ChargeTotal;
				tModify.Abstract = tNew.Abstract;
				tModify.CustomerID = tNew.CustomerID;
				tModify.CustomerName = tNew.CustomerName;

				tx.Commit();
			}
			catch(Exception e)
			{
				Debug.Assert(false,e.Message);
			}
			session.Close();
		}
		
		//修改
		public static void UpdateChargeF(ChargeF tNew)
		{
			ISession session = NHibernateHelper.OpenSession();
			try
			{
				ITransaction tx = session.BeginTransaction();
				ChargeF tModify = session.Get<ChargeF>(tNew.CFID);
				tModify.PeriodNo = tNew.PeriodNo;
				tModify.ChargeTotal = tNew.ChargeTotal;
				tModify.Abstract = tNew.Abstract;
				tModify.CustomerID = tNew.CustomerID;
				tModify.CustomerName = tNew.CustomerName;
				tModify.SFPerson = tNew.SFPerson;

				tx.Commit();
			}
			catch(Exception e)
			{
				Debug.Assert(false,e.Message);
			}
			session.Close();
		}
		
		//修改
		public static void UpdateChargeDetail(ChargeDetail tNew)
		{
			ISession session = NHibernateHelper.OpenSession();
			try
			{
				ITransaction tx = session.BeginTransaction();
				ChargeDetail tModify = session.Get<ChargeDetail>(tNew.CDNo);
				tModify.Abstract = tNew.Abstract;
				tModify.PeriodNo = tNew.PeriodNo;
				tModify.WyID = tNew.WyID;
				tModify.WyName = tNew.WyName;
				tModify.ChargeName = tNew.ChargeName;
				tModify.ChargeStatus = tNew.ChargeStatus;
				tModify.ChargeUnit = tNew.ChargeUnit;
				tModify.ChargePrice = tNew.ChargePrice;
				tModify.ChargeYS = tNew.ChargeYS;
				tModify.ChargeSS = tNew.ChargeSS;
				tModify.ChargeDate = tNew.ChargeDate;
				tModify.ChargeFDate = tNew.ChargeFDate;
				tModify.CID = tNew.CID;
				tModify.CFID = tNew.CFID;


				tx.Commit();
			}
			catch(Exception e)
			{
				Debug.Assert(false,e.Message);
			}
			session.Close();
		}
		
		
		//删除
		public static void DelChargeDetail(int  i_CDNo)
		{
			//ISessionFactory sessionFactory = new Configuration().Configure().BuildSessionFactory();
			ISession session = NHibernateHelper.OpenSession();
			ITransaction tx = session.BeginTransaction();
			ChargeDetail toDelete = session.Get<ChargeDetail>(i_CDNo);
			
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
		
		
		//获取MeterReading，计费状态：已计费、已收费、暂未收、免收
		public static DataSet GetCanSF(int i_CustomerID)
		{
			DataSet ds = new DataSet();
			ds = SQLiteHelper.ExecuteDataSet("SELECT CDNo,Abstract,PeriodNo,WyID,WyName,ChargeName,ChargeStatus,ChargeUnit,ChargeNum,ChargePrice,ChargeYS,ChargeSS,ChargeDate,ChargeFDate,CID,CFID,RID,WyRateID FROM ChargeDetail  WHERE (ChargeStatus='已计费' OR ChargeStatus='增加收费'  ) AND WyID IN(SELECT WyID FROM WyInfos WHERE CustomerID = @CustomerID ) ORDER BY PeriodNo,WyID,ChargeName",i_CustomerID);
			return ds;
		}
		
		//获取MeterReading，计费状态：已计费、已收费、暂未收、免收，周期与指定周期相同
		public static DataSet GetCanSF(int i_CustomerID,string s_PeriodNo)
		{
			DataSet ds = new DataSet();
			ds = SQLiteHelper.ExecuteDataSet("SELECT CDNo,Abstract,PeriodNo,WyID,WyName,ChargeName,ChargeStatus,ChargeUnit,ChargeNum,ChargePrice,ChargeYS,ChargeSS,ChargeDate,ChargeFDate,CID,CFID,RID,WyRateID FROM ChargeDetail  WHERE (ChargeStatus='已计费' OR ChargeStatus='增加收费'  ) AND PeriodNo = @sPeriodNo AND WyID IN(SELECT WyID FROM WyInfos WHERE CustomerID = @CustomerID ) ORDER BY PeriodNo,WyID,ChargeName",s_PeriodNo,i_CustomerID);
			return ds;
		}
		
		public static DataSet GetCanSFOK(int i_CustomerID)
		{
			DataSet ds = new DataSet();
			ds = SQLiteHelper.ExecuteDataSet("SELECT CDNo,Abstract,PeriodNo,WyID,WyName,ChargeName,ChargeStatus,ChargeUnit,ChargeNum,ChargePrice,ChargeYS,ChargeSS,ChargeDate,ChargeFDate,CID,CFID,RID,WyRateID FROM ChargeDetail  WHERE (ChargeStatus='已计费'  OR ChargeStatus='增加收费' OR ChargeStatus='免收') AND WyID IN(SELECT WyID FROM WyInfos WHERE CustomerID = @CustomerID ) ORDER BY PeriodNo,WyID,ChargeName",i_CustomerID);
			return ds;
		}
		
		public static DataSet GetCanSFOK(int i_CustomerID,string s_PeriodNo)
		{
			DataSet ds = new DataSet();
			ds = SQLiteHelper.ExecuteDataSet("SELECT CDNo,Abstract,PeriodNo,WyID,WyName,ChargeName,ChargeStatus,ChargeUnit,ChargeNum,ChargePrice,ChargeYS,ChargeSS,ChargeDate,ChargeFDate,CID,CFID,RID,WyRateID FROM ChargeDetail  WHERE PeriodNo=@sPeriodNo AND (ChargeStatus='已计费'  OR ChargeStatus='增加收费' OR ChargeStatus='免收') AND WyID IN(SELECT WyID FROM WyInfos WHERE CustomerID = @CustomerID ) ORDER BY PeriodNo,WyID,ChargeName",s_PeriodNo,i_CustomerID);
			return ds;
		}
		
		public static DataSet GetCanSFAll(int i_CustomerID)
		{
			DataSet ds = new DataSet();
			ds = SQLiteHelper.ExecuteDataSet("SELECT CDNo,Abstract,PeriodNo,WyID,WyName,ChargeName,ChargeStatus,ChargeUnit,ChargeNum,ChargePrice,ChargeYS,ChargeSS,ChargeDate,ChargeFDate,CID,CFID,RID,WyRateID FROM ChargeDetail  WHERE (ChargeStatus='已计费'  OR ChargeStatus='增加收费' OR ChargeStatus='暂未收'  OR ChargeStatus='免收') AND WyID IN(SELECT WyID FROM WyInfos WHERE CustomerID = @CustomerID ) ORDER BY PeriodNo,WyID,ChargeName",i_CustomerID);
			return ds;
		}
		
		public static DataSet GetCanSFAll(int i_CustomerID,string s_PeriodNo)
		{
			DataSet ds = new DataSet();
			ds = SQLiteHelper.ExecuteDataSet("SELECT CDNo,Abstract,PeriodNo,WyID,WyName,ChargeName,ChargeStatus,ChargeUnit,ChargeNum,ChargePrice,ChargeYS,ChargeSS,ChargeDate,ChargeFDate,CID,CFID,RID,WyRateID FROM ChargeDetail  WHERE PeriodNo = @sPeriodNo AND (ChargeStatus='已计费'  OR ChargeStatus='增加收费' OR ChargeStatus='暂未收'  OR ChargeStatus='免收') AND WyID IN(SELECT WyID FROM WyInfos WHERE CustomerID = @CustomerID ) ORDER BY PeriodNo,WyID,ChargeName",s_PeriodNo,i_CustomerID);
			return ds;
		}
		
		//获取指定收费单的收费项
		public static DataSet GetSFChargeDetail(int i_CFID)
		{
			DataSet ds = new DataSet();
			ds = SQLiteHelper.ExecuteDataSet("SELECT CDNo,Abstract,PeriodNo,WyID,WyName,ChargeName,ChargeStatus,ChargeUnit,ChargeNum,ChargePrice,ChargeYS,ChargeSS,ChargeDate,ChargeFDate,CID,CFID,RID,WyRateID FROM ChargeDetail  WHERE CFID = @CFID",i_CFID);
			return ds;
		}
		
		//获取指定收费单的收费项
		public static DataSet GetSFChargeDetail(string S_CFIDs)
		{
			DataSet ds = new DataSet();
			string s_SQL = "SELECT CDNo,Abstract,PeriodNo,WyID,WyName,ChargeName,ChargeStatus,ChargeUnit,ChargeNum,ChargePrice,ChargeYS,ChargeSS,ChargeDate,ChargeFDate,CID,CFID,RID,WyRateID FROM ChargeDetail  WHERE CFID IN " + S_CFIDs;
			ds = SQLiteHelper.ExecuteDataSet(s_SQL);
			return ds;
		}
		
		//获取除已收费外的全部
		public static DataSet GetCanSFAll()
		{
			DataSet ds = new DataSet();
			ds = SQLiteHelper.ExecuteDataSet("SELECT CDNo,Abstract,PeriodNo,WyID,WyName,ChargeName,ChargeStatus,ChargeUnit,ChargeNum,ChargePrice,ChargeYS,ChargeSS,ChargeDate,ChargeFDate,CID,CFID,RID,WyRateID FROM ChargeDetail  WHERE ChargeStatus<>'已收费' ");
			return ds;
		}
		//获取除已收费外的全部
		public static DataSet GetCanSFAll(string s_PeriodNo)
		{
			DataSet ds = new DataSet();
			ds = SQLiteHelper.ExecuteDataSet("SELECT CDNo,Abstract,PeriodNo,WyID,WyName,ChargeName,ChargeStatus,ChargeUnit,ChargeNum,ChargePrice,ChargeYS,ChargeSS,ChargeDate,ChargeFDate,CID,CFID,RID,WyRateID FROM ChargeDetail  WHERE ChargeStatus<>'已收费' AND PeriodNo=@sPeriodNo ",s_PeriodNo);
			return ds;
		}
		
		//获取计费状态为【已计费】【暂未收】【免收】的所有缴费对象
		public static DataSet GetCustomersCanSF()
		{
			DataSet ds = new DataSet();
			ds = SQLiteHelper.ExecuteDataSet("SELECT CustomerID,CustomerName FROM Customers WHERE CustomerID IN ( select A.CustomerID from Wyinfos A,ChargeDetail B WHERE A.WyID = B.WyID AND  (B.ChargeStatus='已计费' OR B.ChargeStatus='暂未收' OR B.ChargeStatus='增加收费' OR B.ChargeStatus='免收') )");
			return ds;
		}
		
		//获取计费状态为【已计费】【免收】【增加收费】的所有缴费对象
		public static DataSet GetCustomersOKSF()
		{
			DataSet ds = new DataSet();
			ds = SQLiteHelper.ExecuteDataSet("SELECT CustomerID,CustomerName FROM Customers WHERE CustomerID IN ( select A.CustomerID from Wyinfos A,ChargeDetail B WHERE A.WyID = B.WyID AND  (B.ChargeStatus='已计费' OR B.ChargeStatus='免收' OR B.ChargeStatus='增加收费' ) )");
			return ds;
		}
		
		//获取Charge表中的全部周期
		public static DataSet GetAllPeriodNoFromCharge()
		{
			DataSet ds = new DataSet();
			ds = SQLiteHelper.ExecuteDataSet("SELECT Distinct(PeriodNo) FROM Charge Order by PeriodNo desc");
			return ds;
		}
		
		//获取可以计费的所有缴费对象
		public static DataSet GetCustomersCanJF()
		{
			DataSet ds = new DataSet();
			ds = SQLiteHelper.ExecuteDataSet("SELECT CustomerID,CustomerName FROM Customers WHERE CustomerID IN ( SELECT CustomerID FROM WyInfos ) ");
			return ds;
		}
		
		//获取Charge中的“已计费”状态的计费单
		public static DataSet GetJFDs()
		{
			DataSet ds = new DataSet();
			ds = SQLiteHelper.ExecuteDataSet("SELECT CID,PeriodNo,ChargeTotal,Abstract,ChargeStatus,CustomerID,CustomerName FROM Charge WHERE ChargeStatus = '已计费'  ");
			return ds;
		}
		
		//获取Charge中的“已计费”状态的计费单
		public static DataSet GetJFDs(string s_PeriodNo)
		{
			DataSet ds = new DataSet();
			ds = SQLiteHelper.ExecuteDataSet("SELECT CID,PeriodNo,ChargeTotal,Abstract,ChargeStatus,CustomerID,CustomerName FROM Charge WHERE ChargeStatus = '已计费' AND PeriodNo=@sPeriodNo ",s_PeriodNo);
			return ds;
		}
		
		//获取ChargeF中的“已收费”状态的收费单
		public static DataSet GetSFDs()
		{
			DataSet ds = new DataSet();
			ds = SQLiteHelper.ExecuteDataSet("SELECT CFID,PeriodNo,ChargeTotal,Abstract,ChargeStatus,CustomerID,CustomerName,SFPerson FROM ChargeF WHERE ChargeStatus = '已收费'  ");
			return ds;
		}
		
		//获取ChargeF中指定CFID的收费单
		public static DataSet GetSFDs(int i_CFID)
		{
			DataSet ds = new DataSet();
			ds = SQLiteHelper.ExecuteDataSet("SELECT CFID,PeriodNo,ChargeTotal,Abstract,ChargeStatus,CustomerID,CustomerName,SFPerson FROM ChargeF WHERE CFID = @CFID ",i_CFID);
			return ds;
		}
		
		//获取ChargeF中指定CFID的收费单
		public static DataSet GetSFDs(string s_CFIDs)
		{
			DataSet ds = new DataSet();
			string s_SQL = "SELECT CFID,PeriodNo,ChargeTotal,Abstract,ChargeStatus,CustomerID,CustomerName,SFPerson FROM ChargeF WHERE CFID IN " + s_CFIDs;
			ds = SQLiteHelper.ExecuteDataSet(s_SQL);
			return ds;
		}
		
		
		//计费
		public static void CalAllJF(string s_PeriodNo,Label lStatus)
		{
			//1.先查是否能计费，只要有1笔记录有【已收费】或【免收】
			int i_rtn = Convert.ToInt32(SQLiteHelper.ExecuteScalar("SELECT Count(*) FROM ChargeDetail WHERE (ChargeStatus = '已收费' OR ChargeStatus = '免收') AND PeriodNo = @PeriodNo",s_PeriodNo));
			if(i_rtn > 0)
			{
				MessageBox.Show("当前计费周期已经有收费完成，不能计费！","提示信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}
			
			//2.将表计量的数据填充到ChargeDetail
			lStatus.Text = "【计量表计费生成...】";
			ISession session = NHibernateHelper.OpenSession();
			ITransaction tx = session.BeginTransaction();
			DataSet ds = new DataSet();
			ds = SQLiteHelper.ExecuteDataSet("SELECT RID FROM MeterReading WHERE RStatus='计量计算' AND PeriodNo = @PeriodNo ORDER BY MeterClass",s_PeriodNo);
			DataRow[] drs;
			drs = ds.Tables[0].Select("1=1");
			try
			{
				for (int i = 0; i < drs.Length; i++)
				{
					int i_RID = Convert.ToInt32(drs[i]["RID"].ToString());
					//检查ChargeDetail中是否有此表计量数据
					MeterReading tMeterReading =session.Get<MeterReading>(i_RID);
					lStatus.Text = "【计量表计费生成】:"+tMeterReading.MeterName;
					Rates tRate = new Rates();
					if(tMeterReading.RateID != null)
					{
						tRate = session.Get<Rates>(tMeterReading.RateID);
					}
					else
					{
						tRate = new Rates();
						tRate.RateUnit = "";
						tRate.RateValue = 0.0m;
					}
					IQuery query = session.CreateQuery("FROM ChargeDetail WHERE RID = ? AND PeriodNo = ?");
					query.SetParameter(0,tMeterReading.RID);
					query.SetParameter(1, s_PeriodNo);

					IList<ChargeDetail> eList = query.List<ChargeDetail>();
					if(eList.Count == 0)
					{
						int i_Share = 0;
						//没有表计量记录
						ChargeDetail tNew = new ChargeDetail();
						tNew.PeriodNo = s_PeriodNo;
						tNew.WyID = tMeterReading.WyID;
						tNew.WyName = tMeterReading.WyName;
						tNew.ChargeName = "表计量费用";
						tNew.ChargeStatus = "已计费";
						tNew.ChargeUnit = tRate.RateUnit;
						if(tMeterReading.MeterCanSharing == 1)
						{
							//分摊量要计算
							tNew.ChargeNum = Convert.ToDecimal(tMeterReading.TotalNum);
							i_Share = Convert.ToInt32(tMeterReading.ShareNum);
						}
						else
						{
							//分摊量不计算
							tNew.ChargeNum = Convert.ToDecimal(tMeterReading.TotalNum - tMeterReading.ShareNum);
							i_Share = 0;
						}
						tNew.ChargePrice = Convert.ToDecimal(tMeterReading.RateValue);
						tNew.ChargeYS = tNew.ChargeNum * tNew.ChargePrice;
						tNew.ChargeSS = 0.0m;
						tNew.ChargeDate = DateTime.Now;
						tNew.RID = tMeterReading.RID;
						tNew.Abstract = "表【" + tMeterReading.MeterName +"】计量:自 "
							+tMeterReading.StartReading.ToString()
							+ " 至 " + tMeterReading.EndReading.ToString()
							+ "止，调整【" + tMeterReading.AdjustNum.ToString()
							+ "】，分摊【"+ i_Share.ToString() + "】";
						
						
						session.Save(tNew);
					}
					else
					{
						//有表计量记录
						int i_Share = 0;
						ChargeDetail tOld = session.Get<ChargeDetail>(eList[0].CDNo);
						tOld.PeriodNo = s_PeriodNo;
						tOld.WyID = tMeterReading.WyID;
						tOld.WyName = tMeterReading.WyName;
						tOld.ChargeName = "表计量费用";
						tOld.ChargeStatus = "已计费";
						tOld.ChargeUnit = tRate.RateUnit;
						if(tMeterReading.MeterCanSharing == 1)
						{
							//分摊量要计算
							tOld.ChargeNum = Convert.ToDecimal(tMeterReading.TotalNum);
							i_Share = Convert.ToInt32(tMeterReading.ShareNum);
						}
						else
						{
							//分摊量不计算
							tOld.ChargeNum = Convert.ToDecimal(tMeterReading.TotalNum - tMeterReading.ShareNum);
							i_Share = 0;
						}
						tOld.ChargePrice = Convert.ToDecimal(tMeterReading.RateValue);
						tOld.ChargeYS = tOld.ChargeNum * tOld.ChargePrice;
						tOld.ChargeSS = 0.0m;
						tOld.ChargeDate = DateTime.Now;
						tOld.RID = tMeterReading.RID;
						tOld.Abstract = "表【" + tMeterReading.MeterName +"】计量:自 "
							+tMeterReading.StartReading.ToString()
							+ " 至 " + tMeterReading.EndReading.ToString()
							+ "止，调整【" + tMeterReading.AdjustNum.ToString()
							+ "】，分摊【"+ i_Share.ToString() + "】";
						session.Update(tOld);
					}
					
					Application.DoEvents();
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

			
			
			
			//3.循环所有物业，将除计量外的计费全部添加
			lStatus.Text = "【物业计费生成...】";
			session = NHibernateHelper.OpenSession();
			tx = session.BeginTransaction();
			ds = new DataSet();
			ds = SQLiteHelper.ExecuteDataSet("SELECT WyRateID,WyID,RateID FROM WyRates");
			drs = ds.Tables[0].Select("1=1");
			try
			{
				for (int i = 0; i < drs.Length; i++)
				{
					int i_WyRateID = Convert.ToInt32(drs[i]["WyRateID"].ToString());
					
					WyRates tWyRate  = session.Get<WyRates>(i_WyRateID);
					//检查ChargeDetail中是否有此收费的数据
					WyInfos tWyInfo = session.Get<WyInfos>(tWyRate.WyID);
					lStatus.Text = "【物业计费生成】:"+tWyInfo.WyName;
					Rates tRate = session.Get<Rates>(tWyRate.RateID);
					
					IQuery query = session.CreateQuery("FROM ChargeDetail WHERE WyRateID = ? AND PeriodNo = ?");
					query.SetParameter(0,tWyRate.WyRateID);
					query.SetParameter(1, s_PeriodNo);

					IList<ChargeDetail> eList = query.List<ChargeDetail>();
					if(eList.Count == 0)
					{
						int i_Share = 0;
						//没有此收费记录
						ChargeDetail tNew = new ChargeDetail();
						tNew.PeriodNo = s_PeriodNo;
						tNew.WyID = tWyInfo.WyID;
						tNew.WyName = tWyInfo.WyName;
						tNew.ChargeName = tRate.RateName;
						tNew.ChargeStatus = "已计费";
						tNew.ChargeUnit = tRate.RateUnit;
						
						//收费费率的单位 建筑面积，套内面积，公摊面积，人口数，固定金额
						switch(tRate.RateUnit)
						{
							case "建筑面积":
								tNew.ChargeNum = Convert.ToDecimal(tWyInfo.JZArea) ;
								tNew.ChargePrice = Convert.ToDecimal(tRate.RateValue);
								break;
							case "套内面积":
								tNew.ChargeNum = Convert.ToDecimal(tWyInfo.TNArea) ;
								tNew.ChargePrice = Convert.ToDecimal(tRate.RateValue);
								break;
							case "公摊面积":
								tNew.ChargeNum = Convert.ToDecimal(tWyInfo.GTArea);
								tNew.ChargePrice =  Convert.ToDecimal(tRate.RateValue);								
								break;
							default:
								tNew.ChargeNum = tRate.RateValue;
								tNew.ChargePrice = 1.0m;
								break;
						}
						
						tNew.ChargeYS = tNew.ChargeNum * tNew.ChargePrice;
						tNew.ChargeSS = 0.0m;
						tNew.ChargeDate = DateTime.Now;
						tNew.Abstract = "物业【" + tWyInfo.WyName +"】的【 "
							+tRate.RateName
							+ " 】收费项 ";
						tNew.WyRateID = tWyRate.WyRateID;
						
						session.Save(tNew);
					}
					else
					{
						//有此收费记录
						ChargeDetail tOld = session.Get<ChargeDetail>(eList[0].CDNo);
						tOld.PeriodNo = s_PeriodNo;
						tOld.WyID = tWyInfo.WyID;
						tOld.WyName = tWyInfo.WyName;
						tOld.ChargeName = tRate.RateName;
						tOld.ChargeStatus = "已计费";
						tOld.ChargeUnit = tRate.RateUnit;
						
						//收费费率的单位 建筑面积，套内面积，公摊面积，人口数，固定金额
						switch(tRate.RateUnit)
						{
							case "建筑面积":
								tOld.ChargeNum = Convert.ToDecimal(tWyInfo.JZArea) ;
								tOld.ChargePrice = Convert.ToDecimal(tRate.RateValue);
								break;
							case "套内面积":
								tOld.ChargeNum = Convert.ToDecimal(tWyInfo.TNArea) ;
								tOld.ChargePrice = Convert.ToDecimal(tRate.RateValue);
								break;
							case "公摊面积":
								tOld.ChargeNum = Convert.ToDecimal(tWyInfo.GTArea);
								tOld.ChargePrice =  Convert.ToDecimal(tRate.RateValue);								
								break;
							default:
								tOld.ChargeNum = tRate.RateValue;
								tOld.ChargePrice = 1.0m;
								break;
						}
						
						tOld.ChargeYS = tOld.ChargeNum * tOld.ChargePrice;
						tOld.ChargeSS = 0.0m;
						tOld.ChargeDate = DateTime.Now;
						tOld.Abstract = "物业【" + tWyInfo.WyName +"】的【 "
							+tRate.RateName
							+ " 】收费项 ";
						tOld.WyRateID = tWyRate.WyRateID;
						
						session.Update(tOld);
					}
					Application.DoEvents();
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
			
			
			//4.
			
			lStatus.Text = "【计费生成完成！】";
			return;
			
		}
		
		//单独计费
		public static void CalSingleJF(string s_PeriodNo,string s_CustomerID,Label lStatus)
		{
			//1.先查是否能计费，只要有1笔记录有【已收费】或【免收】
			Object[] parms = new object[2];
			parms[0] = new object();
			parms[0] = Convert.ToInt32(s_CustomerID);

			parms[1] = new object();
			parms[1] = s_PeriodNo;

			
			int i_rtn = Convert.ToInt32(SQLiteHelper.ExecuteScalar("SELECT Count(*) FROM ChargeDetail WHERE WyID IN (SELECT WyID FROM WyInfos WHERE CustomerID = @CustomerID ) AND (ChargeStatus = '已收费' OR ChargeStatus = '免收') AND PeriodNo = @PeriodNo ",parms));
			if(i_rtn > 0)
			{
				MessageBox.Show("当前计费周期已经有收费完成，不能计费！","提示信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}
			
			//2.将表计量的数据填充到ChargeDetail
			lStatus.Text = "【计量表计费生成...】";
			ISession session = NHibernateHelper.OpenSession();
			ITransaction tx = session.BeginTransaction();
			DataSet ds = new DataSet();
			ds = SQLiteHelper.ExecuteDataSet("SELECT RID FROM MeterReading WHERE RStatus='计量计算' AND WyID IN (SELECT WyID FROM WyInfos WHERE CustomerID = @CustomerID )  AND PeriodNo = @PeriodNo ORDER BY MeterClass",parms);
			DataRow[] drs;
			drs = ds.Tables[0].Select("1=1");
			try
			{
				for (int i = 0; i < drs.Length; i++)
				{
					int i_RID = Convert.ToInt32(drs[i]["RID"].ToString());
					//检查ChargeDetail中是否有此表计量数据
					MeterReading tMeterReading =session.Get<MeterReading>(i_RID);
					lStatus.Text = "【计量表计费生成】:"+tMeterReading.MeterName;
					Rates tRate = new Rates();
					if(tMeterReading.RateID != null)
					{
						tRate = session.Get<Rates>(tMeterReading.RateID);
					}
					else
					{
						tRate = new Rates();
						tRate.RateUnit = "";
						tRate.RateValue = 0.0m;
					}
					IQuery query = session.CreateQuery("FROM ChargeDetail WHERE RID = ? AND PeriodNo = ?");
					query.SetParameter(0,tMeterReading.RID);
					query.SetParameter(1, s_PeriodNo);

					IList<ChargeDetail> eList = query.List<ChargeDetail>();
					if(eList.Count == 0)
					{
						int i_Share = 0;
						//没有表计量记录
						ChargeDetail tNew = new ChargeDetail();
						tNew.PeriodNo = s_PeriodNo;
						tNew.WyID = tMeterReading.WyID;
						tNew.WyName = tMeterReading.WyName;
						tNew.ChargeName = "表计量费用";
						tNew.ChargeStatus = "已计费";
						tNew.ChargeUnit = tRate.RateUnit;
						if(tMeterReading.MeterCanSharing == 1)
						{
							//分摊量要计算
							tNew.ChargeNum = Convert.ToDecimal(tMeterReading.TotalNum);
							i_Share = Convert.ToInt32(tMeterReading.ShareNum);
						}
						else
						{
							//分摊量不计算
							tNew.ChargeNum = Convert.ToDecimal(tMeterReading.TotalNum - tMeterReading.ShareNum);
							i_Share = 0;
						}
						tNew.ChargePrice = Convert.ToDecimal(tMeterReading.RateValue);
						tNew.ChargeYS = tNew.ChargeNum * tNew.ChargePrice;
						tNew.ChargeSS = 0.0m;
						tNew.ChargeDate = DateTime.Now;
						tNew.RID = tMeterReading.RID;
						tNew.Abstract = "表【" + tMeterReading.MeterName +"】计量:自 "
							+tMeterReading.StartReading.ToString()
							+ " 至 " + tMeterReading.EndReading.ToString()
							+ "止，调整【" + tMeterReading.AdjustNum.ToString()
							+ "】，分摊【"+ i_Share.ToString() + "】";
						
						
						session.Save(tNew);
					}
					else
					{
						//有表计量记录
						int i_Share = 0;
						ChargeDetail tOld = session.Get<ChargeDetail>(eList[0].CDNo);
						tOld.PeriodNo = s_PeriodNo;
						tOld.WyID = tMeterReading.WyID;
						tOld.WyName = tMeterReading.WyName;
						tOld.ChargeName = "表计量费用";
						tOld.ChargeStatus = "已计费";
						tOld.ChargeUnit = tRate.RateUnit;
						if(tMeterReading.MeterCanSharing == 1)
						{
							//分摊量要计算
							tOld.ChargeNum = Convert.ToDecimal(tMeterReading.TotalNum);
							i_Share = Convert.ToInt32(tMeterReading.ShareNum);
						}
						else
						{
							//分摊量不计算
							tOld.ChargeNum = Convert.ToDecimal(tMeterReading.TotalNum - tMeterReading.ShareNum);
							i_Share = 0;
						}
						tOld.ChargePrice = Convert.ToDecimal(tMeterReading.RateValue);
						tOld.ChargeYS = tOld.ChargeNum * tOld.ChargePrice;
						tOld.ChargeSS = 0.0m;
						tOld.ChargeDate = DateTime.Now;
						tOld.RID = tMeterReading.RID;
						tOld.Abstract = "表【" + tMeterReading.MeterName +"】计量:自 "
							+tMeterReading.StartReading.ToString()
							+ " 至 " + tMeterReading.EndReading.ToString()
							+ "止，调整【" + tMeterReading.AdjustNum.ToString()
							+ "】，分摊【"+ i_Share.ToString() + "】";
						session.Update(tOld);
					}
					
					Application.DoEvents();
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
			
			//3.循环所有物业，将除计量外的计费全部添加
			lStatus.Text = "【物业计费生成...】";
			session = NHibernateHelper.OpenSession();
			tx = session.BeginTransaction();
			ds = new DataSet();
			ds = SQLiteHelper.ExecuteDataSet("SELECT WyRateID,WyID,RateID FROM WyRates WHERE WyID IN (SELECT WyID FROM WyInfos WHERE CustomerID = @CustomerID)",s_CustomerID);
			drs = ds.Tables[0].Select("1=1");
			try
			{
				for (int i = 0; i < drs.Length; i++)
				{
					int i_WyRateID = Convert.ToInt32(drs[i]["WyRateID"].ToString());
					
					WyRates tWyRate  = session.Get<WyRates>(i_WyRateID);
					//检查ChargeDetail中是否有此收费的数据
					WyInfos tWyInfo = session.Get<WyInfos>(tWyRate.WyID);
					lStatus.Text = "【物业计费生成】:"+tWyInfo.WyName;
					Rates tRate = session.Get<Rates>(tWyRate.RateID);
					
					IQuery query = session.CreateQuery("FROM ChargeDetail WHERE WyRateID = ? AND PeriodNo = ?");
					query.SetParameter(0,tWyRate.WyRateID);
					query.SetParameter(1, s_PeriodNo);

					IList<ChargeDetail> eList = query.List<ChargeDetail>();
					if(eList.Count == 0)
					{
						int i_Share = 0;
						//没有此收费记录
						ChargeDetail tNew = new ChargeDetail();
						tNew.PeriodNo = s_PeriodNo;
						tNew.WyID = tWyInfo.WyID;
						tNew.WyName = tWyInfo.WyName;
						tNew.ChargeName = tRate.RateName;
						tNew.ChargeStatus = "已计费";
						tNew.ChargeUnit = tRate.RateUnit;
						
						//收费费率的单位 建筑面积，套内面积，公摊面积，人口数，固定金额
						switch(tRate.RateUnit)
						{
							case "建筑面积":
								tNew.ChargeNum = Convert.ToDecimal(tWyInfo.JZArea) ;
								tNew.ChargePrice = Convert.ToDecimal(tRate.RateValue);
								break;
							case "套内面积":
								tNew.ChargeNum = Convert.ToDecimal(tWyInfo.TNArea) ;
								tNew.ChargePrice = Convert.ToDecimal(tRate.RateValue);
								break;
							case "公摊面积":
								tNew.ChargeNum = Convert.ToDecimal(tWyInfo.GTArea);
								tNew.ChargePrice =  Convert.ToDecimal(tRate.RateValue);								
								break;
							default:
								tNew.ChargeNum = tRate.RateValue;
								tNew.ChargePrice = 1.0m;
								break;
						}
						
						tNew.ChargeYS = tNew.ChargeNum * tNew.ChargePrice;
						tNew.ChargeSS = 0.0m;
						tNew.ChargeDate = DateTime.Now;
						tNew.Abstract = "物业【" + tWyInfo.WyName +"】的【 "
							+tRate.RateName
							+ " 】收费项 ";
						tNew.WyRateID = tWyRate.WyRateID;
						
						session.Save(tNew);
					}
					else
					{
						//有此收费记录
						ChargeDetail tOld = session.Get<ChargeDetail>(eList[0].CDNo);
						tOld.PeriodNo = s_PeriodNo;
						tOld.WyID = tWyInfo.WyID;
						tOld.WyName = tWyInfo.WyName;
						tOld.ChargeName = tRate.RateName;
						tOld.ChargeStatus = "已计费";
						tOld.ChargeUnit = tRate.RateUnit;
						
						//收费费率的单位 建筑面积，套内面积，公摊面积，人口数，固定金额
						switch(tRate.RateUnit)
						{
							case "建筑面积":
								tOld.ChargeNum = Convert.ToDecimal(tWyInfo.JZArea) ;
								tOld.ChargePrice = Convert.ToDecimal(tRate.RateValue);
								break;
							case "套内面积":
								tOld.ChargeNum = Convert.ToDecimal(tWyInfo.TNArea) ;
								tOld.ChargePrice = Convert.ToDecimal(tRate.RateValue);
								break;
							case "公摊面积":
								tOld.ChargeNum = Convert.ToDecimal(tWyInfo.GTArea);
								tOld.ChargePrice =  Convert.ToDecimal(tRate.RateValue);								
								break;
							default:
								tOld.ChargeNum = tRate.RateValue;
								tOld.ChargePrice = 1.0m;
								break;
						}
						
						tOld.ChargeYS = tOld.ChargeNum * tOld.ChargePrice;
						tOld.ChargeSS = 0.0m;
						tOld.ChargeDate = DateTime.Now;
						tOld.Abstract = "物业【" + tWyInfo.WyName +"】的【 "
							+tRate.RateName
							+ " 】收费项 ";
						tOld.WyRateID = tWyRate.WyRateID;
						
						session.Update(tOld);
					}
					Application.DoEvents();
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
			
			
			//4.
			
			lStatus.Text = "【计费生成完成！】";
			return;
			
		}
		
		//获取指定ChargeDetail
		public static ChargeDetail GetChargeDetail(int i_CDNo)
		{
			ISession session = NHibernateHelper.OpenSession();
			ChargeDetail tClass = new ChargeDetail();
			try
			{
				tClass = session.Get<ChargeDetail>(i_CDNo);
			}
			catch(Exception e)
			{
				Debug.Assert(false,e.Message);
			}
			session.Close();
			return tClass;
		}
		
		//获取指定Charge
		public static Charge GetCharge(int i_CID)
		{
			ISession session = NHibernateHelper.OpenSession();
			Charge tClass = new Charge();
			try
			{
				tClass = session.Get<Charge>(i_CID);
			}
			catch(Exception e)
			{
				Debug.Assert(false,e.Message);
			}
			session.Close();
			return tClass;
		}

		//更新计费
		public static void UpDateJFData()
		{
			//1.检查是否需要更新计费
			DataSet tmpDs = GetCustomersCanSF();
			
			ISession session = NHibernateHelper.OpenSession();
			ITransaction tx = session.BeginTransaction();
			
			DataRow[] drs;
			drs = tmpDs.Tables[0].Select("1=1");		//所有能收费的对象
			try
			{
				for (int i = 0; i < drs.Length; i++)
				{
					int i_CustomerID = Convert.ToInt32(drs[i]["CustomerID"]);
					string s_CustomerName = drs[i]["CustomerName"].ToString();
					Charge tCharge = null;
					decimal d_Total = 0.0m;
					IQuery query = session.CreateQuery("FROM ChargeDetail WHERE ChargeStatus = '已计费'  AND WyID IN (SELECT WyID FROM WyInfos WHERE CustomerID = ?)");
					query.SetParameter(0,i_CustomerID);

					IList<ChargeDetail> eList = query.List<ChargeDetail>();
					for(int j=0;j<eList.Count;j++)
					{
						if(eList[j].CID == null)
						{
							//没有计费单
							if(j == 0)
							{
								tCharge = new Charge();
								tCharge.ChargeTotal = 0.0m;
								tCharge.PeriodNo = eList[j].PeriodNo;
								tCharge.ChargeStatus = "已计费";
								tCharge.CustomerID = i_CustomerID;
								tCharge.CustomerName = s_CustomerName;
								session.Save(tCharge);
							}
							ChargeDetail tCD = session.Get<ChargeDetail>(eList[j].CDNo);
							tCD.CID = tCharge.CID;
							session.Update(tCD);
						}
						else
						{
							//已经打印过计费了，不需要新计费单
							tCharge = session.Get<Charge>(eList[j].CID);
						}
						d_Total += eList[j].ChargeYS;
					}
					tCharge.ChargeTotal = d_Total;
					session.Update(tCharge);
					
				}
				tx.Commit();
			}
			catch(Exception e)
			{
				Debug.Assert(false,e.Message);
				tx.Rollback();
				session.Close();
			}
		}
		
		
		//更新收费，指定缴费对象，返回CFID
		public static int UpDateSFData(int i_CustomerID,string s_PeriodNo,string s_SFPerson)
		{
			int i_rtn = 0;
			//1.
			ISession session = NHibernateHelper.OpenSession();
			ITransaction tx = session.BeginTransaction();
			
			try
			{
				Customers tCustomer = session.Get<Customers>(i_CustomerID);
				ChargeF tChargeF = null;
				decimal d_Total = 0.0m;
				IQuery query = session.CreateQuery("FROM ChargeDetail WHERE  PeriodNo = ? AND ( ChargeStatus = '已计费' OR ChargeStatus = '免收' OR ChargeStatus = '增加收费' ) AND WyID IN (SELECT WyID FROM WyInfos WHERE CustomerID = ?)");
				query.SetParameter(0,s_PeriodNo);
				query.SetParameter(1,i_CustomerID);

				IList<ChargeDetail> eList = query.List<ChargeDetail>();
				for(int j=0;j<eList.Count;j++)
				{
					if(eList[j].CFID == null)
					{
						//没有收费单
						if(j == 0)
						{
							tChargeF = new ChargeF();
							tChargeF.ChargeTotal = 0.0m;
							tChargeF.PeriodNo = s_PeriodNo;
							tChargeF.ChargeStatus = "已收费";
							tChargeF.CustomerID = i_CustomerID;
							tChargeF.CustomerName = tCustomer.CustomerName;
							tChargeF.SFPerson = s_SFPerson;
							session.Save(tChargeF);
						}
						ChargeDetail tCD = session.Get<ChargeDetail>(eList[j].CDNo);
						tCD.CFID = tChargeF.CFID;
						i_rtn = tChargeF.CFID;
						tCD.ChargeStatus = "已收费";
						tCD.ChargeFDate = DateTime.Now;
						tCD.ChargeSS = tCD.ChargeYS;
						
						session.Update(tCD);
					}
					else
					{
						//已经收过费了，不需要新收费单
						tChargeF = session.Get<ChargeF>(eList[j].CFID);
					}
					d_Total += eList[j].ChargeSS;
				}
				tChargeF.ChargeTotal = d_Total;
				session.Update(tChargeF);
				
				tx.Commit();
				return i_rtn;
			}
			catch(Exception e)
			{
				Debug.Assert(false,e.Message);
				tx.Rollback();
				session.Close();
				return -1;
			}
		}
		
		
		public static void BackStatus(string s_CFID)
		{
			//
			string s_SQL = "Update ChargeDetail SET ChargeStatus = '已计费',CFID = null WHERE CFID IN " + s_CFID;
			SQLiteHelper.ExecuteNonQuery(s_SQL);
			s_SQL = "DELETE FROM ChargeF WHERE CFID IN " + s_CFID;
			SQLiteHelper.ExecuteNonQuery(s_SQL);
		}
		
		
		
	}
}
