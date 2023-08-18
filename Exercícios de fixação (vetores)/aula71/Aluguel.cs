using System;

namespace aula71
{
    class Aluguel
    {
        public string Nome { get; set; }
        public string Email { get; set;}
        public int Quarto { get; set;}

        public override string ToString()
        {
            return $"{Quarto}: {Nome}, {Email}";
        }
    }
}
