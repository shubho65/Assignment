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


///////////////////////Interface////////////////////////////////////////////////////////////////

Weapon[] weapons=new Weapon[2];
weapons[0]=new Missile();
weapons[1]=new MachineGun();

//interface e shob defined ar abstract e mixed- calculate dollar same for two class, but vat different

interface Item
{
	double CalculateDollarPrice();
	double GetVat();
}

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
///////////////////////////////////////Enum//////////////////////////////////////////////////////////////////////
using System;

namespace Practicecsharp
{
	public class Enum
	{
		
		public static void Main()
		{
			Console.WriteLine(RegistrationStatus.Active);
			
			var user=new User();
			if(user.Status==RegistrationStatus.Active && user.Type==UserType.Admin)
			{
				Console.WriteLine("Admin Login successful");
			}
			
		}
		public class User
		{
			public string Name {get;set;}
			public int Age {get;set;}
			public RegistrationStatus Status {get;set;}
			public UserType Type {get;set;}
		}
	
		public enum RegistrationStatus
		{
			Inactive,
			Blocked,
			Active
		}
		public enum UserType
		{
			Member,
			Support,
			Admin
		}
	}
	
}

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