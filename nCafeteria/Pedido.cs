using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nCafeteria
{
    internal class Pedido
    {
        //public int MyProperty { get; set; }

        private string nome = "";
        private double precoTotal;
        private DateTime data;
        private string fPagamento = "";
        private string acucar;

        private bool expresso;
        private bool cleite;
        private bool cappuccino;
        private bool misto;
        private bool croissant;
        private bool empada;
        private bool maca;
        private bool laranja;
        private bool morango;
        private bool bolo;
        private bool brigadeiro;
        private bool cocada;
        private bool suco;
        private bool refri;
        private bool agua;
        private bool dinheiro;
        private bool debito;
        private bool credito;

        public string Nome { get => nome; set => nome = value; }
        public double PrecoTotal { get => precoTotal; set => precoTotal = value; }
        public DateTime Data { get => data; set => data = value; }
        public string FPagamento { get => fPagamento; set => fPagamento = value; }
        public bool Expresso { get => expresso; set => expresso = value; }
        public bool Cleite { get => cleite; set => cleite = value; }
        public bool Cappuccino { get => cappuccino; set => cappuccino = value; }
        public bool Misto { get => misto; set => misto = value; }
        public bool Croissant { get => croissant; set => croissant = value; }
        public bool Empada { get => empada; set => empada = value; }
        public bool Maca { get => maca; set => maca = value; }
        public bool Laranja { get => laranja; set => laranja = value; }
        public bool Morango { get => morango; set => morango = value; }
        public bool Bolo { get => bolo; set => bolo = value; }
        public bool Brigadeiro { get => brigadeiro; set => brigadeiro = value; }
        public bool Cocada { get => cocada; set => cocada = value; }
        public bool Suco { get => suco; set => suco = value; }
        public bool Refri { get => refri; set => refri = value; }
        public bool Agua { get => agua; set => agua = value; }
        public bool Dinheiro { get => dinheiro; set => dinheiro = value; }
        public bool Debito { get => debito; set => debito = value; }
        public bool Credito { get => credito; set => credito = value; }
        public string Acucar { get => acucar; set => acucar = value; }

        public Pedido(string n)
        {
            Nome = n;
        }


        public string mostra()
        {
            string msg = "";

            msg += Expresso == true ? "| Café Expresso " : "";
            msg += Cleite == true ? "| Café com Leite " : "";
            msg += Cappuccino == true ? "| Cappuccino " : "";

            msg += Misto == true ? "| Misto Quente " : "";
            msg += Croissant == true ? "| Croissant " : "";
            msg += Empada == true ? "| Empada " : "";

            msg += Maca || Laranja || Morango == true ? "| Sua Salada de Fruta contém: " : "";

            msg += Maca == true ? "Maçã, " : "";
            msg += Laranja == true ? "Laranja, " : "";
            msg += Morango == true ? "Morango, " : "";

            msg += Bolo == true ? "| Bolo " : "";
            msg += Brigadeiro == true ? "| Brigadeiro " : "";
            msg += Cocada == true ? "| Cocada " : "";

            msg += Suco == true ? "| Suco " : "";
            msg += Refri == true ? "| Refri " : "";
            msg += Agua == true ? "| Agua " : "";

            msg += "\n\nValor total do pedido: R$ " + precoTotal;
            return msg;
        }

        public string pedido()
        {
            string msg = "";

            msg += Expresso == true ? "| Café Expresso " : "";
            msg += Cleite == true ? "| Café com Leite " : "";
            msg += Cappuccino == true ? "| Cappuccino " : "";

            msg += Misto == true ? "| Misto Quente " : "";
            msg += Croissant == true ? "| Croissant " : "";
            msg += Empada == true ? "| Empada " : "";

            msg += Maca || Laranja || Morango == true ? "| Sua Salada de Fruta contém: " : "";

            msg += Maca == true ? "Maçã " : "";
            msg += Laranja == true ? "Laranja " : "";
            msg += Morango == true ? "Morango " : "";

            msg += Bolo == true ? "| Bolo " : "";
            msg += Brigadeiro == true ? "| Brigadeiro " : "";
            msg += Cocada == true ? "| Cocada " : "";

            msg += Suco == true ? "| Suco " : "";
            msg += Refri == true ? "| Refri " : "";
            msg += Agua == true ? "| Agua " : "";

            return msg;
        }
    }
}
