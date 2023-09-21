using Domain.Interfaces.Generics;
using Domain.Interfaces.IDespesa;
using Entities.Entidades;
using Infra.Repositorio.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositorio
{
    public class RepositórioDespesa : RepositoryGenerics<Despesa>, InterfaceDespesa
    {
        public Task<IList<Despesa>> ListarDespesaUsuario(string emailUsuario)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Despesa>> ListarDespesaUsuarioNaoPagasMesesAnterior(string emailUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
