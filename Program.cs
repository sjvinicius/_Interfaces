using System;
using interfaces.Classes;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
           Carrinho carrinho = new Carrinho();

            Produto produto1 = new Produto();
            produto1.Codigo = 123;
            produto1.Nome = "Playstation 5";
            produto1.Preco = 10000;

            Produto produto2 = new Produto();
            produto2.Codigo = 124;
            produto2.Nome = "XBOX One";
            produto2.Preco = 1500;

            Produto produto3 = new Produto();
            produto3.Codigo = 125;
            produto3.Nome = "Nintendo Switch";
            produto3.Preco = 5000;
            
            carrinho.Cadastrar(produto1);
            carrinho.Cadastrar(produto2);
            carrinho.Listar();

            carrinho.Alterar(produto2.Codigo, produto3);
            carrinho.Listar();

            carrinho.Remover(produto1.Codigo);
            carrinho.Listar();
        }
    }
}