using System;

namespace VariaveisII
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tipos de dados
            /*
             * inteiro -> 1, 2, 3
             * ponto flutuante -> double 1.55, 1.90, -2000.2
             * texto -> string "escrevendo"
             * lógica -> bool true ou false
            */

            int numero = 1;// atribuindo um valor
            int x = 1 + 1;// atribuindo uma expressão

            double d = 1.1 + 5.50;

            Console.WriteLine(d);

            // int - números inteiros
            // double - números de ponto flutuante. Usa mais memória que float
            // float - função parecida com o double. Diferença está na capacidade de armazenamento de cada um

            float f = 1.2f;

            long l;// Usado para números inteiros grandes

            byte b;// 0 até 255. Armazena números também
        }
    }
}
