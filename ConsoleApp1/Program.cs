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
			int angka1, angka2, hasil = 0;

			Console.Write("angka1 = ");
			angka1 = int.Parse(Console.ReadLine());
			Console.Write("angka2 = ");
			angka2 = int.Parse(Console.ReadLine());

			

			Console.WriteLine($"Hasil angka1 + appel = {hasil}");
			hasil = angka1 + angka2;
			Console.WriteLine($"Hasil angka1 * appel = {hasil}");
			hasil = angka1 * angka2;

			

			//Console.Write("angka1 = ");
			//angka1 = int.Parse(Console.ReadLine());
			//Console.Write("appel = ");
			//angka2 = int.Parse(Console.ReadLine());




		}
	}
}
