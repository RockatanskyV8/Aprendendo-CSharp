/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 27/07/2017
 * Time: 22:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace CSDrBn_13
{
	class Program
	{
		delegate double ODobro(double val);
		
		public static void Main(string[] args)
		{
			
			ODobro dbr = x => x * 2;
			Console.WriteLine("5 x 2 = {0}", dbr(5));
			
			List<int> listaNum = new List<int>{1,2,9,6,3};
			
			var listaEvent = listaNum.Where(a => a % 2 == 0).ToList();
			
			foreach(var j in listaEvent)
				Console.WriteLine(j);
			
			var listaRange = listaNum.Where(x => (x > 2) || (x < 9)).ToList();
			
			foreach(var k in listaRange)
				Console.WriteLine(k);
			
			List<int> flipLista = new List<int>();
			int i = 0;
			Random rnd = new Random();
			while(i < 100){
				flipLista.Add(rnd.Next(1, 3));
				i++;
			}
			
			Console.WriteLine("Inicio : {0}", flipLista.Where(a => a == 1).ToList().Count());
			Console.WriteLine("Fim : {0}", flipLista.Where(a => a == 2).ToList().Count());
			
			var nomeLista = new List<string>{"Doug", "Sally", "Sue"};
			
			var sNomeLista = nomeLista.Where(x => x.StartsWith("S"));
			
			foreach(var m in sNomeLista)
				Console.WriteLine(m);
			
			Console.WriteLine();
			Console.WriteLine("----------------------SELECT-------------------------");
			Console.WriteLine();
			
			var oneTo10 = new List<int>();
			
			oneTo10.AddRange(Enumerable.Range(1, 10));
			
			var squares = oneTo10.Select(x => x * x);
			
			foreach(var l in squares)
				Console.WriteLine(l);
			
			Console.WriteLine();
			Console.WriteLine("----------------------ZIP-------------------------");
			Console.WriteLine();
			
			var listaUm = new List<int>(new int [] {1, 3, 4});
			var listaDois = new List<int>(new int [] {4, 6, 8});
			
			var sumList = listaUm.Zip(listaDois, (x, y) => x + y).ToList();
			
			foreach(var n in sumList)
				Console.WriteLine(n);
			
			Console.WriteLine();
			Console.WriteLine("-----------------AGGREGATE------------------------");
			Console.WriteLine();
			
			var numList2 = new List<int>(){1, 2, 3, 4, 5};
			
			Console.WriteLine("Sum : {0}", 
                numList2.Aggregate((a, b) => a + b));
			
			Console.WriteLine();
			Console.WriteLine("-----------------AVERAGE---------------------------");
			Console.WriteLine();
			
			var listaNum3 = new List<int>(){1, 2, 3, 4, 5};
			
			Console.WriteLine("Média: {0}", listaNum3.AsQueryable().Average());
			
			Console.WriteLine();
			Console.WriteLine("----------------------ALL---------------------------");
			Console.WriteLine();
			
			var listaNum4 = new List<int>(){1, 2, 3, 4, 5};
			
			Console.WriteLine("Tudo > 3: {0}", listaNum4.All(x => x > 3));
			
			Console.WriteLine();
			Console.WriteLine("----------------------ANY---------------------------");
			Console.WriteLine();
			
			var listaNum5 = new List<int>(){1, 2, 3, 4, 5};
			
			Console.WriteLine("Qualquer um > 3: {0}", listaNum5.Any(x => x > 3));
			
			Console.WriteLine();
			Console.WriteLine("----------------------DISTINCT----------------------");
			Console.WriteLine();
			
			var listaNum6 = new List<int>(){1, 2, 3, 2, 3};
			
			Console.WriteLine("Distinto : {0}", string.Join(", ", listaNum6.Distinct()));
			
			Console.WriteLine();
			Console.WriteLine("----------------------EXCEPT-----------------------");
			Console.WriteLine();
			
			var listaNum7 = new List<int>(){1, 2, 3, 2, 3};
			var listaNum8 = new List<int>(){ 3 };
			
			Console.WriteLine("Exeto 3: {0}", string.Join(", ", listaNum7.Except(listaNum8)));
			
			Console.WriteLine();
			Console.WriteLine("----------------------INTERSECT---------------------");
			Console.WriteLine();
			
			var listaNum9 = new List<int>(){1, 2, 3, 2, 3};
			var listaNum10 = new List<int>(){ 2, 3 };
			
			Console.WriteLine("Interseção: {0}", string.Join(", ", listaNum9.Intersect(listaNum10)));
			
			Console.Write("Qualquer tecla fecha . . . ");
			Console.ReadKey(true);
		}
	}
}