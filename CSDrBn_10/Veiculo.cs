/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 23/07/2017
 * Time: 00:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CSDrBn_10
{
	/// <summary>
	/// Description of Veiculo.
	/// </summary>
	public class Veiculo : IDrivable
	{
		private string marca;
		public string Marca{
			set{marca = value;}
			get{return marca;}
		}
		
		public Veiculo(string marca, int rodas, double velocidade){
			Marca = marca;
			Rodas = rodas;
			Velocidade = velocidade;
		}
		
		private int rodas;
		private double velocidade;
		
		public int Rodas{
			set{rodas = value;}
			get{return rodas;}
		}
		public double Velocidade{
			set{velocidade = value;}
			get{return velocidade;}
		}
		
		public void Mova(){
			Console.WriteLine("O {0} corre a uma velocidade de {1}", marca, velocidade);
		}
		public void Para(){
			Console.WriteLine("O {0} parou", marca);
			Velocidade = 0;
		}
		
	}
}
