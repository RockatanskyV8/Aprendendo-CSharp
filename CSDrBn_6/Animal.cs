/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 17/07/2017
 * Time: 23:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDrBn_6
{
	/// <summary>
	/// Description of Animal.
	/// </summary>
	public class Animal
	{
		private string nome;
		private string som;
		
		public const string Abrigo = "SHELTER NUM 1";
		
		public readonly int idNum;
		
		public void fazSom(){
			Console.WriteLine("{0} says {1}\n", nome, som);
		}
		
		public Animal():this("Sem Nome","Não faz Som"){}
		
		public Animal(String nome):this(nome,"Não faz Som"){}
		
		public Animal(String nome, String som)
		{
			SetNome(nome);
			
			Som = som;
			
			numDeAnimais = 1;
			
			Random id = new Random();
			idNum=id.Next(1, 2147483640);
			
		}
		
		public void SetNome(string nome){
			if(!nome.Any(char.IsDigit)){
				this.nome = nome;
			}else{
				this.nome = "sem nome";
				Console.WriteLine("Nome não pode conter números\n");
			}
		}
		
		public string getNome(){
			return nome;
		}
		
		public string Som
		{
			get{return som;}
			set{
				if(value.Length > 15){
					som = "sem som";
					Console.Write("Nenhum animal faz este som\n");
				} else{
					som = value;
				}
			}
		}
		
		//public string Owner { get; set; } = "No Owner"; só funciona a partir do c# 4.6 ou 6.0
		
		public static int numDeAnimais = 0;
		public static int NumDeAnimais{
			get{return numDeAnimais;}
			set{numDeAnimais += value;}
		}
	}
}
