/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-09-02
 * 时间: 14:28
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace DomainModel
{
	/// <summary>
	/// Description of Charge.
	/// </summary>
	public class Charge
	{
		public Charge()
		{
		}
		
		public virtual int CID
		{get;set;}
		
		public virtual string PeriodNo
		{get;set;}
		
		public virtual decimal ChargeTotal		//计费单总金额
		{get;set;}
		
		public virtual string Abstract
		{get;set;}
		
		public virtual string ChargeStatus
		{get;set;}
		
		public virtual Nullable<int> CustomerID
		{get;set;}
		
		public virtual string CustomerName
		{get;set;}
	}
}
