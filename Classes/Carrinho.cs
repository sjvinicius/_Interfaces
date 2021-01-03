using System;
using System.Collections.Generic;

namespace interfaces.Classes
{
    public class Carrinho : ICarrinho
    {
         List<Produto> carrinho = new List<Produto>();
        public void Alterar(int codigo, Produto novoProduto)
        {
            carrinho.Find(x => x.Codigo == codigo).Nome = novoProduto.Nome;
            carrinho.Find(x => x.Codigo == codigo).Preco = novoProduto.Preco;
            carrinho.Find(x => x.Codigo == codigo).Codigo = novoProduto.Codigo;
        }

        public void Alterar(int cod)
        {
            throw new System.NotImplementedException();
        }

        public void Cadastrar(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void Deletar(int cod)
        {
            throw new System.NotImplementedException();
        }

        public void Listar()
        {
            foreach (Produto item in carrinho)
            {
                Console.WriteLine("-----    Código: " + item.Codigo);
                Console.WriteLine("-----    Produto: " + item.Nome);
                Console.WriteLine("-----    Preço: " + item.Preco);
            }
        }

        public void Remover(int codigo)
        {
            Produto prodDelete = carrinho.Find(x => x.Codigo == codigo);
            if(prodDelete != null){
                carrinho.Remove(prodDelete);
            }
        }
    }
}