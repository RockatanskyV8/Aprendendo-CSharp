/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 23/07/2017
 * Time: 23:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;//necessário para o Arraylist
using System.Collections.Generic;//necessário para Dicionarios

namespace CSDrBn_11
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine();
			Console.WriteLine("---------------ARRAY LIST-------------------------");
			Console.WriteLine();
			
			#region Arraylist
			ArrayList listaDeArrays = new ArrayList();
			
			listaDeArrays.Add("Alguém");
			listaDeArrays.Add(50);
			
			Console.WriteLine("Contar : {0}", listaDeArrays.Count);
			Console.WriteLine("Capacidade : {0}", listaDeArrays.Capacity);
			
			ArrayList listaDeArrays2 = new ArrayList();
			
			listaDeArrays2.AddRange(new object [] {"Mike", "Sally", "Egg"});
			
			listaDeArrays.AddRange(listaDeArrays2);
			
			listaDeArrays2.Sort();
			listaDeArrays2.Reverse();
			
/*
            // Remove the first item
            aList2.RemoveAt(0);
 
            // Remove the 1st 2 items
            aList2.RemoveRange(0, 2);
            */
			
			listaDeArrays2.Insert(1, "Turkey");
			
			ArrayList Range = listaDeArrays2.GetRange(0, 2);
			
			Console.WriteLine("Turkey Index: {0}", listaDeArrays2.IndexOf("Turkey", 0));
			
			foreach(object o in Range){
				Console.WriteLine(o);
			}
			
			string [] myArray = (string[])listaDeArrays2.ToArray(typeof(string));
			
			string[] customers = { "Bob", "Sally", "Sue" };
			ArrayList custArray = new ArrayList();
			custArray.AddRange(customers);
			
			#endregion
			
			Console.WriteLine();
			Console.WriteLine("---------------DICIONÁRIO-------------------------");
			Console.WriteLine();
			
			#region Dicionario
			
			Dictionary<string, string> superHerois = new Dictionary<string, string>();
			
			superHerois.Add("Clark Kent", "Superman");
			superHerois.Add("Bruce Wayne", "Batman");
			superHerois.Add("Barry West", "Flash");
			
			superHerois.Remove("Barry West");
			
			Console.WriteLine("Contar : {0}", superHerois.Count);
			Console.WriteLine("Clark Kent : {0}", superHerois.ContainsKey("Clark Kent"));
			
			string test;
			
			superHerois.TryGetValue("Clark Kent", out test);
			
			Console.WriteLine("Clark Kent Teste: {0}", test);
			
			foreach(KeyValuePair<string, string> item in superHerois){
				Console.WriteLine("{0} : {1}", item.Key, item.Value);
			}
			
			superHerois.Clear();
			
			#endregion
			
			Console.WriteLine();
			Console.WriteLine("---------------Queue (fila)-----------------------");
			Console.WriteLine();
			
			#region Queue (fila)
			
			Queue fila = new Queue();
			
			fila.Enqueue(1);
			fila.Enqueue(2);
			fila.Enqueue(3);
			
			Console.WriteLine("1 na fila: {0}", fila.Contains(1));
			Console.WriteLine("Remove 1: {0}", fila.Dequeue());
			Console.WriteLine("Peek: {0}", fila.Peek());
			
			object[] numArray = fila.ToArray();
			
			Console.WriteLine(string.Join(", ", numArray));
			
			foreach(object o in fila){
				Console.WriteLine("Queue : {0}", o);
			}
			
			fila.Clear();
			
			#endregion
			
			Console.WriteLine();
			Console.WriteLine("---------------Queue (pilha)-----------------------");
			Console.WriteLine();			
			
			#region Queue (pilha)
			
			Stack pilha = new Stack();
			
			pilha.Push(1);
			pilha.Push(2);
			pilha.Push(3);
			
			Console.WriteLine("Peek 1: {0}", pilha.Peek());
			Console.WriteLine("Pop 1: {0}", pilha.Pop());
			Console.WriteLine("Contain 1: {0}", pilha.Contains(1));
			
			object [] numArray2 = pilha.ToArray();
			
			Console.WriteLine(string.Join(", ", numArray2));
			
			foreach(object o in pilha){
				Console.WriteLine("Stack: {0}", o);
			}
			
			#endregion
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}