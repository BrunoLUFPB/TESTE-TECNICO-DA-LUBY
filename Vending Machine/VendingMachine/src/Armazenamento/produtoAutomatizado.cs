namespace Repositorio {
    public class ProdutoAutomatizado {
        public int CodigoUnico { get; private set; }
        public string NomeProduto { get; private set; }
        public double PrecoProduto { get; private set; }
        public int QuantidadeDisponivel { get; private set; }

        private static int geradorCodigo = 100;

        public ProdutoAutomatizado(string nomeProduto, double precoProduto, int quantidade) {
            CodigoUnico = geradorCodigo++;
            NomeProduto = nomeProduto;
            PrecoProduto = precoProduto;
            QuantidadeDisponivel = quantidade;
        }

        public void VenderItem() {
            if (QuantidadeDisponivel > 0) {
                QuantidadeDisponivel--;
            }
            else {
                Console.WriteLine("Produto fora de estoque.");
            }
        }

        public void ReporProduto(int quantidade) {
            QuantidadeDisponivel += quantidade;
        }
    }
}
