/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 10/07/2017
 * Time: 19:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Numerics;

namespace CSDrBn_helloworld
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");//printa esta mensagem
			
			for(int i = 0; i < args.Length; i++)//conta e printa os argumentos
			{
				Console.WriteLine("Arg num {0} = {1}", i , args[i]);
				//argumentos definidos em CSDrBn_helloworld(botao direito do mouse)>>Proprieties>>Debug
			}
			
			String [] MYargs = Environment.GetCommandLineArgs();
			
			Console.WriteLine(String.Join(", " , MYargs));
			
			sayHello();
			
			Console.WriteLine();
			Console.WriteLine("------------------Data Tipes--------------------");
			Console.WriteLine();
			
			bool canIVote = true;
 
            // INTEGERS
            // Integers : 32-bit
            Console.WriteLine("Maior Integer : {0}", int.MaxValue);
            Console.WriteLine("Menor Integer : {0}", int.MinValue);
 
            // LONGS
            // Longs : 64-bit
            Console.WriteLine("Maior Long : {0}", long.MaxValue);
            Console.WriteLine("Menor Long : {0}", long.MinValue);
 
            // DECIMALS
            // Decimals : 128-bit (valores decimais precisos)
            // Suportam até 28 digitos
            decimal decPiVal = 3.1415926535897932384626433832M;
            decimal decBigNum = 3.00000000000000000000000000011M;
            Console.WriteLine("DEC : PI + bigNum = {0}", decPiVal + decBigNum);
 
            Console.WriteLine("Maior Decimal : {0}", Decimal.MaxValue);
 
            // DOUBLES
            // Doubles : 64-bit float;
            Console.WriteLine("Maior Double : {0}", Double.MaxValue.ToString("#"));
 
            // Suporta 14 digitos
            double dblPiVal = 3.14159265358979;
            double dblBigNum = 3.00000000000002;
            Console.WriteLine("DBL : PI + bigNum = {0}", dblPiVal + dblBigNum);
 
            // FLOATS
            // Floats : 32-bit floats
            Console.WriteLine("Maior Float : {0}", float.MaxValue.ToString("#"));
 
            // Suporta 6 digitos
            float fltPiVal = 3.141592F;
            float fltBigNum = 3.000002F;
            Console.WriteLine("FLT : PI + bigNum = {0}", fltPiVal + fltBigNum);
 
            // Other Data Types
            // byte : 8-bit unsigned int 0 to 255
            // char : 16-bit unicode character
            // sbyte : 8-bit signed int 128 to 127
            // short : 16-bit signed int -32,768 to 32,767
            // uint : 32-bit unsigned int 0 to 4,294,967,295
            // ulong : 64-bit unsigned int 0 to 18,446,744,073,709,551,615
            // ushort : 16-bit unsigned int 0 to 65,535
 
            // Da pra converter para string com parse
            bool boolFromStr = bool.Parse("True");
            int intFromStr = int.Parse("100");
            double dblFromStr = double.Parse("1.234");
			
			
			
						
			Console.WriteLine();
			Console.WriteLine("------------------Datatime Timespan--------------------");
			Console.WriteLine();
			
			
			DateTime algumDia = new DateTime(2010, 07, 21); // define uma data
			
			Console.WriteLine("Dia da Semana: {0}", algumDia.DayOfWeek);//retorna o dia da semana
			
			algumDia = algumDia.AddDays(4);//adiciona dias(4)
			Console.WriteLine("Mudança 1: {0}", algumDia);
			algumDia = algumDia.AddMonths(1);//adiciona meses(1)
			Console.WriteLine("Mudança 2: {0}", algumDia);
			algumDia = algumDia.AddYears(1);//adiciona anos(1)
			Console.WriteLine("Mudança 3: {0}", algumDia);
			
			TimeSpan almoco = new TimeSpan(12, 30 , 0);//cria uma hora
			Console.WriteLine("Horario de Almoço : {0}", almoco);
			almoco = almoco.Subtract(new TimeSpan(0, 15, 0));//tira 5 min
			Console.WriteLine("Horario de Almoço : {0}", almoco);
			almoco = almoco.Add(new TimeSpan(1, 0, 0));//add 1 hora
			Console.WriteLine("Horario de Almoço : {0}", almoco);
			
			
			Console.WriteLine();
			Console.WriteLine("----------Big Integer(Precisa do System.Numerics)----------------");
			Console.WriteLine();
			
			BigInteger GrandeInt = BigInteger.Parse("12345123451234512345");//um numero muito grande
			Console.WriteLine("GrandeInt * 2 = {0}", GrandeInt * 2);//a multiplicação dele por 2
			
			Console.WriteLine();
			Console.WriteLine("-------------------Formatando o OutPut---------------------------");
			Console.WriteLine();
			//os numeros são a quantia
			Console.WriteLine("Grana : {0:c}", 23.455);
			Console.WriteLine("0s no Inicio : {0:d4}", 23);
			Console.WriteLine("3 Decimais : {0:f3}", 23.4555);
			Console.WriteLine("Virgula : {0:n4}", 2300);
			
			Console.WriteLine();
			Console.WriteLine("---------------------------Strings------------------------------");
			Console.WriteLine();
			
			String randString = "Alguma coisa";
			
			Console.WriteLine("Comprimento da String : {0}", randString.Length);
			Console.WriteLine("Contem \"co\" em algum lugar : {0}", randString.Contains("co"));
			Console.WriteLine("Index de \"Al\" {0}", randString.IndexOf("Al"));
			Console.WriteLine("Remover Sring : {0}", randString.Remove(0, 5));
			Console.WriteLine("Inserir String : {0}", randString.Insert(10, "Teste"));
			Console.WriteLine("Substitui String : {0}", randString.Replace("coisa", "outra coisa"));
			
			Console.WriteLine("Compara A com B: {0}", String.Compare("A", "B", StringComparison.OrdinalIgnoreCase));
			Console.WriteLine("A = a: {0}", String.Equals("A", "a", StringComparison.OrdinalIgnoreCase));
			Console.WriteLine("Pontos Left: {0}", randString.PadLeft(20, '.'));//o numero representa a quantia
			Console.WriteLine("Pontos Right: {0}", randString.PadRight(20, '.'));//o numero representa a quantia 
			Console.WriteLine("Trim: {0}", randString.Trim());
			Console.WriteLine("CAIXA ALTA: {0}", randString.ToUpper());
			Console.WriteLine("caixa baixa: {0}", randString.ToLower());
			
			String novaString = String.Format("{0} saw a {1} {2} in the {3}",
                							"Paul", "rabbit", "eating", "field");//.format, concatena strings
			Console.WriteLine(novaString + "\n");//pode-se concatenar strings com um +
			Console.WriteLine(@"Exactly What I Typed");
			
			Console.ReadLine();//Lê uma nova linha para fechar o .exe
		}
		
		private static void sayHello(){
			string name="";//variavel nome
			Console.Write("Qual o seu nome: ");//texto de apresentação
			name = Console.ReadLine();//recebe valor inserido
			Console.WriteLine("Olá {0}", name);//escreve o nome
		}
		
		
	}
}