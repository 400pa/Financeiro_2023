using Domain.Interfaces.IUsuarioSistemaFinanceiro;
using Entities.Entidades;
using Infra.Repositorio.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositorio
{
    public class RepositórioUsuarioSistemaFinanceiro : RepositoryGenerics<UsuarioSistemaFinanceiro>, InterfaceUsuarioSistemaFinanceiro
    {
        public Task<IList<UsuarioSistemaFinanceiro>> ListarUsuariosSistema(int IdSistema)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioSistemaFinanceiro> ObterUsuarioPorEmail(string emailUsuario)
        {
            throw new NotImplementedException();
        }

        public Task RemoveUsuarios(List<UsuarioSistemaFinanceiro> usuarios)
        {
            throw new NotImplementedException();
        }
    }
}
