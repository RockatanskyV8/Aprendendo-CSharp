/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 23/07/2017
 * Time: 00:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CSDrBn_10
{
	/// <summary>
	/// Description of IEletronico.
	/// </summary>
	interface IEletronico
	{
        void Ligado();
        void Desligado();
        void VolumeMais();
        void VolumeMenos();
	}
}
