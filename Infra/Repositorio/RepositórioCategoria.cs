using Domain.Interfaces.ICategorias;
using Entities.Entidades;
using Infra.Repositorio.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositorio
{
    public class RepositórioCategoria : RepositoryGenerics<Categoria>, InterfaceCategoria
    {
        public Task<IList<Categoria>> ListarCategoriaUsuario(string emailUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
