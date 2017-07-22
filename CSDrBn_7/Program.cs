/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 18/07/2017
 * Time: 19:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDrBn_7
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Animal peij = new Animal(){
				Nome = "Pei'j",
				Som = "Fajitaaaaaassss!!"
			};
			
			Dog doug = new Dog(){
				Nome = "Doug",
				Som = "Woof",
				Som2 = "Grrrrr"
			};
			
			doug.Som = "Woooof";
			
			peij.FazSom();
			doug.FazSom();
			
			peij.SetAnimalIDInfo(1234, "Jade");
			doug.SetAnimalIDInfo(1235, "Ninguém");
			
			peij.GetAnimalIDInfo();
			
			Animal.AnimalHeath getHealth = new Animal.AnimalHeath();
			
			Console.WriteLine("Is my animal healthy : {0}", getHealth.HealthWeight(11, 46));
			
			Animal spot = new Dog(){
				Nome = "Spot",
                Som = "Wooooff",
                Som2 = "Geerrrr"
			};
			
			spot.FazSom();
			
			Console.Write("Qualquer tecla fecha . . . ");
			Console.ReadKey(true);
		}
	}
}