using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria
{
    internal class Pedido
    {
        private string nome = "";
        private double precoTotal;
        private string data = "";
        private string fPagamento = "";

        public string Nome { get => nome; set => nome = value; }
        public double PrecoTotal { get => precoTotal; set => precoTotal = value; }
        public string Data { get => data; set => data = value; }
        public string FPagamento { get => fPagamento; set => fPagamento = value; }
    }
}
