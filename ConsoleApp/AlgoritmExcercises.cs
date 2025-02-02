using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace ConsoleApp
{
    public class AlgoritmExcercises
    {
 
        static void Main(string[] args)
        {
            Palindrome();
            //Fibonacci();
            //ReverseString();
            //Factorial();
            //FizzBuzz();
        }

        static void Palindrome()
        {
            Console.WriteLine("Write a sentence...");
            var sentence = Console.ReadLine();
            bool result = IsPalindrome(sentence);

            Console.WriteLine($"Sentence {result}");
        }

        static bool IsPalindrome(string sentence)
        {
            if (string.IsNullOrEmpty(sentence))
            {
                Console.WriteLine("empty sentence"); return false;
            }

            var original = sentence.Replace(" ", "").Trim().ToLower();
            var reverse = Reverse(sentence); 

            var result = Equals(original, reverse);

            if (result)
            {
                return true;
            }

            return false;
        }

        static void Fibonacci()
        {
            Console.WriteLine("Write a number...");

            int.TryParse(Console.ReadLine(), out int number); 
            var result = CalculateFibonacci(number);
            Console.WriteLine($"Fibonacci: {result}");
        }

        public static int CalculateFibonacci(int n)
        {

            /*
            a = 0, b = 1
            Paso 1: a = 1, b = 1
            Paso 2: a = 1, b = 2
            Paso 3: a = 2, b = 3
            Paso 4: a = 3, b = 5
            Paso 5: a = 5, b = 8  ← Resultado final
             */

            int a = 0;
            int b = 1;
            int result = 0;

            if (n == 0)
            {
                return 0;
            }
            else if (n == 1) {
                return 1;
            } else
            {
                for (int i = 1; i < n; i++)
                {
                    result = a + b;
                    a = b;
                    b = result;
                }   
                return result;
            }
        }

        static void ReverseString()
        {
            /*
            Escribir una función que reciba una cadena de texto y devuelva la misma cadena pero invertida.
            Entrada:  "hola"
            Salida:   "aloh"
            */

            Console.WriteLine("Write something...");
            string word = Console.ReadLine(); 
            string reverseWord = Reverse(word);
            Console.WriteLine(reverseWord);
        }

        public static string Reverse(string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            var chars = str.ToCharArray();
            Array.Reverse(chars);
            return new string(chars).ToLower();
        }

        static void Factorial()
        {
            /*
            5! = 5 × 4 × 3 × 2 × 1 = 120
            3! = 3 × 2 × 1 = 6
            0! = 1 (por definición)
            ✅ Requisitos:

            Escribir una función en C# que reciba un número entero n y retorne n!.
            Manejar el caso n = 0.
            Implementarlo de forma Recursiva (llamando a la misma función).
            formula -> n!=n×(n−1)!
            */

            Console.WriteLine("Insert number");
            
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                var result = CalculateFactorial(number);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Bad insert");
            }
        }

        static int CalculateFactorial(int number)
        {
            if(number == 0)  {
                return 1;
            }
            var factorial = CalculateFactorial(number - 1);
            return number * factorial;
        }

        static void FizzBuzz()
        {
            /*
              📌 Requisitos:
                 Imprimir números del 1 al 100.
                 Si el número es múltiplo de 3, imprimir "Fizz".
                 Si el número es múltiplo de 5, imprimir "Buzz".
                 Si el número es múltiplo de 3 y 5, imprimir "FizzBuzz".
                 En caso contrario, imprimir el número.
            */
            Console.WriteLine("hello!");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
