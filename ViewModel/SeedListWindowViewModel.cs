using SudokuPuzzle.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace SudokuPuzzle.ViewModel
{
    public class SeedListWindowViewModel
    {
        private List<string> seedList = new List<string>();
        public SeedListWindowViewModel(int genNum)
        {
            GenerateSeeds(genNum);
            AppendToTextFile();
            //Application.Current.Dispatcher.BeginInvoke(
            //DispatcherPriority.Background,
            //new Action(() => GenerateSeeds(genNum)));
            //Thread _thread = new Thread(() => GenerateSeeds(genNum));
            //_thread.Start();
            //Thread _thread = new Thread(() => GenerateSeeds(genNum));
            //_thread.Start();
            //for (int i = 0; i < genNum; i++)
            //{
            //    GenerateSeeds(genNum);
            //}
            

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
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void GenerateSeeds(int genNum)
        {
            List<string> tempSeedList = SeedList;
            for (int k = 0; k < genNum; k++)
            {
                CreateSudoku cS = new CreateSudoku();
                string[,] finalPuzzle = cS.CreateSudokuPuzzle();
                string finalString = "";
                for (int i = 0; i < finalPuzzle.GetLength(0); i++)
                {
                    for (int j = 0; j < finalPuzzle.GetLength(1); j++)
                    {
                        finalString += finalPuzzle[i, j] + ",";
                    }
                }
                tempSeedList = SeedList;
                tempSeedList.Add(finalString);
                Application.Current.Dispatcher.BeginInvoke(
                DispatcherPriority.Background,
                new Action(() => SeedList = tempSeedList));
            }
        }

        public void AppendToTextFile()
        {
            List<string> list = new List<string>();
            string path = "Seeds.txt";
            using (StreamReader sr = new StreamReader("Seeds.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    list.Add(line); // Add to list.
                }
            }
            // This text is added only once to the file. 
            // Create a file to write to. 
            using (StreamWriter sw = File.AppendText(path))
            {
                bool isInTextFile = false;
                for (int i = 0; i < SeedList.Count; i++)
                {
                    foreach (string s in list)
                    {
                        if (s == SeedList[i])
                        {
                            isInTextFile = true;
                        }
                    }
                    if (!isInTextFile)
                    {
                        sw.WriteLine(SeedList[i]);
                    }
                    isInTextFile = false;
                }
            }
        }
    }
}
