/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 23/07/2017
 * Time: 00:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CSDrBn_10
{
	/// <summary>
	/// Description of IComando.
	/// </summary>
	interface IComando
	{
		void Executar();
		void Desfazer();
	}
}
