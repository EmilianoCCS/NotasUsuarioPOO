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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;

namespace TelasEx
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
                
        public List<Usuario> ListaUsr = new List<Usuario>();
        private List<RankingClasse> listaRanking;
        public MainWindow()
        {
            InitializeComponent();           
        }

        private void btnRanking_Click(object sender, RoutedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        //--------------------------------- ATUALIZAR LISTA ------------------------
        public void atualizaLista()
        {
            lbLista.ItemsSource = null;
            lbLista.ItemsSource = ListaUsr;
            lbLista.DisplayMemberPath = "nome";


        }
        //----------------------------------------------------------------------------------

        //-------------------------------Abrir Janela de Ranking----------------------------
        public void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ranking janela1 = new Ranking(ListaUsr);
            janela1.Show();
        }
        //-----------------------------------------------------------------------------------



        //-------------------------------Abrir Janela de Notas----------------------------
        public void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            AvaliacaoUser janela2 = new AvaliacaoUser(ListaUsr);
            janela2.Show();
        }
        //-----------------------------------------------------------------------------------



        //--------------------------------- CADASTRAR ----------------------------------------
        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            Usuario usr = new Usuario();
            usr.nome = txtNome.Text;
            usr.ID = int.Parse(txtId.Text);
            usr.sexo = rbMasculino.IsChecked == true ? "Masculino" : "Feminino";
            usr.data_nasc = Convert.ToDateTime (date.Text);


            txtId.Clear();
            txtNome.Clear();
            rbFeminino.IsChecked = false;
            rbMasculino.IsChecked = false;

            MessageBox.Show("Registro feito com sucesso", "Sucesso");


            ListaUsr.Add(usr);
            atualizaLista();
        }
        //------------------------------------------------------------------------------------



        private void lbLista_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        //----------------------------------- EXCLUIR -------------------------------------------
        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {
            foreach (Usuario item in ListaUsr)
            {
                if (item.ID == int.Parse(txtId.Text))
                {
                    ListaUsr.Remove(item);
                    break;
                }

            }
            atualizaLista();
        }
        //----------------------------------------------------------------------------------
        
        //----------------------------------- LIMPAR ----------------------------------------
        private void btnLimpar_Click(object sender, RoutedEventArgs e)
        {
            txtId.Text = "";
            txtNome.Text = "";
            rbFeminino.IsChecked = false;
            rbMasculino.IsChecked = false;
        }
        //----------------------------------------------------------------------------------
    }
}
