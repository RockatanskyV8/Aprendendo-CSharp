/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 23/07/2017
 * Time: 16:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CSDrBn_10
{
	/// <summary>
	/// Description of ControleTV.
	/// </summary>
	class ControleTV
	{
		public static IEletronico GetDevice()
		{
			return (new Televisao());
		}
	}
}
