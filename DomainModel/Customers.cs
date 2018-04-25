/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-08-29
 * 时间: 16:52
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace DomainModel
{
	/// <summary>
	/// Description of Customers.
	/// </summary>
	public class Customers
	{
		public Customers()
		{
		}
		
		public virtual int CustomerID
		{get;set;}
		
		public virtual string CustomerName
		{get;set;}
		
		public virtual string CustomerLinkMan
		{get;set;}
		
		public virtual string CustomerLinkDetail
		{get;set;}
	}
}
