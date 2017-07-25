/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 22/07/2017
 * Time: 20:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CSDrBn_9
{
	/// <summary>
	/// Description of Circulo.
	/// </summary>
	class Circulo : Forma
	{
		
		private double raio;
		
		public double Raio{
			set{raio = value;}
			get{return raio;}
		}
		
		public override double Area(){
			return Math.PI * (Math.Pow(Raio, 2.0));
		}
		
		public override void GetInfo(){
			base.GetInfo();
			Console.WriteLine("O raio do circulo é {0}", raio);
		}
		
		public Circulo(double raio){
			Nome = "Circulo";
			Raio = raio;
			
		}
	}
}
