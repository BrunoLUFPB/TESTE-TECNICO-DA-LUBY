using System;
using Repositorio;
using Servicos;

namespace Controlador {
    public class ControleMaquinaVenda{
        public static void RodarMaquina() {
            InicializarProdutos();
            bool continuar = true;

            while (continuar) {
                MostrarMenuPrincipal();

                string escolha = Console.ReadLine().ToUpper();

                switch (escolha) {
                    case "A":
                        ListarProdutos();
                        break;
                    case "B":
                        ComprarProduto();
                        break;
                    case "C":
                        MostrarTotalVendas();
                        break;
                    case "D":
                        HistoricoDeVendasRepo.MostrarHistoricoDeVendas();
                        break;
                    case "E":
                        Console.WriteLine("Encerrando o programa.");
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");

                if (!Console.IsInputRedirected) {
                    Console.ReadKey();
                }
                else {
                    Console.ReadLine();
                }
            }
        }

        private static void InicializarProdutos() {
            GestorDeEstoqueRepo.AdicionarProdutoNovo(new ProdutoAutomatizado("Refrigerante", 5.00, 10));
            GestorDeEstoqueRepo.AdicionarProdutoNovo(new ProdutoAutomatizado("Suco", 4.00, 8));
            GestorDeEstoqueRepo.AdicionarProdutoNovo(new ProdutoAutomatizado("Água", 2.50, 15));
        }

        private static void MostrarMenuPrincipal() {
            if (Console.IsOutputRedirected == false) {
    Console.Clear();
}
            Console.WriteLine("=== Máquina de Vendas ===\n");
            Console.WriteLine("=== Máquina de Vendas ===\n");
            Console.WriteLine("A. Ver Produtos Disponíveis");
            Console.WriteLine("B. Comprar Produto");
            Console.WriteLine("C. Ver Total de Vendas");
            Console.WriteLine("D. Ver Histórico de Vendas");
            Console.WriteLine("E. Sair");
            Console.Write("\nEscolha uma opção: ");
        }

        private static void ListarProdutos() {
            Console.WriteLine("\nProdutos Disponíveis:");
            foreach (var produto in GestorDeEstoqueRepo.ListarTodosProdutos()) {
                Console.WriteLine($"Código: {produto.CodigoUnico} | {produto.NomeProduto} - R$ {produto.PrecoProduto:F2} | Quantidade: {produto.QuantidadeDisponivel}");
            }
        }

        private static void ComprarProduto() {
            ListarProdutos();

            Console.Write("\nDigite o código do produto: ");
            string entrada = Console.ReadLine();
            int codigoProduto;

            if (!int.TryParse(entrada, out codigoProduto)) {
                Console.WriteLine("Código inválido. Insira um número.");
                return;
            }

            var produtoEscolhido = GestorDeEstoqueRepo.BuscarProdutoPorCodigo(codigoProduto);

            if (ServicosDeEstoque.TemProdutoDisponivel(produtoEscolhido)) {
                ProcessadorDeVendas.IniciarVenda(produtoEscolhido);
            }
        }

        private static void MostrarTotalVendas() {
            double total = HistoricoDeVendasRepo.ObterTotalDeVendas();
            Console.WriteLine($"\nTotal de Vendas: R$ {total:F2}");
        }
    }
}