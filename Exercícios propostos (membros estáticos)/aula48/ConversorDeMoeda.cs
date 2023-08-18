using System;

namespace aula48
{
    class ConversorDeMoeda
    {
        public static double Iof = 0.06;
        public static double Real(double cotacao, double quantidade)
        {
            return quantidade * cotacao + (cotacao * quantidade) * Iof;
        }
    }
}
   