///////////////////////Operators////////////////////////////////////////////////////////////////
using System;

namespace Practicecsharp
{
	public class Operator
	{
		
		public static void Main()
		{
			
			int x=4, y=3;
			int z=x+y;
			int a=x-y;
			double b=(x/y)*1.02;
			Console.WriteLine(b);
			int c=x*y;
			Console.WriteLine("{0},{1},{2:R},{3}",z,a,b,c);
			
			bool p=true;
			bool q=false;
			bool r=p && q;
			bool s=p || q;
			
			string aa=null;
			string bb=aa?? "Empty";   //if null then Empty
			Console.WriteLine(bb);
			
			//ternary operator
			z=x>y ? x:y;
			Console.WriteLine(z);
			
			//pre and post increment exmaple
			
			z=x++*5;
			Console.WriteLine(z);   //20
			Console.WriteLine(x);   //4+1=5
			
			z=++x*5;
			Console.WriteLine(x);   //5+1=6
			Console.WriteLine(z);   //6*5=30
			
		}
	}
		
	

}