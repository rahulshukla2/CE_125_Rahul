using System;
using my_prog;
namespace driver
{

	class Program4
	{

		static void Main(string[] args)
		{
			Program3 m1 = new Program3();

			Console.WriteLine("Enter two number for which you want to add and multiply one by one in new line");

			int num1=Convert.ToInt32(Console.ReadLine());
			int num2=Convert.ToInt32(Console.ReadLine());


			Console.WriteLine("Addition={0}  Multiplication={1}",num1+num2,num1*num2);
			Console.ReadKey();
		}

	}



}
