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

namespace SudokuPuzzle.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        Random r = new Random();
        bool swapped;
        string[,] finalPuzzle;
        Dictionary<string, List<string>> regionsCoordinates;
        List<int[,]> regionsList;
        int sameSolutionFound = 0;
        int numToFirst = 0;
        int totalAttempts = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        

    }
}