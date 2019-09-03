///////////////////////Loop////////////////////////////////////////////////////////////////
using System;

namespace Practicecsharp
{
	public class Loop
	{
		
		public static void Main()
		{
			
			//For loop with continue and break
			for (int x=0,y=5;x<10 && y>0;x++,y--)
			{
				if(x==2)
				{
					Console.WriteLine("value of X:{0} and value of Y:{1}",x,y);
					continue;  //will not to below statemnt, rather directly go to again for loop to start with x=3
				}
				Console.WriteLine("statement after continue:x value={0}",x);
				
				if(x==4)
				{
					Console.WriteLine("statement before break:x value={0}",x);   //break out of the main for loop
					break;
				}
				
			}
			
			//while loop
			int a=5;
			while(a>0)
			{
				Console.WriteLine("value of a:{0}",a);
				a--;
			}
			//do while loop
			int b=5;
			do
			{
				Console.WriteLine("value of b:{0}",b);
				b--;
			}
			while (b>0);
			
			//foreach loop, collection iteration
			string [] names=new string[3];
			names[0]="asif";
			names[1]="shubho";
			names[2]="rahat";
			foreach(string name in names)
			{
				Console.WriteLine(name);
			}
			
			
		}
	}
		
}