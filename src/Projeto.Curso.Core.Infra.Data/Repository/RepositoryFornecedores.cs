using Microsoft.EntityFrameworkCore;
using Projeto.Curso.Core.Domain.Pedido.Entidades;
using Projeto.Curso.Core.Domain.Pedido.Interfaces.Repository;
using Projeto.Curso.Core.Infra.Data.Context;
using System.Linq;

namespace Projeto.Curso.Core.Infra.Data.Repository
{
    public class RepositoryFornecedores : Repository<Fornecedores>, IRepositoryFornecedores
    {
        public RepositoryFornecedores(ContextEFPedidos context)
            : base(context)
        {

        }
        public Fornecedores ObterPorApelido(string apelido)
        {
            return Db.Fornecedores.AsNoTracking().FirstOrDefault(f => f.Apelido == apelido);
        }

        public Fornecedores ObterPorCpfCnpj(string cpfcnpj)
        {
            return Db.Fornecedores.AsNoTracking().FirstOrDefault(f => f.CPFCNPJ.Numero == cpfcnpj);
        }
    }
}
