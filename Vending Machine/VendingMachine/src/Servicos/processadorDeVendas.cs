using System;

namespace Servicos {
    using Repositorio;

    public static class ProcessadorDeVendas {
        public static void IniciarVenda(ProdutoAutomatizado produtoSelecionado) {
            Console.WriteLine($"\nProduto selecionado: {produtoSelecionado.NomeProduto} - R$ {produtoSelecionado.PrecoProduto:F2}");
            Console.WriteLine("Insira o valor pago:");

            double valorInserido = 0;
            string entradaUsuario = Console.ReadLine();

            if (!double.TryParse(entradaUsuario, out valorInserido)) {
                Console.WriteLine("Valor inválido. Insira um número válido.");
                entradaUsuario = Console.ReadLine();
                double.TryParse(entradaUsuario, out valorInserido);
            }

            while (valorInserido < produtoSelecionado.PrecoProduto) {
                Console.WriteLine($"Valor insuficiente. Faltam R$ {(produtoSelecionado.PrecoProduto - valorInserido):F2}. Insira o valor restante:");
                string maisDinheiro = Console.ReadLine();
                double valorAdicional = 0;

                if (double.TryParse(maisDinheiro, out valorAdicional)) {
                    valorInserido += valorAdicional;
                }
                else {
                    Console.WriteLine("Valor inválido. Insira um número.");
                }
            }

            double troco = valorInserido - produtoSelecionado.PrecoProduto;

            if (troco > 0) {
                Console.WriteLine($"Troco: R$ {troco:F2}");
            }
            else if (troco == 0) {
                Console.WriteLine("Pagamento exato recebido.");
            }

            ServicosDeEstoque.AtualizarEstoqueDepoisVenda(produtoSelecionado);
            HistoricoDeVendasRepo.RegistrarNovaVenda(produtoSelecionado);

            Console.WriteLine("Venda concluída com sucesso.");
        }
    }
}
