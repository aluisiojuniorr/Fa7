using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fa7Trabalho
{
    class CalcularNota
    {
        #region Exercicio Prova Trabalho Fa7

        static void Main(string[] args)
        {
            double notaAv1;
            double notaAv2;
            double notaFinal;

            Console.Write("Nota AV1: ");
            notaAv1 = double.Parse(Console.ReadLine());
            Console.Write("Nota AV2: ");
            notaAv2 = double.Parse(Console.ReadLine());

            notaFinal = (notaAv1 + notaAv2) / 2;

            if (notaFinal >= 7)
            {
                Console.Write("Aluno Aprovado com Nota: " + notaFinal);

            }
            else
            {
                Console.Write("Aluno Reprovado com Nota: " + notaFinal);
            }
            Console.ReadKey();
        }

        #endregion
    }
}
