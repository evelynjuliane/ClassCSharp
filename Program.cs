using System;

namespace ClassCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
			
			Veiculo veiculo = new Veiculo("Fiat", "Uno", "ABC-2485", "VERMELHO", 24, false, 0, 0, 24.500);

			veiculo.Imprime();

			veiculo.Ligar(true);
			veiculo.Freiar();
			veiculo.Acelerar();
			veiculo.Abastecer(100);
			veiculo.Abastecer(2);
			veiculo.Pintar("Preto");
			veiculo.Desligar(false);
			veiculo.Freiar();

			veiculo.Imprime();
		}
	
    }
}
