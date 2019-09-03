using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            Contato contato = new Contato()
            {
                Nome = "Alex Pinheiro das Graças"
                
            };
           
            ModelAgenda context = new ModelAgenda();
            context.Contatos.Add(contato);
            context.SaveChanges();
        }
    }
}
