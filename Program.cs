using System;

namespace senai.operadores.ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region IMC pessoa 1
            Console.WriteLine("Informe a altura da primeira pessoa");
            float alturapessoa1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe seu peso");
            float pesopessoa1 = float.Parse(Console.ReadLine());

            float imcpessoa1 = pesopessoa1 / (alturapessoa1 * alturapessoa1);
            #endregion IMC pessoa 1

            #region IMC pessoa 2
            Console.WriteLine("Informe a altura da segunda pessoa");
            float alturapessoa2 = float.Parse(Console.ReadLine());

            
            Console.WriteLine("Informe seu peso");
            float pesopessoa2 = float.Parse(Console.ReadLine());

            //
            float imcpessoa2 = (float)(pesopessoa1 / Math.Pow(alturapessoa2, 2));
            #endregion IMC pessoa 2

            Console.WriteLine("Pessoa1 1 peso: " + pesopessoa1
            + ", Altura Pessoa 1: " + alturapessoa1 
            + " imc: " + imcpessoa1);

            Console.WriteLine($"Pessoa1 2 peso: { pesopessoa2 }, Altura Pessoa 2: { alturapessoa2 }  imc: { imcpessoa2}");
        }
    }
}
