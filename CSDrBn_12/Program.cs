/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 26/07/2017
 * Time: 20:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace CSDrBn_12
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			List <Animal> animalList = new List<Animal>();
			List <int> listaDeNumeros = new List<int>();
			
			listaDeNumeros.Add(24);
			
			animalList.Add(new Animal() { Nome = "Doug" });
            animalList.Add(new Animal() { Nome = "Paul" });
            animalList.Add(new Animal() { Nome = "Sally" });
            animalList.Insert(1, new Animal() { Nome = "Steve" });
            
            animalList.RemoveAt(1);
            
            Console.WriteLine("Numero de animais : {0}", animalList.Count());
            
            foreach(Animal a in animalList){
            	Console.WriteLine(a.Nome);
            }
            
            int x = 5, y = 4;
            Animal.GetSum<int>(ref x, ref y);
            
            string strX = "5", strY = "4";
            Animal.GetSum(ref strX, ref strY);
			// TODO: Implement Functionality Here
			
			Retangulo<int> ret1 = new Retangulo<int>(20, 50);
			Console.WriteLine(ret1.getArea());
			
			Retangulo<string> ret2 = new Retangulo<string>("20", "50");
			Console.WriteLine(ret2.getArea());
			
			Aritmetico add, sub, addSub;
			
			add = new Aritmetico(Add);
			
			sub = new Aritmetico(Subtract);
			
			addSub = add + sub;
			
			Console.Write("ADD ");
			add(6, 10);
			
			Console.Write("ADDSUB ");
			addSub(6, 10);
			
			Console.Write("Qualquer tecla fecha . . . ");
			Console.ReadKey(true);
			
		}
		
		public struct Retangulo<T>
		{
			private T lado;
			private T altura;
			
			public T Lado
			{
				set{lado = value;}
				get{return lado;}
			}
			
			public T Altura
			{
				set{altura = value;}
				get{return altura;}				
			}
			
			public Retangulo(T l, T a){
				lado = l;
				altura = a;
			}
			
			public string getArea(){
               	double dblLado = Convert.ToDouble(lado);
               	double dblAltura = Convert.ToDouble(altura);
               	return string.Format("{0} * {1} = {2}", dblLado, dblAltura, (dblLado * dblAltura));
			}
		}
		
		public delegate void Aritmetico(double num1, double num2);
		
		public static void Add(double num1, double num2)
        {
			Console.WriteLine("{0} + {1} = {2}", num1, num2, (num1 + num2));
        }
		
		public static void Subtract(double num1, double num2)
        {
            Console.WriteLine("{0} - {1} = {2}", num1, num2, (num1 + num2));
        }
 
	}
}