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

namespace engine_v2
{
    /// <summary>
    /// Interaction logic for details.xaml
    /// </summary>
    public partial class details : Page
    {
        public details()
        {
            //comment
            InitializeComponent();
            MaterialName.SelectionMode = SelectionMode.Single;
            MaterialName.Items.Add("chroom");
            MaterialName.Items.Add("goud");
            MaterialName.Items.Add("ijzer");
            MaterialName.SelectedItem = "ijzer";
        }

        private void MaterialName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MaterialName.SelectedItem.ToString() == "chroom")
            {
                Dichtheid.Content = 7190;
            }
            else if (MaterialName.SelectedItem.ToString() == "ijzer")
            {
                Dichtheid.Content = 7870;
            }
            else if (MaterialName.SelectedItem.ToString() == "goud")
            {
                Dichtheid.Content = 19300;
            }

        }

        private void Mass_TextChanged(object sender, TextChangedEventArgs e)
        {
            BerekenFz();
        }
        public void BerekenFz()
        {
            Zwaartekracht.Content = (Convert.ToDouble(Valversnelling.Text) * Convert.ToDouble(Mass.Text)).ToString();
        }
    }
}
