using System;
using System.Globalization;


namespace quintoDesafio {
    public class Desconto {
        public static double calcularValorComDescontoFormatado(string valorOriginal, string percentualDesconto) {
            if (string.IsNullOrWhiteSpace(valorOriginal) || string.IsNullOrWhiteSpace(percentualDesconto)) {
                throw new ArgumentException("O valor original e o percentual de desconto não podem ser nulos ou vazios.");
            }

            try {
                double valor = Convert.ToDouble(valorOriginal.Substring(3), CultureInfo.InvariantCulture);
                double desconto = Convert.ToDouble(percentualDesconto.Remove(percentualDesconto.LastIndexOf("%")), CultureInfo.InvariantCulture) / 100.0;

                return valor - (valor * desconto);
            }
            catch (FormatException) {
                throw new FormatException("O formato do valor ou do percentual de desconto está incorreto.");
            }
            catch (ArgumentOutOfRangeException) {
                throw new ArgumentOutOfRangeException("Os valores informados não estão no formato esperado. Certifique-se de que o valor começa com 'R$' e o percentual termina com '%'.");
            }
        }
    }
}