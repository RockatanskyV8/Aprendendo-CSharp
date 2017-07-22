/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 21/07/2017
 * Time: 20:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CSDrBn_8
{
	/// <summary>
	/// Description of Battle.
	/// </summary>
	public class Battle
	{
		
		public static void StartFight(Warrior warrior1, Warrior warrior2){
			while(true){
				if(GetAttackResult(warrior1, warrior2) == "Game Over"){
					Console.WriteLine("Game Over");
					break;
				}
				
				if(GetAttackResult(warrior2, warrior1) == "Game Over"){
					Console.WriteLine("Game Over");
					break;
				}				
			}
		}
		
		public static string GetAttackResult(Warrior warriorA, Warrior warriorB){
			double WarAttk = warriorA.Attack();
			double WarBlck = warriorB.Block();
			
			double dmg2WarB = WarAttk - WarBlck;
			
			if(dmg2WarB > 0){
				warriorB.Vida = warriorB.Vida - dmg2WarB;
			} else dmg2WarB = 0;
			
			Console.WriteLine("{0} Ataca {1} e causa {2} de Dano\n",
                warriorA.Nome,
                warriorB.Nome,
                dmg2WarB);
			
			Console.WriteLine("{0} Tem {1} de vida\n",
                warriorB.Nome,
                warriorB.Vida
               );
			
			if(warriorB.Vida <= 0){
				Console.WriteLine("{0} Foi derrotado {1} Venceu\n",
                    warriorB.Nome,
                    warriorA.Nome);
				
				return "Game Over";
			} else return "Lutem de novo";
		}
	}
}
