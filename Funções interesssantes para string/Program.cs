using System;

namespace aula88
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEF    ";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();

            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");

            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);
            string s6 = original.Replace('a', 'x');

            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);  

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("Maiúsculo: -" + s1 + "-");
            Console.WriteLine("Minúsculo: -" + s2 + "-");
            Console.WriteLine("Sem espaços desnecessário: -" + s3 + "-");
            Console.WriteLine("Localização de 'bc': " + n1);
            Console.WriteLine("Última localização de 'bc': " + n2);
            Console.WriteLine("Recortando string à partir do index: -" + s4 + "-");
            Console.WriteLine("Recortando de um valor até outro: -" + s5 + "-");
            Console.WriteLine("Trocando caracter 'a' por 'x': -" + s6 + "-");
            Console.WriteLine("String esta vazia ou não: " + b1);
            Console.WriteLine("String esta vazia ou tem espaço em branco: " + b2);
        }
    }
}
