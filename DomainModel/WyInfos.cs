/*
 * 由SharpDevelop创建。
 * 用户： Deng
 * 日期: 2016-08-28
 * 时间: 16:47
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace DomainModel
{
	/// <summary>
	/// Description of WyInfos.
	/// </summary>
	public class WyInfos
	{
		public WyInfos()
		{
		}
		
		public virtual int WyID				//物业ID
		{get;set;}	
		
		public virtual string WyName		//物业名称
		{get;set;}
		
		public virtual Nullable<decimal> JZArea		//建筑面积
		{get;set;}
		
		public virtual Nullable<decimal> TNArea		//套内面积
		{get;set;}
		
		public virtual Nullable<decimal> GTArea		//公摊面积
		{get;set;}
		
		public virtual string OwnerName		//业主姓名
		{get;set;}
		
		public virtual string OwnerDetail	//业主详细信息
		{get;set;}
		
		public virtual Nullable<int> UNIT_No			//单元号
		{get;set;}
		
		public virtual Nullable<int> FLOOR_No			//楼层号
		{get;set;}
		
		public virtual Nullable<int> ROOM_No			//房间号
		{get;set;}
		
		public virtual Nullable<int> CustomerID		//缴费ID
		{get;set;}
		
			
	}
}
