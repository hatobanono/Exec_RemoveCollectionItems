using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] source = { 3, 5, 7, 9, 11, 13 };
			int[] target = { 7, 11, 99 };
			string result = string.Empty;

			for(int i = 0; i < source.Length; i++)
			{
				int? int1 = source[i];
				for (int k =0; k < target.Length; k++)
				{
					if (int1 == target[k])
					{
						int1 = null;
					}
				}
				if (int1 != null)
				{
					result += int1 + " ";	
				} 
			}
			Console.WriteLine(result);
		}
	}
}
