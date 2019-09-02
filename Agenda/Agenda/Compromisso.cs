using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    [Table=("Compromisso")]
    public class Compromisso
    {

        public int Id { get; set; }

        [Required]
        [MinLenght(5)]
        [MaxLenght(200)]
        public String Titulo { get; set; }

        [MaxLenght(500)]
        public String Local { get; set; }

        [Required]
        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set;  }

        public IList<Contato> Participantes { get; set; }

    }
}
