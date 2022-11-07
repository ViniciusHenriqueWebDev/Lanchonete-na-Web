using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchesWEB.Models
{
    public class Lanche
    {
        public int LancheId { get; set; }

        [Required(ErrorMessage = "O nome do lanche deve ser informado!")]
        [DisplayName("Qual o nome do lanche?")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A descrição deve ser informada")]
        [DisplayName("Quais os ingredientes do lanche?")]
        public string DescricaoCurta { get; set; }

        [Display(Name = "")]
        public string DescricaoDetalhada { get; set; }
        
        [Required(ErrorMessage = "Digite o nome do Preço!!")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1,999.99, ErrorMessage = "Digite um preço entre 1 e 999,99")]
        public decimal Preco { get; set; }
        
        [Display(Name = "Caminho Imagem Normal")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImageUrl { get; set; }
        
        [Display(Name = "Caminho Imagem Miniatura")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImagemThumbnailUrl { get; set; }
        
        [Display(Name = "Preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
