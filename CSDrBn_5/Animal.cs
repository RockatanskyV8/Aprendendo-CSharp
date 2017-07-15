/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 15/07/2017
 * Time: 14:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CSDrBn_5
{
	/// <summary>
	/// Description of Animal.
	/// </summary>
	public class Animal
	{
		public string nome;
		public string som;
		
		public Animal()
		{
			nome = "sem nome";
			som = "Não faz som";
			numDeAnimais++;
		}
		
		public Animal(string nome = "sem nome")
		{
			this.nome = nome;//this refere-se ao nome do objeto, ao invés do que foi passado no construtor
			som = "Não faz som";
			numDeAnimais++;
		}
		
		public Animal(string nome = "sem nome", string som = "sem som")
		{
			this.nome = nome;
			this.som = som;
			numDeAnimais++;
		}
		
		public void fazSom(){
			Console.WriteLine("{0} faz {1}", nome, som);
		}
		
		public static int numDeAnimais = 0;
		
		public static int retornaNumAnimais(){
			return numDeAnimais;
		}
		
	}
}
