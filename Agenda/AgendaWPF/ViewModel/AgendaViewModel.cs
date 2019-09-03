using Agenda;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaWPF.ViewModel
{
  public class AgendaViewModel
    {

        public ObservableCollection<Contato> Contatos { get; set; }

        public Boolean PodeRemover
        {
            get
            {
                return this.ContatoSelecionado != null;
            }
        }


        public Contato ContatoSelecionado { get; set; }
        public Compromisso CompromissoSelecionado { get; set; }

        private ModelAgenda context { get; set; }

        public AgendaViewModel()
        {
            context = new ModelAgenda();
            this.Contatos = new ObservableCollection<Contato>(context.Contatos.ToList());
            this.ContatoSelecionado = context.Contatos.FirstOrDefault();

        }
        public void Salvar()
        {
            this.context.SaveChanges();
        }

        public void Remover()
        {
            this.Contatos.Remove(this.ContatoSelecionado);
            if (this.ContatoSelecionado.Id != 0)
            {
                this.context.Contatos.Remove(this.ContatoSelecionado);
            }

        }

        public void Adicionar()
        {
            Contato p = new Contato();
            this.Contatos.Add(p);
            this.context.Contatos.Add(p);
            this.ContatoSelecionado = p;

        }
    }
}
