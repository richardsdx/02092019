using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agenda
{
    [Table("Contato")]
    public class Contato
    {
        
        public int Id { get; set; }

        [MinLength(3)]
        [MaxLength(100)]

        public String Nome { get; set; }

        [MinLength(2)]
        [MaxLength(100)]

        public String SobreNome { get; set; }

        public DateTime DataNascimento { get; set; }

        [MaxLength(20)]

        public String Telefone { get; set; }
        
        public IList<Compromisso> Compromissos { get; set; }
    }
}
