namespace Servicos
{
    using Repositorio;

    public static class ServicosDeEstoque
    {
        public static bool TemProdutoDisponivel(ProdutoAutomatizado produto)
        {
            if (produto == null)
            {
                Console.WriteLine("Produto não encontrado.");
                return false;
            }
            if (produto.QuantidadeDisponivel <= 0)
            {
                Console.WriteLine("Produto esgotado.");
                return false;
            }
            return true;
        }

        public static void AtualizarEstoqueDepoisVenda(ProdutoAutomatizado produto)
        {
            produto?.VenderItem();
        }
    }
}
