using System.Collections.Generic;
using System.Linq;

namespace Repositorio {
    public static class GestorDeEstoqueRepo {
        private static List<ProdutoAutomatizado> listaProdutos = new List<ProdutoAutomatizado>();
        private static Dictionary<int, ProdutoAutomatizado> dicionarioProdutos = new Dictionary<int, ProdutoAutomatizado>();

        public static void AdicionarProdutoNovo(ProdutoAutomatizado produto) {
            if (!dicionarioProdutos.ContainsKey(produto.CodigoUnico)) {
                listaProdutos.Add(produto);
                dicionarioProdutos.Add(produto.CodigoUnico, produto);
            }
            else {
                Console.WriteLine("Produto já cadastrado no estoque.");
            }
        }

        public static List<ProdutoAutomatizado> ListarTodosProdutos() {
            return listaProdutos;
        }

        public static ProdutoAutomatizado BuscarProdutoPorCodigo(int codigo) {
            ProdutoAutomatizado produtoEncontrado = null;

            if (dicionarioProdutos.ContainsKey(codigo)) {
                produtoEncontrado = dicionarioProdutos[codigo];
            }

            if (produtoEncontrado == null) {
                Console.WriteLine("Produto não encontrado.");
            }

            return produtoEncontrado;
        }
    }
}