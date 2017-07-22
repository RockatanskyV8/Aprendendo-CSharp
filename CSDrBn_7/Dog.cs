/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 20/07/2017
 * Time: 23:22
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
	/// <summary>
	/// Description of Dog.
	/// </summary>
	public class Dog : Animal
	{
		public string som2;
		
		public string Som2{
		get{return som2;}
		set{som2 = "Grrrrr";}
		}
		
		public override void FazSom(){
			Console.WriteLine("{0} says {1} and {2}", Nome, Som, Som2);
		}
		
		public Dog(string nome = "No Name", string som = "No Sound", string som2 = "No Sound 2"):base(nome, som)
		{
			Som2 = som2;
		}
	}
}
