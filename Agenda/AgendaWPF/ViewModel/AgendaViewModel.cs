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

        private ModelAgenda context { get; set; }

        public AgendaViewModel()
        {
            context = new ModelAgenda();
            this.Contatos = new ObservableCollection<Contato>(context.Contatos.ToList());
            this.PessoaSelecionada = context.Pessoas.FirstOrDefault();

        }
        public void Salvar()
        {
            this.context.SaveChanges();
        }

        public void Remover()
        {
            this.Pessoas.Remove(this.PessoaSelecionada);
            if (this.PessoaSelecionada.Id != 0)
            {
                this.context.Pessoas.Remove(this.PessoaSelecionada);
            }

        }

        public void Adicionar()
        {
            Pessoa p = new Pessoa();
            this.Pessoas.Add(p);
            this.context.Pessoas.Add(p);
            this.PessoaSelecionada = p;

        }
    }
}
}
