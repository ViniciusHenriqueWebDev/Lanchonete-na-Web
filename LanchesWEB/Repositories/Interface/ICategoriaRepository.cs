using LanchesWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchesWEB.Repositories.Interface
{
    public interface ICategoriaRepository
    {
         IEnumerable<Categoria> Categorias { get; }
    }
}
