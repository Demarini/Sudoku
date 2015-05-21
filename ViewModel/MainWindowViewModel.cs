using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SudokuPuzzle.Model;
using SudokuPuzzle.View;
using System.Windows;
using System.ComponentModel;
namespace SudokuPuzzle.ViewModel
{
    public class MainWindowViewModel
    {
        private FrameworkElement contentControlView;
        public MainWindowViewModel()
        {
            this.ContentControlView = new MainSudoku();
        }
        public FrameworkElement ContentControlView
        {
            get { return contentControlView; }
            set
            {
                MainWindowModel m = new MainWindowModel();
                contentControlView = value;m.ContentControlView = value;
                NotifyPropertyChanged("ContentControlView");
            }
        }

        public event PropertyChangedEventHandler propertychange;
        public void NotifyPropertyChanged(string name)
        {
            if (propertychange != null)
                propertychange(this, new PropertyChangedEventArgs(name));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
