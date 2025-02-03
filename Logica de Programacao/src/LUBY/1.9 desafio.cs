using System;

namespace nonoDesafio
{
    public class matrizTransformacao
    {
        public static int[][] transformarEmMatriz(string numeros)
        {
            if (string.IsNullOrWhiteSpace(numeros))
            {
                throw new ArgumentException("A string de entrada não pode ser nula ou vazia.");
            }

            try
            {
                string[] elementos = numeros.Split(',');
                int totalElementos = elementos.Length;
                int linhas = (totalElementos + 1) / 2;
                int[][] matriz = new int[linhas][];

                int indice = 0;
                for (int i = 0; i < linhas; i++)
                {
                    if (indice + 1 < totalElementos)
                    {
                        matriz[i] = new int[] { int.Parse(elementos[indice]), int.Parse(elementos[indice + 1]) };
                        indice += 2;
                    }
                    else
                    {
                        matriz[i] = new int[] { int.Parse(elementos[indice]) };
                    }
                }

                return matriz;
            }
            catch (FormatException) {
                throw new FormatException("A string deve conter apenas números inteiros separados por vírgula.");
            }
            catch (Exception ex) {
                throw new Exception($"Ocorreu um erro ao transformar a string em matriz: {ex.Message}");
            }
        }
    }
}
