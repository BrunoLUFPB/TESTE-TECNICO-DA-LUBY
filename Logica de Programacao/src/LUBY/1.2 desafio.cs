using System;

namespace segundoDesafio{
        public class Premio {
            public static double calcularPremio(double valor, string tipoPremio, double? fatorMultiplicacaoProprio)
        {

            if (valor <= 0) {
                throw new ArgumentException("O valor do prêmio deve ser maior que zero.");
            }

            double fatorMultiplicacao = 1;

            switch (tipoPremio.ToLower()) {
                case "basic":
                    fatorMultiplicacao = 1;
                    break;
                case "vip":
                    fatorMultiplicacao = 1.2;
                    break;
                case "premium":
                    fatorMultiplicacao = 1.5;
                    break;
                case "deluxe":
                    fatorMultiplicacao = 1.8;
                    break;
                case "special":
                    fatorMultiplicacao = 2;
                    break;
                default:
                    Console.WriteLine("Tipo de prêmio desconhecido. Usando fator padrão de 1.");
                    break;
            }

            if (fatorMultiplicacaoProprio.HasValue && fatorMultiplicacaoProprio.Value > 0) {
                fatorMultiplicacao = fatorMultiplicacaoProprio.Value;
            }

            double valorTotal = valor * fatorMultiplicacao;

            return valorTotal;
        }
    }
}