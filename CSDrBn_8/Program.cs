/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 21/07/2017
 * Time: 20:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CSDrBn_8
{
	class Program
	{
		public static void Main(string[] args)
		{
			Warrior maximus = new Warrior("Maximus", 1000, 120, 40);
            Warrior bob = new Warrior("Bob", 1000, 120, 40);
 
            Battle.StartFight(maximus, bob);
 
            Console.ReadLine();
			
			// TODO: Implement Functionality Here
			
			Console.Write("Qualquer tecla fecha . . . ");
			Console.ReadKey(true);
		}
	}
}