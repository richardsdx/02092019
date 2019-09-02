using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Contato
    {
        [Table("Contato")]
        public int Id { get; set; }

        [Required]
        [MinLenght(3)]
        [MaxLenght(100)]

        public String Nome { get; set; }

        [Required]
        [MinLenght(2)]
        [MaxLenght(100)]

        public String SobreNome { get; set; }

        public DateTime DataNascimento { get; set; }

        [MaxLenght(20)]

        public String Telefone { get; set; }
        
        public IList<Compromisso> Compromissos { get; set; }
    }
}
