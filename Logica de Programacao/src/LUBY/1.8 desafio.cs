using System;

namespace oitavoDesafio {
    public class buscaVetor {
        public static string[] buscarPessoa(string[] vetor, string termoBusca) {
            if (vetor == null || vetor.Length == 0) {
                throw new ArgumentException("O vetor não pode ser nulo ou vazio.");
            }

            if (string.IsNullOrWhiteSpace(termoBusca)) {
                throw new ArgumentException("O termo de busca não pode ser nulo ou vazio.");
            }

            string[] resultados = new string[vetor.Length];
            int contador = 0;

            for (int i = 0; i < vetor.Length; i++) {
                if (vetor[i].IndexOf(termoBusca, StringComparison.OrdinalIgnoreCase) >= 0) {
                    resultados[contador++] = vetor[i];
                }
            }

            Array.Resize(ref resultados, contador);
            return resultados;
        }
    }
}