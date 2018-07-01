using Microsoft.EntityFrameworkCore;
using Projeto.Curso.Core.Domain.Pedido.Entidades;
using Projeto.Curso.Core.Domain.Pedido.Interfaces.Repository;
using Projeto.Curso.Core.Infra.Data.Context;
using System.Linq;

namespace Projeto.Curso.Core.Infra.Data.Repository
{
    public class RepositoryCliente : Repository<Clientes>, IRepositoryClientes
    {
        public RepositoryCliente(ContextEFPedidos context)
            : base(context)
        {

        }
        public Clientes ObterPorApelido(string apelido)
        {
            return Db.Clientes.AsNoTracking().FirstOrDefault(c => c.Apelido == apelido);
        }

        public Clientes ObterPorCpfCnpj(string cpfcnpj)
        {
            return Db.Clientes.AsNoTracking().FirstOrDefault(c => c.CPFCNPJ.Numero == cpfcnpj);
        }
    }
}
