using LanchesWEB.Context;
using LanchesWEB.Models;
using LanchesWEB.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchesWEB.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        // Aqui eu estou chamando um método privado para o meu banco de dados. 
        // para retornar todos os registros de lanches com ou sem categoria da minha aplicação
        // Consulta LINQ para retornar os dados de maneira mais objetiva e de fácil entendimento usando as expressões LAMBDAS. 
        private readonly AppDbContext _context;
        public LancheRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);
        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(p => p.IsLanchePreferido).Include(c => c.Categoria);
        
        public Lanche GetLancheById(int lancheId)
        {
            return _context.Lanches.FirstOrDefault(l => l.LancheId == lancheId); 
        }
    }
}
