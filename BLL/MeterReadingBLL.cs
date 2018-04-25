/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-08-31
 * 时间: 22:37
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Data;
using NHibernate;
using NHibernate.Cfg;
using DomainModel;
//using System.Data.SQLite;
using DAL;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics;

namespace BLL
{
	/// <summary>
	/// Description of MeterReadingBLL.
	/// </summary>
	public class MeterReadingBLL
	{
		public MeterReadingBLL()
		{
		}
		
		//添加新的
		public static void AddMeterReading(MeterReading tNew)
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
		public static void UpdateMeterReading(MeterReading tNew)
		{
			ISession session = NHibernateHelper.OpenSession();
			try
			{				
				ITransaction tx = session.BeginTransaction();
				MeterReading tModify = session.Get<MeterReading>(tNew.RID);
				tModify.MeterID = tNew.MeterID;
				tModify.MeterName = tNew.MeterName;
				tModify.MeterPID = tNew.MeterPID;
				tModify.MeterPName = tNew.MeterPName;
				tModify.MeterClass = tNew.MeterClass;				
				tModify.MeterUsing = tNew.MeterUsing;
				tModify.MeterCanSharing = tNew.MeterCanSharing;
				tModify.MeterSelfUse = tNew.MeterSelfUse;
				tModify.MeterMulti = tNew.MeterMulti;
				tModify.MeterMaxNumber = tNew.MeterMaxNumber;
				tModify.RateID = tNew.RateID;
				tModify.RateName = tNew.RateName;
				tModify.RateValue = tNew.RateValue;
				tModify.WyID = tNew.WyID;
				tModify.WyName = tNew.WyName;
				tModify.PeriodNo = tNew.PeriodNo;
				tModify.StartReading = tNew.StartReading;
				tModify.EndReading = tNew.EndReading;
				tModify.RStatus = tNew.RStatus;
				tModify.CreatedDate = tNew.CreatedDate;
				tModify.AdjustNum = tNew.AdjustNum;
				tModify.BeforeShareTotal = tNew.BeforeShareTotal;
				tModify.ShareNum  = tNew.ShareNum;
				tModify.TotalNum = tNew.TotalNum;
				tModify.TotalSum = tNew.TotalSum;
				

				tx.Commit();
			}
			catch(Exception e)
			{
				Debug.Assert(false,e.Message);
			}
			session.Close();
		}
		
		//获取MeterReading
		public static DataSet GetPeriodMeterReading(string s_PeriodNo)
		{
			DataSet ds = new DataSet();
			ds = SQLiteHelper.ExecuteDataSet("SELECT ' ' AS TreeText,RID,MeterID,MeterName,MeterPID,MeterPName,MeterClass,MeterUsing,MeterCanSharing,MeterSelfUse,MeterMulti,MeterMaxNumber,RateID,RateName,RateValue,WyID,WyName,PeriodNo,StartReading,EndReading,RStatus,AdjustNum,BeforeShareTotal,ShareNum,TotalNum,TotalSum FROM MeterReading WHERE PeriodNo = @PeriodNo ORDER BY MeterClass",s_PeriodNo);
			return ds;
		}
		
		//获取指定MeterReading
		public static MeterReading GetMeterReading(int i_RID)
		{
			ISession session = NHibernateHelper.OpenSession();
			MeterReading tClass = new MeterReading();
			try
			{
				tClass = session.Get<MeterReading>(i_RID);
			}
			catch(Exception e)
			{
				Debug.Assert(false,e.Message);
			}
			session.Close();
			return tClass;
		}
		
		//删除
		public static void DelMeterReading(int  i_RID)
		{
			//ISessionFactory sessionFactory = new Configuration().Configure().BuildSessionFactory();
			ISession session = NHibernateHelper.OpenSession();
			ITransaction tx = session.BeginTransaction();
			MeterReading toDelete = session.Get<MeterReading>(i_RID);
				
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
		
		//生成指定周期的计量表记录空表
		public static void ProduceMeterReading(string s_PeriodNo,Label lStatus)
		{
			string s_LastPeriodNo = "";
			string s_year,s_month;
			s_year = s_PeriodNo.Substring(0,4);
			s_month =s_PeriodNo.Substring(4,2);
			int i_month = Convert.ToInt32(s_month);
			int i_year = Convert.ToInt32(s_year);
			if(i_month == 1)
			{
				s_LastPeriodNo = (i_year - 1).ToString() + "12";
			}
			else
			{
				s_LastPeriodNo = i_year.ToString() + (i_month - 1).ToString("00");
			}
			DataSet ds = new DataSet();
			//检查当前周期的表记录是否已经结算了（状态：已结算）
			int i_rtn = Convert.ToInt32(SQLiteHelper.ExecuteScalar("SELECT Count(*) FROM MeterReading WHERE RStatus = '已结算' AND PeriodNo = @PeriodNo",s_PeriodNo));
			if(i_rtn > 0)
			{
				MessageBox.Show("当前计量周期已经结算完成，不能生成！","提示信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}
			
			ISession session = NHibernateHelper.OpenSession();
			ITransaction tx = session.BeginTransaction();
		
			ds = SQLiteHelper.ExecuteDataSet("SELECT MeterID FROM Meters WHERE MeterUsing = 1");
			DataRow[] drs;
			drs = ds.Tables[0].Select("1=1");
			try
			{	
				for (int i = 0; i < drs.Length; i++)
	            {
					int i_MeterID = Convert.ToInt32(drs[i]["MeterID"].ToString());
					
					lStatus.Text = "正在处理计量表：【" + i_MeterID.ToString() + "】";
					
					IQuery query = session.CreateQuery("FROM MeterReading WHERE MeterID = ? AND PeriodNo = ?");
					query.SetParameter(0,i_MeterID.ToString());  
       				query.SetParameter(1, s_PeriodNo);  

					IList<MeterReading> eList = query.List<MeterReading>();
					
					//查上期有无记录
					IQuery query1 = session.CreateQuery("FROM MeterReading WHERE MeterID = ? AND PeriodNo = ?");
					query1.SetParameter(0,i_MeterID.ToString());  
       				query1.SetParameter(1, s_LastPeriodNo);  

					IList<MeterReading> eList1 = query1.List<MeterReading>();
					
					Meters tMeter = session.Get<Meters>(i_MeterID);
									
					
					if(eList.Count == 0)
					{
						MeterReading tNew = new MeterReading();
						tNew.MeterID = tMeter.MeterID;
						tNew.MeterName = tMeter.MeterName;
						tNew.MeterPID = tMeter.MeterPID;
						if(tMeter.MeterPID != null)
						{
							Meters tPMeter = session.Get<Meters>(tMeter.MeterPID);
							tNew.MeterPName = tPMeter.MeterName;
						}						
						tNew.MeterClass = tMeter.MeterClass;
						tNew.MeterUsing = tMeter.MeterUsing;
						tNew.MeterCanSharing = tMeter.MeterCanSharing;
						tNew.MeterSelfUse = tMeter.MeterSelfUse;
						tNew.MeterMulti = tMeter.MeterMulti;
						tNew.MeterMaxNumber = tMeter.MeterMaxNumber;
						tNew.RateID = tMeter.RateID;
						if(tMeter.RateID != null)
						{
							Rates tRate = session.Get<Rates>(tMeter.RateID);						
							tNew.RateName = tRate.RateName;
							tNew.RateValue = tRate.RateValue;
						}
						tNew.WyID = tMeter.WyID;
						if(tMeter.WyID != null)
						{
							WyInfos tWyInfo = session.Get<WyInfos>(tMeter.WyID);
							tNew.WyName = tWyInfo.WyName;
						}					
						tNew.PeriodNo = s_PeriodNo;
						if(eList1.Count == 1)
						{
							tNew.StartReading = eList1[0].EndReading;
						}
						else
						{
							tNew.StartReading = 0;
						}						
						tNew.EndReading = 0;
						tNew.RStatus = "计量输入";
						tNew.CreatedDate = DateTime.Now;
						tNew.AdjustNum = 0;
						tNew.BeforeShareTotal = 0;
						tNew.ShareNum = 0;
						tNew.TotalNum = 0;
						session.Save(tNew);
					}
					else
					{
						//已经有数据了
						MeterReading tOld = session.Get<MeterReading>(eList[0].RID);
						tOld.MeterID = tMeter.MeterID;
						tOld.MeterName = tMeter.MeterName;
						tOld.MeterPID = tMeter.MeterPID;
						if(tMeter.MeterPID != null)
						{
							Meters tPMeter = session.Get<Meters>(tMeter.MeterPID);
							tOld.MeterPName = tPMeter.MeterName;
						}						
						tOld.MeterClass = tMeter.MeterClass;
						tOld.MeterUsing = tMeter.MeterUsing;
						tOld.MeterCanSharing = tMeter.MeterCanSharing;
						tOld.MeterSelfUse = tMeter.MeterSelfUse;
						tOld.MeterMulti = tMeter.MeterMulti;
						tOld.MeterMaxNumber = tMeter.MeterMaxNumber;
						tOld.RateID = tMeter.RateID;
						if(tMeter.RateID != null)
						{
							Rates tRate = session.Get<Rates>(tMeter.RateID);						
							tOld.RateName = tRate.RateName;
							tOld.RateValue = tRate.RateValue;
						}
						tOld.WyID = tMeter.WyID;
						if(tMeter.WyID != null)
						{
							WyInfos tWyInfo = session.Get<WyInfos>(tMeter.WyID);
							tOld.WyName = tWyInfo.WyName;
						}					
						tOld.PeriodNo = s_PeriodNo;
						tOld.CreatedDate = DateTime.Now;

						session.Update(tOld);
						
						Application.DoEvents();
					}
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

			lStatus.Text = "【记录生成完成！】";
			return;
		}
		
		//生成指定周期的计量表记录空表
		public static void UpdateMeterReading(string s_PeriodNo,DataTable dt,Label lStatus)
		{
			//检查当前周期的表记录是否已经结算了（状态：已结算）
			int i_rtn = Convert.ToInt32(SQLiteHelper.ExecuteScalar("SELECT Count(*) FROM MeterReading WHERE RStatus = '已结算' AND PeriodNo = @PeriodNo",s_PeriodNo));
			if(i_rtn > 0)
			{
				MessageBox.Show("当前计量周期已经结算完成，不能更新！","提示信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}
			
			ISession session = NHibernateHelper.OpenSession();
			ITransaction tx = session.BeginTransaction();
			DataRow[] drs;
			drs = dt.Select("1=1");
			try
			{
				for (int i = 0; i < drs.Length; i++)
	            {
					
					MeterReading tOld = session.Get<MeterReading>(Convert.ToInt32(drs[i]["RID"].ToString()));
					lStatus.Text = "正在处理计量表：【" + tOld.MeterName + "】";
					if(!drs[i].IsNull("StartReading"))
					{
						tOld.StartReading = Convert.ToInt32(drs[i]["StartReading"].ToString());
					}
					if(!drs[i].IsNull("EndReading"))
					{
						tOld.EndReading = Convert.ToInt32(drs[i]["EndReading"].ToString());
					}
					if(!drs[i].IsNull("AdjustNum"))
					{
						tOld.AdjustNum = Convert.ToInt32(drs[i]["AdjustNum"].ToString());
					}
					tOld.BeforeShareTotal = (tOld.EndReading-tOld.StartReading)*tOld.MeterMulti+tOld.AdjustNum;
					session.Update(tOld);
					
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
			
			lStatus.Text = "【更新计量表数据完成！】";
			return;
		}
	
		//删除
		public static void DelMeterReading(string  s_PeriodNo)
		{
			//检查当前周期的表记录是否已经结算了（状态：已结算）
			int i_rtn = Convert.ToInt32(SQLiteHelper.ExecuteScalar("SELECT Count(*) FROM MeterReading WHERE RStatus = '已结算' AND PeriodNo = @PeriodNo",s_PeriodNo));
			if(i_rtn > 0)
			{
				MessageBox.Show("当前计量周期已经结算完成，不能删除！","提示信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}
			
			//删除指定周期的所有计量表记录	
			SQLiteHelper.ExecuteNonQuery("DELETE FROM MeterReading WHERE PeriodNo = @PeriodNo",s_PeriodNo);
			
		}
		
		//计算表计量数量及金额
		public static void CalMeterReading(string s_PeriodNo,Label lStatus)
		{
			//检查当前周期的表记录是否已经结算了（状态：已结算）
			int i_rtn = Convert.ToInt32(SQLiteHelper.ExecuteScalar("SELECT Count(*) FROM MeterReading WHERE RStatus = '已结算' AND PeriodNo = @PeriodNo",s_PeriodNo));
			if(i_rtn > 0)
			{
				MessageBox.Show("当前计量周期已经结算完成，不能再计算！","提示信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}
			DataSet ds = BLL.MeterReadingBLL.GetPeriodMeterReading(s_PeriodNo);
			DataRow[] drs;
			drs = ds.Tables[0].Select("MeterPID is null");
			//顶层表
			for (int i = 0; i < drs.Length; i++)
            {
				int i_start = Convert.ToInt32(drs[i]["StartReading"].ToString());
				int i_end = Convert.ToInt32(drs[i]["EndReading"].ToString());
				int i_multi = Convert.ToInt32(drs[i]["MeterMulti"].ToString());
				int i_adj = Convert.ToInt32(drs[i]["AdjustNum"].ToString());

				int i_BeforeShare = (i_end - i_start)*i_multi +  i_adj;
				drs[i]["BeforeShareTotal"] = i_BeforeShare;
				drs[i]["TotalNum"] = i_BeforeShare;
				drs[i]["RStatus"] = "计量计算";
				CalAll(ds.Tables[0],Convert.ToInt32(drs[i]["MeterID"].ToString()),i_BeforeShare);
			}
			//现在ds.Tables[0]更新完了，保存起来,有变化的有：AdjustNum,BeforeShareTotal,ShareNum,TotalNum,TotalSum
			ISession session = NHibernateHelper.OpenSession();
			ITransaction tx = session.BeginTransaction();
			drs = ds.Tables[0].Select("1=1");
			try
			{
				for (int i = 0; i < drs.Length; i++)
	            {
					
					MeterReading tOld = session.Get<MeterReading>(Convert.ToInt32(drs[i]["RID"].ToString()));
					lStatus.Text = "正在保存计量表：【" + tOld.MeterName + "】";
					if(!drs[i].IsNull("AdjustNum"))
					{
						tOld.AdjustNum = Convert.ToInt32(drs[i]["AdjustNum"].ToString());
					}
					if(!drs[i].IsNull("BeforeShareTotal"))
					{
						tOld.BeforeShareTotal = Convert.ToInt32(drs[i]["BeforeShareTotal"].ToString());
					}
					if(!drs[i].IsNull("ShareNum"))
					{
						tOld.ShareNum = Convert.ToInt32(drs[i]["ShareNum"].ToString());
					}					
				
					tOld.TotalNum = Convert.ToInt32(drs[i]["TotalNum"].ToString());
					tOld.TotalSum = tOld.RateValue * tOld.TotalNum;
					tOld.RStatus = "计量计算";

					session.Update(tOld);
					
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
			
			lStatus.Text = "计算完成！";
		
		}
		
		
		//
		public static void CalAll(DataTable dt,int i_MeterPID,int i_TotalNum)
		{
			//在计算中更新DataTable
			//检查是否还有下级表
			DataRow[] drs;
			drs = dt.Select("MeterPID = " + i_MeterPID.ToString());
			int i_ThisTotalNum = 0;
			for (int i = 0; i < drs.Length; i++)
            {
				//有下级，累计用量为Sum（（止数-起数）*倍率+调整量）
				int i_start = Convert.ToInt32(drs[i]["StartReading"].ToString());
				int i_end = Convert.ToInt32(drs[i]["EndReading"].ToString());
				int i_multi = Convert.ToInt32(drs[i]["MeterMulti"].ToString());
				int i_adj = Convert.ToInt32(drs[i]["AdjustNum"].ToString());

				int i_BeforeShare = (i_end - i_start)*i_multi +  i_adj;				
				drs[i]["BeforeShareTotal"] = i_BeforeShare;
				
				i_ThisTotalNum = i_ThisTotalNum + i_BeforeShare;				
				
			}
			//2.将本级数据填完
			decimal d_shareall = i_TotalNum - i_ThisTotalNum;
			decimal d_shareRate ;
			if(i_ThisTotalNum != 0)
			{
				d_shareRate = d_shareall/i_ThisTotalNum;
			}
			else
			{
				d_shareRate = 0.0m;
			}
			for (int i = 0; i < drs.Length; i++)
            {
				int i_start = Convert.ToInt32(drs[i]["StartReading"].ToString());
				int i_end = Convert.ToInt32(drs[i]["EndReading"].ToString());
				int i_multi = Convert.ToInt32(drs[i]["MeterMulti"].ToString());
				int i_adj = Convert.ToInt32(drs[i]["AdjustNum"].ToString());

				int i_BeforeShare = (i_end - i_start)*i_multi +  i_adj;
				
				decimal d_curS = i_BeforeShare * d_shareRate;
				//如果上级表是MeterSelfUse,则本级分摊为0，上级TotalNum为上级总量-本级所有表的和。
				DataRow[] drs_P;
				drs_P = dt.Select("MeterID = " + drs[i]["MeterPID"].ToString() + " AND PeriodNo = " + drs[i]["PeriodNo"].ToString());
				if(drs_P[0]["MeterSelfUse"].ToString() == "1")
				{
					//上级表记录下级表未装全
					drs_P[0]["TotalNum"] = Convert.ToInt32(d_shareall);
					d_curS = 0.0m;
				}
				drs[i]["ShareNum"] = Convert.ToInt32(d_curS);
				int i_Total = i_BeforeShare + Convert.ToInt32(d_curS);
				drs[i]["TotalNum"] = i_Total;
				drs[i]["RStatus"] = "计量计算";
			}
			
			//3.再将所有本级的下级计算
			for (int i = 0; i < drs.Length; i++)
            {								
				//计算当前表的下级
				CalAll(dt,Convert.ToInt32(drs[i]["MeterID"].ToString()),Convert.ToInt32(drs[i]["TotalNum"].ToString()));
			}
		}
		
	}
}
