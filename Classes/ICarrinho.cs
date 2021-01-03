namespace interfaces.Classes
{
    public interface ICarrinho
    {
         void Cadastrar(Produto produto);

         void Listar();

         void Alterar(int cod , Produto produto);

         void Deletar(int cod);
    }
}