/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 22/07/2017
 * Time: 19:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CSDrBn_9
{
	/// <summary>
	/// Description of Forma.
	/// </summary>
	abstract class Forma
	{
		private string nome;
		public string Nome{
			get{return nome;}
			set{nome = value;}
		}
		
		public virtual void GetInfo(){
			Console.WriteLine("Isso é um {0}", nome);
		}
		
		public abstract double Area();
		
	}
}
