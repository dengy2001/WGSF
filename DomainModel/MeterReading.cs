/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-08-31
 * 时间: 22:17
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace DomainModel
{
	/// <summary>
	/// Description of MeterReading.
	/// </summary>
	public class MeterReading
	{
		public MeterReading()
		{
		}
		
		public virtual int RID								//顺序号
		{get;set;}
		
		public virtual int MeterID							//表号
		{get;set;}
		
		public virtual string MeterName						//表名
		{get;set;}
		
		public virtual Nullable<int> MeterPID				//上级表号，null表示无上级
		{get;set;}
		
		public virtual string MeterPName					//上级表名
		{get;set;}
		
		public virtual string MeterClass					//表类：水表，电表，气表
		{get;set;}
				
		public virtual int MeterUsing				//表是否在使用中，0-未用，1-在用
		{get;set;}
		
		public virtual int MeterCanSharing		//该表是否计费承担分摊量（实际会计算，但不收）
		{get;set;}
		
		public virtual int MeterSelfUse			//对于总表来说，它直接下级表未装全，差值作为它的用量
		{get;set;}
		
		public virtual int MeterMulti						//表倍率
		{get;set;}
		
		public virtual Nullable<int> MeterMaxNumber			//表能标识的最大值，超过后循环。如99999
		{get;set;}
		
		public virtual Nullable<int> RateID					//表计量的费率
		{get;set;}
		
		public virtual string RateName						//费率名
		{get;set;}
		
		public virtual Nullable<decimal> RateValue			//费率值
		{get;set;}
		
		public virtual Nullable<int> WyID					//表属于的物业
		{get;set;}
		
		public virtual string WyName						//物业名
		{get;set;}
		
		public virtual string PeriodNo						//计量周期
		{get;set;}
		
		public virtual Nullable<int> StartReading			//起数
		{get;set;}
		
		public virtual Nullable<int> EndReading				//止数
		{get;set;}
		
		public virtual string RStatus						//状态：计量输入，计量计算，已结算，已完成
		{get;set;}
		
		public virtual Nullable<DateTime> CreatedDate		//生成日期
		{get;set;}
		
		public virtual Nullable<int> AdjustNum				//调整量
		{get;set;}
		
		public virtual Nullable<int> BeforeShareTotal		//分摊前总量
		{get;set;}
		
		public virtual Nullable<int> ShareNum				//分摊量
		{get;set;}
		
		public virtual Nullable<int> TotalNum				//总用量
		{get;set;}
		
		public virtual Nullable<decimal> TotalSum			//总金额
		{get;set;}
		
		
	}
}
