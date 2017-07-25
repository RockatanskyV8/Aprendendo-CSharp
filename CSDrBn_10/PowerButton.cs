/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 23/07/2017
 * Time: 15:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CSDrBn_10
{
	/// <summary>
	/// Description of PowerButton.
	/// </summary>
	class PowerButton : IComando
	{
		IEletronico device;
		
		public PowerButton(IEletronico device)
		{
			this.device = device;
		}
		
		public void Executar(){
			device.Ligado();
		}
		
		public void Desfazer(){
			device.Desligado();
		}
	}
}
