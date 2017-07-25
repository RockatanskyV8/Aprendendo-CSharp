/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 22/07/2017
 * Time: 23:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CSDrBn_10
{
	class Program
	{
		public static void Main(string[] args)
		{
			Veiculo buick = new Veiculo("Buick", 4, 160);
			
			if(buick is IDrivable){
				buick.Mova();
				buick.Para();
			} else{
				Console.WriteLine("O {0} não pode ser dirigido", buick.Marca);
			}
			
			IEletronico TV = ControleTV.GetDevice();
			
			PowerButton powBut = new PowerButton(TV);
			
			powBut.Executar();
			powBut.Desfazer();
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}