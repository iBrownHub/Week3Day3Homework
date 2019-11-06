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

namespace Week3Day3Homework
{
    /// <summary>
    /// Interaction logic for DifficultySelect.xaml
    /// </summary>
    public partial class DifficultySelect : Window
    {
        public DifficultySelect()
        {
            InitializeComponent();
        }
        public string difficulty;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            difficulty = (string)btn.Content;
            switch (difficulty)
            {
                case "Easy":
                    EasyDifficulty ed = new EasyDifficulty();
                    ed.Show();
                    this.Close();
                    break;
                case "Normal":
                    NormalDifficulty nd = new NormalDifficulty();
                    nd.Show();
                    this.Close();
                    break;
                case "Hard":
                    HardDifficulty hd = new HardDifficulty();
                    hd.Show();
                    this.Close();
                    break;                
            }
        }
    }
}
