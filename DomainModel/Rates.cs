/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-08-27
 * 时间: 17:38
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace DomainModel
{
	/// <summary>
	/// Description of Rates.
	/// </summary>
	public class Rates
	{
		public Rates()
		{
		}
		public virtual int RateID
		{get;set;}
		public virtual string RateName		//收费名称，打印需要的，给客户看的
		{get;set;}
		public virtual string RateBrief		//收费的较详细描述
		{get;set;}
		public virtual string RateUnit		//收费费率的单位，计量表就是计量单位，建筑面积，套内面积，公摊面积，人口数，固定金额
		{get;set;}
		public virtual string RateClass		//收费类别：周期性收费、临时性收费、押金类收费、表计量收费（此类收费项不能单独临时加）
		{get;set;}
		public virtual decimal RateValue	//收费费率或收费额
		{get;set;}
	}
}
