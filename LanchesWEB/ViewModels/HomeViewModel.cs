using LanchesWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchesWEB.ViewModels
{
    public class HomeViewModel 
    {
        public IEnumerable<Lanche> LanchesPreferidos { get; set; }
    }
}
