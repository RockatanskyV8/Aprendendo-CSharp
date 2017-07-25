/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 22/07/2017
 * Time: 21:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CSDrBn_9
{
	/// <summary>
	/// Description of Retangulo.
	/// </summary>
	class Retangulo : Forma
	{
		
		private double comprimento;
		private double largura;
		
		public double Comprimento{
			set{comprimento = value;}
			get{return comprimento;}
		}
		
		public double Largura{
			set{largura = value;}
			get{return largura;}
		}
		
		public Retangulo(double comprimento, double largura)
		{
			Nome = "Retangulo";
			Comprimento = comprimento;
			Largura = largura;
		}
		
		public override double Area(){
			return comprimento * largura;
		}
		
		public override void GetInfo(){
			base.GetInfo();
			Console.WriteLine("It has a Length of {0} and Width of {1}", comprimento, largura);
		}
	}
}
