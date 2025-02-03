using System;

namespace terceiroDesafio {
    public class NumeroPrimo {
        public static int contarNumerosPrimos(int limite) {
            int contadorPrimos = 0;

            for (int numero = 2; numero <= limite; numero++) {
                if (EhPrimo(numero)) {
                    Console.WriteLine($"Número primo: {numero}");
                    contadorPrimos++;
                }
            }

            Console.WriteLine($"Total de números primos: {contadorPrimos}");
            return contadorPrimos;
        }

        private static bool EhPrimo(int numero) {
            if (numero < 2) return false;

            for (int i = 2; i <= Math.Sqrt(numero); i++) {
                if (numero % i == 0) {
                    return false;
                }
            }

            return true;
        }
    }
}
