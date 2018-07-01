using Microsoft.EntityFrameworkCore;
using Projeto.Curso.Core.Domain.Pedido.Entidades;
using Projeto.Curso.Core.Domain.Pedido.Interfaces.Repository;
using Projeto.Curso.Core.Infra.Data.Context;
using System.Linq;

namespace Projeto.Curso.Core.Infra.Data.Repository
{
    public class RepositoryProdutos : Repository<Produtos>, IRepositoryProdutos
    {
        public RepositoryProdutos(ContextEFPedidos context)
            : base(context)
        {

        }
        public Produtos ObterPorApelido(string apelido)
        {
            return Db.Produtos.AsNoTracking().FirstOrDefault(p => p.Apelido == apelido);
        }

        public Produtos ObterPorNome(string nome)
        {
            return Db.Produtos.AsNoTracking().FirstOrDefault(p => p.Nome == nome);
        }
    }
}
