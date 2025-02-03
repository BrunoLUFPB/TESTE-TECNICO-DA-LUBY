using System.Collections.Generic;

namespace Repositorio {
    public static class HistoricoDeVendasRepo {
        private static double totalVendido = 0;
        private static List<string> historicoVendas = new List<string>();

        public static void RegistrarNovaVenda(ProdutoAutomatizado produto) {
            totalVendido += produto.PrecoProduto;
            historicoVendas.Add($"Produto vendido: {produto.NomeProduto} por R$ {produto.PrecoProduto:F2}");
        }

        public static double ObterTotalDeVendas() {
            return totalVendido;
        }

        public static void MostrarHistoricoDeVendas() {
            Console.WriteLine("\nHistórico de Vendas:");
            foreach (var registro in historicoVendas) {
                Console.WriteLine(registro);
            }
            if (historicoVendas.Count == 0) {
                Console.WriteLine("Nenhuma venda realizada até o momento.");
            }
        }
    }
}
