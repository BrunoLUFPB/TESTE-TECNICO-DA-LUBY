using System;
using System.Collections.Generic;

namespace sétimoDesafio {
    public class VetorPares {
        public static int[] obterElementosPares(int[] vetor) {
            if (vetor == null || vetor.Length == 0) {
                throw new ArgumentException("O vetor não pode ser nulo ou vazio.");
            }

            try {
                List<int> pares = new List<int>();

                for (int i = 0; i < vetor.Length; i++)
                {
                    if (vetor[i] % 2 == 0)
                    {
                        pares.Add(vetor[i]);
                    }
                }

                return pares.ToArray();
            }
            catch (Exception ex) {
                throw new Exception($"Ocorreu um erro ao processar o vetor: {ex.Message}");
            }
        }
    }
}

