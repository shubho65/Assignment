///////////////////////Property////////////////////////////////////////////////////////////////
using System;

namespace Practicecsharp
{
	public class Property
	{
		
		public static void Main()
		{
			
			var person=new Person();
			person.Name="shubho";
			Console.WriteLine("Person Info: {0}", person.Name);
			
			person.Name = "asif";
         	Console.WriteLine("Person Info: {0}", person.Name);
			
		}
	}
	
	public class Person
	{
		
		//Property is an encasulation technique which gvies accessability to private variable through get/set
		private string name;
		
		public string Name 
		{ 
			get
			{
				if(name==null)
					return string.Empty;
				else 
					return name;
			}
			set
			{
				if(value==null)
					name=string.Empty;
				else 
					name=value;
			}
		}
		
		
	}
}