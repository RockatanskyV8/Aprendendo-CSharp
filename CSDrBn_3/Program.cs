/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 12/07/2017
 * Time: 22:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CSDrBn_3
{
	class Program
	{
		public static void Main(string[] args)
		{
			int age = 17;
			
			Console.WriteLine();
			Console.WriteLine("------------------CONDICIONAIS--------------------");
			Console.WriteLine();
			
			if((age>=5) && (age<=7)){
				Console.WriteLine("Criança");
			}else if((age>=7) && (age<=13)){
				Console.WriteLine("Criança ou Pré-Adolescente");
			}else if((age>=13) && (age<=19)){
				Console.WriteLine("Adolescente ou adulto");
			}else{
				Console.WriteLine("Provavelmente já pode beber");
			}
			
			Console.WriteLine("! True = " + (!true));
			
			bool canDrive = age >= 16 ? true : false;//atribui uma condicional a uma variavel
			
			Console.WriteLine(canDrive);
			
			switch(age){
				case 16:
					Console.WriteLine("Não pode dirigir");
					break;
				case 18:
					Console.WriteLine("Pode dirigir");
					break;
				case 21:
					Console.WriteLine("Tem que renovar a carteira");
					break;
				default:
					Console.WriteLine("não sei");
					goto Consulta;
					break;
			}
			
			Consulta:
			Console.WriteLine("não sei mesmo");
			
			string Nome = "Kamina";
			string Nome2 = "Kamina";//ou Simon
			
			if(Nome.Equals(Nome2, StringComparison.Ordinal)){//Compara duas Strings
				Console.WriteLine("Nomes iguais");
			} else{
				Console.WriteLine("Nomes diferentes");
			}
			
			Console.WriteLine();
			Console.WriteLine("------------------DO WHILE LOOP--------------------");
			Console.WriteLine();
			
			Random rnd = new Random();
			int numAdivinhar = rnd.Next(1, 11);
			int numAdivinhado = 0;
			
			do{
				Console.Write("Numero entre 1 & 10 : ");
 
                // Use Convert to switch the string into an int
                numAdivinhado = Convert.ToInt32(Console.ReadLine());
			}while(numAdivinhar != numAdivinhado);
			
			Console.WriteLine();
			Console.WriteLine("------------------EXCEPTION HANDLING--------------------");
			Console.WriteLine();
			
			double num1 = 5;
			double num2 = 0;
			
			try {//quando o codigo pode causar erro ele é colocado dentro de um try 
            Console.WriteLine("5 / 0 = {0}", 
                DoDivision(num1, num2));
			}catch(DivideByZeroException ex){//o erro é interceptado
				Console.WriteLine("Não dividirás por zero");//uma mensagem é mandada ao usuário
				Console.WriteLine(ex.GetType().Name);//informação adicional
                Console.WriteLine(ex.Message);
			}
			
			finally
            {
                Console.WriteLine("Cleaning Up");
            }
			
			Console.Write("Qualquer tecla fecha . . . ");
			Console.ReadKey(true);
		}
		
		static double DoDivision(double x, double y)
        {
            if(y == 0)
            {
                // We are throwing an exception because
                // you can't divide by zero
                throw new System.DivideByZeroException();
            }
            return x / y;
        }
	}
}