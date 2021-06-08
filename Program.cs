using System;

namespace P7_StringsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string value1 = "hola";

            // "hola" -> "HOLA"
            Console.WriteLine($"\"{value1}\" -> \"{value1.ToUpper()}\"");

            Console.WriteLine("");
            Console.WriteLine("-------");
            Console.WriteLine("");

            // “John, Peter, Charlie” -> [“John”, “Peter”, Charlie”]
            value1 = "John, Peter, Charlie";

            Console.Write(value1 + " -> ");
            
            string[] stringsArray = value1.Split(", ");

            int contador = stringsArray.Length;

            foreach(string value in stringsArray)
            {

                if (contador == stringsArray.Length)
                {
                    Console.Write($"[\"{value}\", ");
                    contador = contador -1;
                }
                else if (contador == 1)
                {
                    Console.Write($"\"{value}\"]");
                }
                else 
                {
                    Console.Write($"\"{value}\", ");

                    contador = contador - 1;
                }                
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("-------");
            Console.WriteLine("");

            // "Pizza" -> "azziP"

            value1 = "Pizza";

            Console.Write($"{value1} -> ");

            char[] charArray = value1.ToCharArray();
            Array.Reverse(charArray);

            Console.WriteLine(charArray);

            Console.WriteLine("");
            Console.WriteLine("---------");
            Console.WriteLine("");

            // "Tacos > Hamburguesa" -> "Tacos &gt; Hamburguesa"

            value1 = "Tacos > Hamburguesa";
            

            Console.Write($"\"{value1}\" -> ");

            string value2 = value1.Replace("Tacos >","Tacos &gt;");

            Console.WriteLine($"\"{value2}\"");

            Console.WriteLine("");
            Console.WriteLine("---------");
            Console.WriteLine("");

            // "Pizza < Hamburguesa" -> "Pizza &lt; Hamburguesa"

            value1 = "Pizza < Hamburguesa";
            value2 = value1.Replace("Pizza <","Pizza &lt;");

            Console.WriteLine($"\"{value1}\" -> \"{value2}\"");

            Console.WriteLine("");
            Console.WriteLine("---------");
            Console.WriteLine("");

            // "Azul, Verde, Morado" -> "Morado"

            value1 = "Azul, Verde, Morado";

            string substring1 = value1.Substring(value1.IndexOf("M"),6);

            Console.WriteLine($"\"{value1}\" -> \"{substring1}\"");
            
            Console.WriteLine("");
            Console.WriteLine("---------");
            Console.WriteLine("");

            // " ave, banco, comida, duda, ejercicio, fuente, girasol" -> FUENTE;EJERCICIO;DUDA;COMIDA;BANCO

            value1 = " ave, banco, comida, duda, ejercicio, fuente, girasol";

            // value2 = value1.Replace(value1,"FUENTE;EJERCICIO;DUDA;COMIDA;BANCO");

            value2 = value1.Substring(value1.IndexOf("banco"),value1.LastIndexOf("l") - 14);

            // value2 = banco, comida, duda, ejercicio, fuente

            stringsArray = value2.Split(", ");  

            Array.Reverse(stringsArray);

            value2 = String.Join(";",stringsArray);
        
            Console.WriteLine($"\"{value1}\" -> {value2.ToUpper()}");

            Console.WriteLine("");
            Console.WriteLine("--------");

        }
    }
}
