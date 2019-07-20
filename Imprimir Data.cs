//By Yure Pablo em 28/11/2017

using System;

namespace ImprimirData
{
	class Date
	{
		public static void Main(string[] args)
		{
			Data d1 = new Data (10, 03, 2000, 10, 30, 10);
			d1.imprimir(Data.FORMATO_12H);
			d1.imprimir(Data.FORMATO_24H);
			
			Data d2 = new Data (15, 06, 2000, 23, 15, 20);
			d2.imprimir(Data.FORMATO_12H);
			d2.imprimir(Data.FORMATO_24H);
			
			Data d3 = new Data (5,10,2005);
			d3.imprimir(Data.FORMATO_12H);
			d3.imprimir(Data.FORMATO_24H);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
	
	public class Data
	{
		private int dia, mes, ano;
		private int hora, minuto, segundo;
		public const int FORMATO_12H = 12, FORMATO_24H = 24;
		
		public Data(int dia,int mes, int ano)
		{
			this.dia = dia;
			this.mes = mes;
			this.ano = ano;
		}

		public Data(int dia, int mes, int ano, int hora, int minuto, int segundo): this(dia, mes, ano)
		{
			this.hora = hora;
			this.minuto = minuto;
			this.segundo = segundo;
		}

		public int getDia()
		{
			return dia;
		}

		public int getMes()
		{
			return mes;
		}

		public int getAno()
		{
			return ano;
		}

		public int getHora()
		{
			return hora;
		}

		public int getMinuto()
		{
			return minuto;
		}

		public int getSegundo()
		{
			return segundo;
		}

		public void imprimir(int formato)
		{
			if (hora == 0)
				Console.WriteLine(dia + "/" + mes + "/" + ano + "\t");
			if (hora > 0) 
			{
				Console.Write(dia + "/" + mes + "/" + ano + "\t");
			if (formato == 12)
				if (hora>12)
					Console.WriteLine(hora - 12 + ":" + minuto + ":" + segundo + " PM");
			    else
					Console.WriteLine(hora + ":" + minuto + ":" + segundo + " AM");
		    else
					Console.WriteLine(hora + ":" + minuto + ":" + segundo);
			}
		}	
	}
}