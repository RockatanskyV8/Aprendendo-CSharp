/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 23/07/2017
 * Time: 00:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CSDrBn_10
{
	/// <summary>
	/// Description of Televisao.
	/// </summary>
	public class Televisao : IEletronico
	{
		private int volume;
		public int Volume{
			set{volume = value;}
			get{return volume;}
		}
		
		public void Ligado(){
			Console.WriteLine("TV ligada");
		}
		public void Desligado(){
			Console.WriteLine("TV desligada");
		}
		public void VolumeMais(){
			if(volume != 100) volume++;
			Console.WriteLine("O volume da TV é:");
		}
		public void VolumeMenos(){
			if(volume != 0) volume--;
			Console.WriteLine("O volume da TV é:");
		}
	}
}
