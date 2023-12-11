using System.Diagnostics.Contracts;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {

            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            // Validação básica de formato de placa utilizando Length: ABC-1234 (antigo) e ABC1D23 (novo)
            if (placa.Length == 8 )
            {
                veiculos.Add(placa);
                Console.WriteLine($"Veículo de placa {placa} cadastrado com sucesso!");
            } else
            {
                Console.WriteLine("Formato inválido");
            }               
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                string input = Console.ReadLine();

                int horas = 0;
                decimal valorTotal = 0;   

                // validação de inteiro para a hora
                if (int.TryParse(input, out horas))
                {
                    // Realiza cálculo e remove placa
                    valorTotal = precoInicial + precoPorHora * horas;
                    veiculos.Remove(placa);

                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                } else
                {
                    Console.WriteLine($"Formato de hora inválido. Confira se digitou um número inteiro");
                }              
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
  
                int count = 0;
                foreach (var veiculo in veiculos)
                {   
                    Console.WriteLine($"{count + 1} - {veiculo}");
                    count++;
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
