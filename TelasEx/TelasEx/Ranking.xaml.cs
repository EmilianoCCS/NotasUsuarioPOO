using System;
using System.Collections;
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
    /// Interaction logic for Ranking.xaml
    /// </summary>
    public partial class Ranking
    {
        public List<RankingClasse> listaRanking = new List<RankingClasse>();
        public List<Usuario> listaUsr;
        public List<Comentarios> ListaCadas;
        


        public Ranking(List<Usuario> listaUsr)
        {
             
            foreach (Usuario item in listaUsr)
            {
                RankingClasse Ra = new RankingClasse(item);
                listaRanking.Add(Ra);
                

            }            
            
            InitializeComponent();
            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = listaRanking;
            RankingC();
        }


        private void button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        
        public void RankingC()
        {
          
        }

        private void dataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            RankingClasse r = (RankingClasse)dataGrid.SelectedItem;
            dgCom.ItemsSource = null;
            dgCom.ItemsSource = r.getUsuario().ListaCadas;
        }
    }
}
