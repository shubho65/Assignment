///////////////////////Dynamic////////////////////////////////////////////////////////////////

using System;

namespace Practicecsharp
{
	public class Dynamic
	{
		
		public static void Main()
		{
			//no fixed data type, rather dynamic data type based on value assignment
			
			dynamic somevariable=100;
			somevariable="this is now string";
			somevariable=true;
			somevariable=new {name="shubho", age=33};
			
			Console.WriteLine(somevariable);   
			
		}
	}
}