///////////////////////Anonymous////////////////////////////////////////////////////////////////


using System;

namespace Practicecsharp
{
	public class Anonymous
	{
		
		public static void Main()
		{
			//instantly create a class and then use as a regular class object
			
			var person=new
			{	
				FIrstName="shubho",
				LastName="De",
				Age=33
			};
			
			Console.WriteLine("Anonymous type class- Name is: {0} and age is : {1}",person.FIrstName,person.Age);   
			
		}
	}
		
}