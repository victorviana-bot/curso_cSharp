using System.Globalization;

namespace CursoCSharpUdemy_Secao04_Aulas {
    class Produto02 {

        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto02() {
            Quantidade = 10;
            }

        public Produto02(string nome, double preco) : this() {
            Nome = nome;
            Preco = preco;
            }

        public Produto02(string nome, double preco, int quantidade) : this (nome, preco) {
            Quantidade = quantidade;
            }

        /*public Produto02(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            }

        public Produto02(string nome, double preco) {
            Nome = nome;
            Preco = preco;
            Quantidade = 8;
            }*/

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
            }

        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
            }

        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
            }

        public override string ToString() {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
            }

        }
    }
