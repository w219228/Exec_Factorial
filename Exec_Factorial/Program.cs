using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Exec_Factorial
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("請輸入一個數字");
			
			string input = Console.ReadLine();
			bool value = int.TryParse(input, out int num);
			long add =1;
			if(value==false)
			{
				Console.WriteLine("請重新輸入");
				return;
			}

			for (int i =1;i<=num;i++)
			{
				add = i*add;    
			}
			Console.WriteLine(add);
		}
	}
}
