namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private readonly decimal precoInicial = 0;
        private readonly decimal precoPorHora = 0;
        private readonly List<string> veiculos = new();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");

            string placa = Console.ReadLine();

            veiculos.Add(placa);

            try{
                Console.WriteLine($"O veículo com a placa {veiculos.Last()} foi adicionado com sucesso");
            }
            catch{
                Console.WriteLine($"Ocorreu algum erro no cadastro do veículo, por favor, tente novamente");
                Console.WriteLine("--------------------------------------");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                try{
                    int horas = int.Parse(Console.ReadLine());
                    decimal valorTotal = precoInicial + precoPorHora * horas;

                    veiculos.Remove(placa);

                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                }
                catch{
                    Console.WriteLine($"Ocorreu algum erro na remoção do veículo, por favor, tente novamente");
                }                
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                Console.WriteLine("--------------------------------------");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                
                foreach(string veiculo in veiculos){
                    Console.WriteLine("Placa: " + veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados, cadastre um novo veículo e tente novamente");
                Console.WriteLine("--------------------------------------");
            }
        }
    }
}
