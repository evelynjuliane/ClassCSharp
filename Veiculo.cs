using System;
using System.Collections.Generic;
using System.Text;

namespace ClassCSharp
{

	public class Veiculo
	{
		//CONSTRUTORES

		public Veiculo(string marca, string modelo, string placa, string cor, float km, bool isLigado,
				int litrosCombustivel, int velocidade, double preco)
		{
			this.marca = marca;
			this.modelo = modelo;
			this.placa = placa;
			this.cor = cor;
			this.km = km;
			this.isLigado = isLigado;
			this.litrosCombustivel = litrosCombustivel;
			this.velocidade = velocidade;
			this.preco = preco;
		}
		public Veiculo()
		{

		}


		// GETTERS AND SETTERS


		private string marca { get; set; }
		private string modelo { get; set; }
		private string placa { get; set; }
		private string cor { get; set; }
		private float km { get; set; }
		private bool isLigado { get; set; }
		private int litrosCombustivel { get; set; }
		private int velocidade{get; set; }
		private double preco { get; set; }


		// METODOS

		public void Acelerar()
		{
			if (this.isLigado == false)
			{
				Console.WriteLine("Não é possivel acelerar com o carro desligado!");
			}
			this.velocidade = 20;
			this.litrosCombustivel = -1;
		}

		public void Abastecer(int litrosACombustivel)
		{
			if (this.litrosCombustivel < 100)
			{
				this.litrosCombustivel = litrosACombustivel;
			}
			else
			{
				Console.WriteLine("O carro está com o tanque cheio!");
			}
		}
		public void Freiar()
		{
			if (this.isLigado == true)
			{
				if (this.velocidade != 0)
				{
					this.velocidade = 10;
				}
				Console.WriteLine("O carro está parado!");
			}

			Console.WriteLine("Não é possivel freiar com o carro desligado!");
		}

		public void Pintar(string mcor)
		{
			{
				this.cor = mcor;
			}
		}
		public bool Ligar(bool ligar)
		{
			return this.isLigado = true;
		}
		public bool Desligar(bool desligar) { 
		
			return this.isLigado = false;
		}

		public void Imprime() { 
			Console.WriteLine("Marca:" + this.marca  + "Modelo:" + this.modelo + "Placa:" + this.placa + "Cor:" + this.cor + "Km:" + this.km + "Status:" + this.isLigado
				+ "Litros de Combutível:" + this.litrosCombustivel + "Velocidade:" + this.velocidade + "Preço:" + this.preco); 
		
			
		}

	}
}
