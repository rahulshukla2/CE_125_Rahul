using System;
using System.Reflection;
[assembly: AssemblyVersion("1.0.0.0")]
namespace my_prog
{
	public class my_prog_class
	{
		public int addition(int x,int y)
		{
			Console.WriteLine("The addition is :");
			return x+y;
		}

		public int multiplication(int x,int y)
		{
			Console.WriteLine("The multiplication is :");
			return x*y;
		}
		
	}
}
