/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-08-31
 * 时间: 11:22
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace DomainModel
{
	/// <summary>
	/// Description of WyRates.
	/// </summary>
	public class WyRates
	{
		public WyRates()
		{
		}
		
		public virtual int WyRateID
		{get;set;}
		
		public virtual int WyID
		{get;set;}
		
		public virtual int RateID
		{get;set;}
	}
}
