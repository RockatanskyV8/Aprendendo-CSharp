/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 21/07/2017
 * Time: 20:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CSDrBn_8
{
	/// <summary>
	/// Description of Warrior.
	/// </summary>
	public class Warrior
	{
		
		public string nome;
		public double vida;
		public double attkMax;
		public double blckMax;
		
		Random rnd = new Random();
		
		public string Nome
		{
			set{nome = value;}
			get{return nome;}
		}
		public double Vida{
			set{vida = value;}
			get{return vida;}
		}
		public double AttkMax{
			set{attkMax = value;}
			get{return attkMax;}
		}
		public double BlckMax{
			set{blckMax = value;}
			get{return blckMax;}
		}
		
		public Warrior(
		string nome = "Warrior", double vida = 0,
		double attkMax = 0, double blckMax = 0
		)
		{
			Nome = nome;
			Vida = vida;
			AttkMax = attkMax;
			BlckMax = blckMax;
		}
		
		public double Attack(){
			return rnd.Next(1, (int)AttkMax);
		}
		
		public double Block(){
			return rnd.Next(1, (int)BlckMax);
		}
	}
}
