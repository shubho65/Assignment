/////implicit type variable

using System;

namespace Practicecsharp
{
	public class ImplicitType
	{
		
		public static void Main()
		{
			int x=2;
			double y=5;   //Explicit variable, predefined types

			var a=3;
			var b=3.6;   //Implicit type, defines the data type based on the values assigned
			
			Console.WriteLine("Type of var: {0}",b.GetType());    //Type of var: System.Double
			var c=DateTime.Now;
			var d="hello";
			Console.WriteLine("Type of var: {0}",d.GetType());   //Type of var: System.String
			
		}
	}
		
}