using System;

namespace sextoDesafio {
    public class DiferencaDatas {
        public static int calcularDiferencaData(string dataInicial, string dataFinal) {
            if (string.IsNullOrWhiteSpace(dataInicial) || string.IsNullOrWhiteSpace(dataFinal)) {
                throw new ArgumentException("As datas não podem ser nulas ou vazias.");
            }

            try {
                
                int diaInicio = int.Parse(dataInicial.Substring(0, 2));
                int mesInicio = int.Parse(dataInicial.Substring(2, 2));
                int anoInicio = int.Parse(dataInicial.Substring(4, 4));

                int diaFim = int.Parse(dataFinal.Substring(0, 2));
                int mesFim = int.Parse(dataFinal.Substring(2, 2));
                int anoFim = int.Parse(dataFinal.Substring(4, 4));

                DateTime inicio = new DateTime(anoInicio, mesInicio, diaInicio);
                DateTime fim = new DateTime(anoFim, mesFim, diaFim);

                return (fim - inicio).Days;
            }
            catch (FormatException) {
                throw new FormatException("As datas devem estar no formato ddMMyyyy. Exemplo: '10122020'.");
            }
            catch (Exception ex) {
                throw new Exception($"Ocorreu um erro ao calcular a diferença entre as datas: {ex.Message}");
            }
        }
    }
}
