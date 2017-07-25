/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 22/07/2017
 * Time: 19:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CSDrBn_9
{
	class Program
	{
		public static void Main(string[] args)
		{
			Forma [] formas = {new Circulo(5), new Retangulo(4,5)};
			
			// TODO: Implement Functionality Here
			
			foreach(Forma f in formas){
				f.GetInfo();
				
				Console.WriteLine("{0} tem area de {1:f2}", f.Nome, f.Area());
				
				Circulo teste = f as Circulo;
				if(teste == null){
					Console.WriteLine("Não é um circulo");
				}
				
				if(f is Circulo){
					Console.WriteLine("Não é um retângulo");
				}
			}
			
			object Circ1 = new Circulo(4);
			
			Circulo Circ2 = (Circulo)Circ1;
			
			Console.WriteLine("A {0} area é {1:f2}", Circ2.Nome, Circ2.Area());
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}