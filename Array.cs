///////////////////////////Array//////////////////////////////////////////////////////////////////
using System;

namespace Practicecsharp
{
	public class ArrayPractice
	{
		
		public static void Main()
		{
			
			int[] marks = new int[5]  { 99,  98, 92, 97, 95};  //initializing array with values
			
			for(int i=0;i<marks.Length;i++)
			{
				Console.WriteLine(marks[i]);
			}
			
			
			double[] ages=new double[16];
			
			for(int i=0;i<ages.Length;i++)
			{
				ages[i]=int.Parse(Console.ReadLine());
			}
			
		}
		
	}
	
}