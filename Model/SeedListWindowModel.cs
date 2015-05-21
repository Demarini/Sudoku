using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuPuzzle.Model
{
    public class SeedListWindowModel
    {
        private List<string> seedList;
        public SeedListWindowModel()
        {

        }
        public List<string> SeedList
        {
            get { return seedList; }
            set
            {
                seedList = value;
                NotifyPropertyChanged("SeedList");
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
