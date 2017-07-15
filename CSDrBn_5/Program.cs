/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 15/07/2017
 * Time: 13:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CSDrBn_5
{
	class Program
	{
		public static void Main(string[] args)
		{
			Retangulo rect1;//Cria o objeto
			
			rect1.base1 = 20;//define os valores para o objeto
			rect1.altura1 = 50;
			
			Console.WriteLine("Area de rect1 : {0}", rect1.Area());
			
			Retangulo rect2 = new Retangulo(100, 40);//usa o construtor para fazer o retangulo
			
			rect2 = rect1;//assim os valores estão sendo setados, e não um referencia sendo criada
			
			rect1.base1 = 33;
			
			Console.WriteLine("Base rect2 : {0}", rect2.base1);
			
			Console.WriteLine();
			Console.WriteLine("-------------------------ORIENTAÇÃO OBJETOS----------------------------");
			Console.WriteLine();
			
			Animal Fox = new Animal()
			{
				nome = "red",
				som = "Raaaw"
					
			};//os atributos podem ser setados assim ou, fox.name = (...)
				
			
			Console.WriteLine("Quantos animais? : {0}", Animal.retornaNumAnimais());
			
			Console.WriteLine("Area de um retângulo: {0}", ShapeMath.getArea("Retangulo", 5, 6));
			
			Console.WriteLine();
			Console.WriteLine("-------------------------Tipos Anuláveis----------------------------");
			Console.WriteLine();
			
			//o valor nulo é necessário quando se está trabalhando com bancos de dados
			//pode-se atribuir um valor nulo acrescentando ? após o datatype
			
			int? randNum = null;
			
			if(randNum == null){
				Console.WriteLine("randNum = nulo");
			}
			
			if(!randNum.HasValue){
				Console.WriteLine("randNum ainda = nulo");
			}
			
			Console.Write("Qualquer tecla fecha . . . ");
			Console.ReadKey(true);
		}
		
		//um tipo datatype pelo usuário que contem metodos e parametros
		struct Retangulo{
			public double base1;
			public double altura1;
			//um metodo construtor pode setar os valores que você definir
			public Retangulo(double b=1, double a=1)
			{
				base1 = b;
				altura1 = a;
			}
			
			public double Area(){
				return base1 * altura1;
			}
		}
	}
}