using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AgendaWPF
{
    /// <summary>
    /// Lógica interna para WindowContato.xaml
    /// </summary>
    public partial class WindowContato : Window
    {
        public ViewModel.AgendaViewModel AgendaViewModel { get; set; }
        public WindowContato()
        {
            InitializeComponent();
            this.AgendaViewModel = new ViewModel.AgendaViewModel();
            this.DataContext = this;
        }

        private void ListViewItem_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void AdicionarButton_Click(object sender, RoutedEventArgs e)
        {
            this.AgendaViewModel.Adicionar();
        }

        private void RemoverButton_Click(object sender, RoutedEventArgs e)
        {
            this.AgendaViewModel.Remover();
        }

        private void CancelarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            this.AgendaViewModel.Salvar();
            this.Close();
        }
    }
}
