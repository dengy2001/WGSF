/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-09-02
 * 时间: 14:34
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace DomainModel
{
	/// <summary>
	/// Description of ChargeDetail.
	/// </summary>
	public class ChargeDetail
	{
		public ChargeDetail()
		{
		}
		
		public virtual int CDNo
		{get;set;}
		
		public virtual string Abstract
		{get;set;}
		
		public virtual string PeriodNo
		{get;set;}
		
		public virtual Nullable<int> WyID
		{get;set;}
		
		public virtual string WyName
		{get;set;}
		
		public virtual string ChargeName			//计费名称
		{get;set;}
		
		public virtual string ChargeStatus			//计费状态：已计费、已收费、暂未收、免收
		{get;set;}
		
		public virtual string ChargeUnit
		{get;set;}
		
		public virtual decimal ChargeNum
		{get;set;}
		
		public virtual decimal ChargePrice
		{get;set;}
		
		public virtual decimal ChargeYS				//应收费
		{get;set;}
		
		public virtual decimal ChargeSS				//实收费
		{get;set;}
		
		public virtual Nullable<DateTime> ChargeDate	//计费日期
		{get;set;}
		
		public virtual Nullable<DateTime> ChargeFDate	//收费日期
		{get;set;}
		
		public virtual Nullable<int> CID				//计费单号
		{get;set;}
		
		public virtual Nullable<int> CFID				//收费单号
		{get;set;}
		
		public virtual Nullable<int> RID				//表计量单号
		{get;set;}
		
		public virtual Nullable<int> WyRateID			//
		{get;set;}
	}
}
