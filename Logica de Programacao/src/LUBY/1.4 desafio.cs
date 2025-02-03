using System;

namespace quartoDesafio {
    public class ContadorVogais {
        public static int calcularVogais(string texto) {
            if (string.IsNullOrEmpty(texto)) {
                throw new ArgumentException("O texto não pode ser nulo ou vazio.");
            }

            int contadorVogais = 0;
            string vogais = "aeiouAEIOU";

            for (int i = 0; i < texto.Length; i++) {
                if (vogais.Contains(texto[i])) {
                    contadorVogais++;
                }
            }

            Console.WriteLine($"Total de vogais: {contadorVogais}");
            return contadorVogais;
        }
    }
}