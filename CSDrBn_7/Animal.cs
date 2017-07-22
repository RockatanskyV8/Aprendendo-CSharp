/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 18/07/2017
 * Time: 19:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDrBn_7
{
	/// <summary>
	/// Description of Animal.
	/// </summary>
	public class Animal
	{
		private string nome;
		protected string som;//protected pode ser alterado por uma subclasse
		
		protected AnimalIDInfo animalIDInfo = new AnimalIDInfo();
		
		public void SetAnimalIDInfo(int idNum, string dono){
			animalIDInfo.IDnum = idNum;
			animalIDInfo.nomeDono = dono;
		}
		
		public void GetAnimalIDInfo(){
			Console.WriteLine("{0} has the ID of {1} and is owned by {2}", nome, animalIDInfo.IDnum, animalIDInfo.nomeDono);
		}
		
		public virtual void FazSom(){
			Console.WriteLine("{0} faz {1}", Nome, Som);
		}
		
		public Animal():this("Sem Nome","Sem Som")
		{
		}
		
		public Animal(string nome):this(nome,"Sem Som")
		{
		}
		
		public Animal(string nome, string som)
		{
			Nome = nome;
			Som = som;
		}
		
		public string Nome{
			get{return nome;}
			set{
				if(value.Any(char.IsDigit)){
					nome = "Sem Nome";
				} else{
					nome = value;
				}
			}
		}
		
		public string Som{
			get{return som;}
			set{som = value;}
		}
		
		public class AnimalHeath{
			public bool HealthWeight(double height, double weight){
				double calc = height/weight;
				
				if((calc >= .18) && (calc <= .27)){
					return true;
				} else return false;
			}
		}
	}
}
