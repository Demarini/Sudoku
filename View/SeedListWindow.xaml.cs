using SudokuPuzzle.ViewModel;
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

namespace SudokuPuzzle.View
{
    /// <summary>
    /// Interaction logic for SeedListWindow.xaml
    /// </summary>
    public partial class SeedListWindow : Window
    {
        public SeedListWindow(int genNum)
        {
            InitializeComponent();
            this.DataContext = new SeedListWindowViewModel(genNum);
        }
    }
}
