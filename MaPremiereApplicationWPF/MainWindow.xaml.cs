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

namespace MaPremiereApplicationWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button monSecondBouton;


        public MainWindow()
        {
            InitializeComponent();

            //instanciation du bouton
            monSecondBouton = new Button();

            //valeur de contenu 
            monSecondBouton.Content = "ceci est un second bouton !!";

            //evenement lors du clic
            monSecondBouton.Click += MonSecondBouton_Click;


            //ajout du second boutton graphiquement
            MonPremierStackPanel.Children.Add(monSecondBouton);
        }

        //generer lors du l'ajout d'un evenement sur le bouton !!!
        private void MonPremierBouton_Click(object sender, RoutedEventArgs e)
        {
            MonPremierLabel.Content = DateTime.Now;

        }

        //ajout evenement sur le bouton 2
        private void MonSecondBouton_Click(object sender,RoutedEventArgs e)
        {
            MonPremierLabel.Content = DateTime.Now.Second;

        }
    }
}
