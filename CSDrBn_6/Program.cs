/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 17/07/2017
 * Time: 23:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CSDrBn_6
{
	class Program
	{
		public static void Main(string[] args)
		{
			Animal pig = new Animal();
			
			pig.SetNome("Pey'j");
			
			pig.Som = "Fajitaaaaaassss!!";
			
			Console.WriteLine("{0} says {1} \n", pig.getNome(), pig.Som);
			
			Console.WriteLine("{0} shelter {1} \n", pig.getNome(), pig.idNum);
			
			Console.WriteLine("Tem {0} Animal \n", Animal.numDeAnimais);
			
			Console.Write("Qualquer tecla fecha . . . ");
			Console.ReadKey(true);
		}
	}
}