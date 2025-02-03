using System;

namespace primeiroDesafio {
    public class Fatorial {
        public static int calculaFatorial(int numero) {
            if (numero < 0) {
                throw new ArgumentException("Número não pode ser negativo.");
            }

            int resultado = 1;

            while (numero > 0) {
                resultado *= numero;
                numero--;
            }

            return resultado;
        }
    }
}