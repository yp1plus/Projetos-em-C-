//By Yure Pablo em 28/11/2017

using System;

namespace AcenderLampada
{
	class Program
	{
		public static void Main(string[] args)
		{
			Lampada l = new Lampada(true);
			l.imprimir();
			l.desligar();
			l.imprimir();
			
			Console.WriteLine("Pressionar qualquer tecla para continuar . . .");
			Console.ReadKey();
		}

		public class Lampada
	    {
			private bool estado;
			
			public Lampada (bool estado)
			{
				this.estado = estado;
			}
			
			public void ligar()
			{
				estado = true;
			}

			public void desligar()
			{
				estado = false;
			}
			
			public void imprimir()
			{
				if (estado) 
					Console.WriteLine("Lâmpada ligada");
				else
					Console.WriteLine("Lâmpada desligada");
			}
	    }
	}
}