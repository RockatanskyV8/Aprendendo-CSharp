/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 15/07/2017
 * Time: 14:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CSDrBn_5
{
	/// <summary>
	/// Description of ShapeMath.
	/// </summary>
	public static class ShapeMath//esta classe só conterá funções estáticas
	{
		public static double getArea(string figura = "", double base1 = 0.0, double altura = 0.0){
			if(
				String.Equals("Retangulo", figura, StringComparison.OrdinalIgnoreCase)
			){
				return base1 * altura;
			}else if(
				String.Equals("Triangulo", figura, StringComparison.OrdinalIgnoreCase)
			){
				return base1 * (altura / 2);
			}else if(
				String.Equals("Circulo", figura, StringComparison.OrdinalIgnoreCase)
			){
				return 3.14159 * Math.Pow(base1, 2);
			}else{
				return - 1;
			}
		}
	}
}
