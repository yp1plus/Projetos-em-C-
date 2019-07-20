//By Yure Pablo em 25/09/2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c = new Cliente(2, "João", "Avenida", "07498765", "Bom", 500);
            Produto[] p = new Produto[3];
            p[0] = new Produto(03, "OMO", "Sabão em pó", 2);
            p[1] = new Produto(04, "YPÊ", "Sabão Líquido", 4);
            p[2] = new Produto(05, "Estrela", "Desinfetante", 6);
            Itens[] item = new Itens[3];
            item[0] = new Itens(p[0], 5);
            item[1] = new Itens(p[1], 10);
            item[2] = new Itens(p[2], 20);
            Pedido pedido = new Pedido(1, "15/09/2017", 3, item, c);
            pedido.calcularValorTotalPedido();
            pedido.imprimirPedido();
            Console.ReadKey();


        }
    }
    public class Produto
    {
        public int codigo;
        public string nomeDoProduto;
        public string categoria;
        public float preco;

        public Produto(int codigo, string nomeDoProduto, string categoria, float preco)
        {
            this.codigo = codigo;
            this.nomeDoProduto = nomeDoProduto;
            this.categoria = categoria;
            this.preco = preco;
        }
    }
    public class Cliente
    {
        int codigo;
        public string nome;
        string endereco;
        string telefone;
        string status;
        float limiteDeCredito;

        public Cliente(int codigo, string nome, string endereco, string telefone, string status, float limiteDeCredito)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.endereco = endereco;
            this.telefone = telefone;
            this.status = status;
            this.limiteDeCredito = limiteDeCredito;
        }

    }

    public struct Itens
    {
        public Produto item;
        public int quantidadeDeProdutos;

        public Itens(Produto item, int quantidadeDeProdutos)
        {
            this.item = item;
            this.quantidadeDeProdutos = quantidadeDeProdutos;
        }
    }

    public class Pedido
    {
        int numero;
        string data;
        public int quantidadeDeItens;
        Itens[] listaItens;
        float valorTotalPedido;
        Cliente c;

        public Pedido(int numero, string data, int quantidadeDeItens, Itens[] listaItens, Cliente c)
        {
            this.numero = numero;
            this.data = data;
            this.quantidadeDeItens = quantidadeDeItens;
            this.listaItens = listaItens;
            this.c = c;
        }

        public void calcularValorTotalPedido()
        {
            for (int i = 0; i < quantidadeDeItens; i++)
            {
                valorTotalPedido = valorTotalPedido + listaItens[i].quantidadeDeProdutos * listaItens[i].item.preco;
            }
        }
        public void imprimirPedido()
        {
            Console.WriteLine("Compra de número " + numero 
                            + " realizada na data " + data 
                            + " pelo cliente " + c.nome);

            Console.WriteLine("Item \t" 
                            + "Código \t" 
                            + "Nome \t" 
                            + "Categoria \t"
                            + "Preco \t" 
                            + "Qtd \t" 
                            + "Preço Total");
            for (int i = 0; i < quantidadeDeItens; i++)
            {
                Console.WriteLine((i + 1) + "\t" 
                                + listaItens[i].item.codigo + "\t"
                                + listaItens[i].item.nomeDoProduto + "\t"
                                + listaItens[i].item.categoria + "\t"
                                + listaItens[i].item.preco + "\t"
                                + listaItens[i].quantidadeDeProdutos + "\t"
                                + listaItens[i].quantidadeDeProdutos * listaItens[i].item.preco);
            }
            Console.WriteLine("Preço do Pedido: " + valorTotalPedido);
        }
    }
}
