///////////////////////If,switch case////////////////////////////////////////////////////////////////
using System;

namespace Practicecsharp
{
	public class Condition
	{
		
		public static void Main()
		{
			
			//IF condition
			
			int x=4, y=3;
			if(x>y)
			{
				Console.WriteLine("X is greater than Y");
			}
			else if (x==y)
			{
				Console.WriteLine("X is equal to Y");
			}
			else
			{
				Console.WriteLine("X is less than Y");
			}
			
			//Switch case
			int a=5;
			switch(a)
			{
				case 1:
					Console.WriteLine("a is equal to 1");
					break;
				
				case 5:
					Console.WriteLine("a is equal to 5");
					break;
				
				default:
					Console.WriteLine("default value, no match");
					break;
			}
			
		}
	}
		
}