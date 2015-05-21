using SudokuPuzzle.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SudokuPuzzle.Model
{
    public class MainWindowModel : INotifyPropertyChanged
    {
        private FrameworkElement contentControlView;
        public MainWindowModel()
        {
            
        }
        public FrameworkElement ContentControlView
        {
            get { return contentControlView; }
            set
            {
                contentControlView = value;
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
