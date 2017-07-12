/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 11/07/2017
 * Time: 12:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

using System.Text;
using System.Globalization;

namespace CSDrBn_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			var intVal = 1234;
			
			Console.WriteLine("Tipo da intVal : {0}", intVal.GetType());
			
			Console.WriteLine();
			Console.WriteLine("---------------------------ARRAY------------------------------");
			Console.WriteLine();
			
			int [] randNums = new int[3];
			
			randNums[0] = 23;
			
			Console.WriteLine("Randomicos 0 : {0}", randNums[0]);
			//esse é bem autoexplicativo
			string [] pessoas = { "Bob", "Sally", "Sue" };
			//strings criados em var tem que ter componentes do mesmo tipo
			var funcionarios = new[] {"Mike", "Paul", "Rick"};
			//pode-se criar um array de objetos, que cada componente será um objeto
			object[] randArray = {"Paul", 45, 1.234};
			
			Console.WriteLine("randArray 0 : {0}", randArray[0].GetType());
			Console.WriteLine("Comprimento 0 : {0}", randArray.Length);
			
			for(int i = 0; i < randArray.Length; i++)
            {
                Console.WriteLine("Posição no vetor {0} : Valor : {1}",
                i, randArray[i]);
            }
			
			int [] otherRandNums = {1, 4, 9, 2};
			
			//função que percorre o array e printa os elementos
			PrintArray(otherRandNums, "Componente de otherRandNums");
			
			Console.WriteLine("4 no index : {0} ", Array.IndexOf(otherRandNums, 4));
			Array.Sort(otherRandNums);//ordena o Array
			Console.WriteLine("4 no index : {0} ", Array.IndexOf(otherRandNums, 4));
			Array.Reverse(otherRandNums);//inverte o Array
			Console.WriteLine("4 no index : {0} ", Array.IndexOf(otherRandNums, 4));
			
			otherRandNums.SetValue(0, 1);
			
			//Copiar PARTE do array para outro
			int[] srcArray = { 1, 2, 3 };
            int[] destArray = new int[2];
			int startInd = 0;
            int length = 2;
            
            Array.Copy(srcArray, startInd, destArray, startInd, length);
            //Array Fonte, Index de inicio, Array Destino, Index de Inicio, comprimento
            
            PrintArray(destArray, "Cópia");
            
            //Cria um array com o CriateInstance
            Array outroArray = Array.CreateInstance(typeof(int), 10);
            
            //Copia os elementos de srcArray para outroArray a partir do elemento 5
            srcArray.CopyTo(outroArray, 5);
            
            foreach (int m in outroArray)
            {
                Console.WriteLine("Copia para : {0} ", m);
            }
            
            //encontra elementos que combinem com a condição fornecida
            int[] numArray = { 1, 11, 22 };
            Console.WriteLine("> 10 : {0}", Array.Find(numArray, GT10));
						
			Console.WriteLine();
			Console.WriteLine("---------------ARRAY MULTIDIMENCIONAL-------------------------");
			Console.WriteLine();
			
			String [,] custNames = new String [2,2]{{"Nome 1", "Nome 2"},{"Nome 3", "Nome 4"}};
			
			Console.WriteLine("Primeiro Valor : {0}", custNames.GetValue(1,1));
			
			for (int i = 0; i < custNames.GetLength(0); i++)
            {
				
                for(int j = 0; j < custNames.GetLength(1); j++)
                {
                    Console.Write("{0} ",custNames[i,j]);
                }
                Console.WriteLine();
            }
			
			Console.WriteLine();
			Console.WriteLine("---------------STRINGBUILDER-------------------------");
			Console.WriteLine();
			
// Each time you change a string you are actually creating a new string which is inefficient
// when you are working with large blocks of text StringBuilders actually change the text
// rather then make a copy
			
			//String builder começãm com 16 bits por default
			StringBuilder sb = new StringBuilder("Texto Aleatorio");
			//Criar uma StringBuilder com 256 bits
			StringBuilder sb2 = new StringBuilder("Algumas coisas bem importantes", 256);
			
            Console.WriteLine("Capacidade : {0}", sb2.Capacity);
 
            Console.WriteLine("Comprimento : {0}", sb2.Length);
 
            // Acrescenta algo a uma StringBuilder
            sb2.AppendLine("\nMais coisas importantes");
            
            // Define formato cultural 
            CultureInfo ptBR = CultureInfo.CreateSpecificCulture("pt-BR");
 
            string funcMes = "Alguém";
            sb2.AppendFormat(ptBR, "Funcionario do Mês : {0}", funcMes);
            
            Console.WriteLine(sb.ToString());//printa sb
            Console.WriteLine(sb2.ToString());//printa sb2
            
            sb2.Replace("coisas", "palavras");//substitui coisas por palavras
            Console.WriteLine(sb2.ToString());
            
            sb2.Clear();//limpa sb2
 
            sb2.Append("Outro texto aleatório");
            
            Console.WriteLine(sb2.ToString());
            
            Console.WriteLine(sb.Equals(sb2));//compara as duas
            
            sb2.Insert(11, " puramente");//acrescenta a partir de determinado indice
			
            Console.WriteLine(sb2.ToString());
            
            sb2.Remove(11, 7);//remove a partir de determinado indice
            
            Console.WriteLine(sb2.ToString());
            
			Console.WriteLine();
			Console.WriteLine("---------------CASTING-------------------------");
			Console.WriteLine();
			//quando vc quer converter de um tipo para outro
			long num1 = 1234;
			int num2 = (int)num1;
			
			Console.WriteLine("Orig : {0} Cast : {1}", num1.GetType(), num2.GetType());
            
			Console.Write("Qualquer tecla fecha . . . ");
			Console.ReadKey(true);
		}
		
		static void PrintArray(int[] intArray, string mess)
        {
            foreach (int k in intArray)
            {
                Console.WriteLine("{0} : {1} ", mess, k);
            }
        }
		
		private static bool GT10(int val)
        {
            return val > 10;
        }
	}
}