using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ListagemAPi.Domain.Entities
{
    public class Administrador
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }
        [Required]
        [StringLength(255)]
        public string? Email { get; set; }
        [StringLength(50)]
        public string? Senha { get; set; }
        [StringLength(5)]
        public string? Perfil { get; set; }
    }
}