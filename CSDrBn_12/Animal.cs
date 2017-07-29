/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 26/07/2017
 * Time: 20:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CSDrBn_12
{
	/// <summary>
	/// Description of Animal.
	/// </summary>
	class Animal
	{
		private string nome;
		
		public string Nome{
			set{nome = value;}
			get{return nome;}
		}
		
		public Animal(string Anome = "sem nome")
		{
			nome = Anome;
		}
		
		public static void GetSum<T>(ref T num1, ref T num2){
			double dblX = Convert.ToDouble(num1);
			double dblY = Convert.ToDouble(num2);
			Console.WriteLine("{0} + {1} = {2}", dblX, dblY, (dblX + dblY));
		}
	}
}
