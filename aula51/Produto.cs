using System.Globalization;

namespace Course
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade;
    
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set 
            {
                if (value != null && value.Length > 1) 
                {
                    _nome = value;
                }
            }
        }
    }
}
