/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 13/07/2017
 * Time: 11:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;


namespace CSDrBn_4
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine();
			Console.WriteLine("---------------------------PASSING BY VALUE------------------------------");
			Console.WriteLine();
			
			double x = 5;
			double y = 4;
			
			Console.WriteLine("X + Y = {0}", execSoma(x, y));
			
			Console.WriteLine();
			Console.WriteLine("---------------------------OUT PARAMETER------------------------------");
			Console.WriteLine();
			
			int solucao;
			
			ODobro(10, out solucao);
			
			Console.WriteLine("10 x 2 = {0}", solucao);
			
			Console.WriteLine();
			Console.WriteLine("---------------------------PASS BY REFERENCE------------------------------");
			Console.WriteLine();
			
			int num1 = 10;
			int num2 = 20;
			
			Console.WriteLine("Antes - num1 : {0} num2 : {1}", num1, num2);
			
			Trocar(ref num1, ref num2);
			
			Console.WriteLine("Depois - num1 : {0} num2 : {1}", num1, num2);
			
			Console.WriteLine();
			Console.WriteLine("---------------------------PARAMS------------------------------");
			Console.WriteLine();
			
			Console.WriteLine("Soma de vários números: {0}", MaisSoma(1, 2, 3));
			
			Console.WriteLine();
			Console.WriteLine("---------------------------NAMED PARAMETERS------------------------------");
			Console.WriteLine();
			
			PrintInfo(zipCode: 12345, name: "Fulano de Tal");
			
			Console.WriteLine();
			Console.WriteLine("---------------------------METHOD OVERLOADING------------------------------");
			Console.WriteLine();
			
			Console.WriteLine("5.0 + 4.5 = {0}", GetSum(5.0, 4.5));
			Console.WriteLine("5.0 + 4.0 = {0}", GetSum("5.0", "4.0"));
			
			
			Console.WriteLine();
			Console.WriteLine("---------------------------Enum------------------------------");
			Console.WriteLine();
			
			CorCarro carro1 = CorCarro.azul;
			PintarCarro(carro1);
			
			Console.Write("Qualquer tecla fecha . . .");
			Console.ReadKey(true);
		}
		//passando os parametros
		static double execSoma(double x = 1, double y = 1){
			double temp = x;
			x = y;
			y = temp;
			return x + y;
		}
		//OUT: valor assinado com o out será retornado
		static void ODobro(int x, out int solucao){
			solucao = x * 2;
		}
		//passando como ref, a propria variavel que for referenciada será afetada
		static void Trocar(ref int num1, ref int num2){
			int temp = num1;
            num1 = num2;
            num2 = temp;
		}
		//passando um array como parametro, pode-se passar vários valores,
		//se os mesmos forem do mesmo datatype que o array
		static double MaisSoma(params double [] nums){
			double sum = 0;
			foreach (int i in nums)
            {
                sum += i;
            }
            return sum;
		}
		//os parametros podem ser passados em qualquer ordem
		static void PrintInfo(String name, int zipCode){
			Console.WriteLine("{0} tem codigo zip : {1}", name, zipCode);
		}
		//uma função pode ter o mesmo nome que outra, se elas tiverem parametros diferentes
		static double GetSum(double x = 1, double y = 1){
			return x + y;
		}
		static double GetSum(string x = "1", string y = "1"){
			double dblX = Convert.ToDouble(x);
            double dblY = Convert.ToDouble(y);
            return dblX + dblY;
		}
		
		// An enum is a custom data type with key value pairs.
        // They allow you to use symbolic names to represent data
        // The first number is 0 by default unless you change it
        // You can define the underlying type or leave it as int as default
		
		enum CorCarro : byte
		{
			laranja = 1,
            azul,
            verde,
            vermelho,
            amarelo
		}
		
		static void PintarCarro(CorCarro cc)
        {
            Console.WriteLine("O Carro foi pintado de {0} como o código {1}",
                cc, (int)cc);
        }
		
	}
}