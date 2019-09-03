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