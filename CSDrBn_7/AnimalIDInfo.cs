/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 18/07/2017
 * Time: 19:24
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
	/// Description of AnimalIDInfo.
	/// </summary>
	public class AnimalIDInfo
	{
		int IDAnimal = 0;
		string Dono = "Ninguém";
		
		//public int IDNum {get; set;} == 0
		public int IDnum{
			get{return IDAnimal;}
			set{IDAnimal = value;}
		}
		
		public string nomeDono{
			get{return Dono;}
			set{Dono = value;}
		}
	}
}
