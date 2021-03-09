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
using MahApps.Metro.Controls;

namespace TelasEx
{
    /// <summary>
    /// Interaction logic for AvaliacaoUser.xaml
    /// </summary>
    public partial class AvaliacaoUser
    {
        public List<Usuario> listaUsr;
        private Comentarios item;

        //private List<RankingClasse> ListaRank = new List<RankingClasse>();

        public AvaliacaoUser(List<Usuario> listaUsr)
        {
            this.listaUsr = listaUsr;
            InitializeComponent();
            cbNome.ItemsSource = null;
            cbNome.ItemsSource = listaUsr;
            cbNome.DisplayMemberPath = "nome";
        }


        public void btnEnviar_Click(object sender, RoutedEventArgs e)
        {
            Comentarios r = new Comentarios(item);
            r.Estrela = int.Parse(txtEstrelas.Text);
            r.Comentario = txtComent.Text;
            Usuario u = (Usuario)cbNome.SelectedItem;
            u.ListaCadas.Add(r);
            MessageBox.Show("Avaliação Enviada!", "Avaliação");

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void txtNome_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
