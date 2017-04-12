using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Xml.Linq;

namespace Conti.Massimiliano._5I.XMLPersone
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            try
            {
                XElement dati = XElement.Load("Persone.xml");
                IEnumerable<XElement> TutteLePersone = dati.Elements("Persona");

                dgDati.ItemsSource = from item in dati.Elements("Persona") //TutteLePersone
                                     select new Persona(item);

            }
            catch { MessageBox.Show("Errore"); }
      
        }
    }
}
