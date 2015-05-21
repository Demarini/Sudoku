using GalaSoft.MvvmLight.Command;
using SudokuPuzzle.Model;
using SudokuPuzzle.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SudokuPuzzle.ViewModel
{
    public class MainSudokuViewModel : INotifyPropertyChanged
    {
        private ICommand openNewWindow;
        private string generateNumber;
        private string sudokuGrid1;
        private string sudokuGrid2;
        private string sudokuGrid3;
        private string sudokuGrid4;
        private string sudokuGrid5;
        private string sudokuGrid6;
        private string sudokuGrid7;
        private string sudokuGrid8;
        private string sudokuGrid9;
        private string sudokuGrid10;
        private string sudokuGrid11;
        private string sudokuGrid12;
        private string sudokuGrid13;
        private string sudokuGrid14;
        private string sudokuGrid15;
        private string sudokuGrid16;
        private string sudokuGrid17;
        private string sudokuGrid18;
        private string sudokuGrid19;
        private string sudokuGrid20;
        private string sudokuGrid21;
        private string sudokuGrid22;
        private string sudokuGrid23;
        private string sudokuGrid24;
        private string sudokuGrid25;
        private string sudokuGrid26;
        private string sudokuGrid27;
        private string sudokuGrid28;
        private string sudokuGrid29;
        private string sudokuGrid30;
        private string sudokuGrid31;
        private string sudokuGrid32;
        private string sudokuGrid33;
        private string sudokuGrid34;
        private string sudokuGrid35;
        private string sudokuGrid36;
        private string sudokuGrid37;
        private string sudokuGrid38;
        private string sudokuGrid39;
        private string sudokuGrid40;
        private string sudokuGrid41;
        private string sudokuGrid42;
        private string sudokuGrid43;
        private string sudokuGrid44;
        private string sudokuGrid45;
        private string sudokuGrid46;
        private string sudokuGrid47;
        private string sudokuGrid48;
        private string sudokuGrid49;
        private string sudokuGrid50;
        private string sudokuGrid51;
        private string sudokuGrid52;
        private string sudokuGrid53;
        private string sudokuGrid54;
        private string sudokuGrid55;
        private string sudokuGrid56;
        private string sudokuGrid57;
        private string sudokuGrid58;
        private string sudokuGrid59;
        private string sudokuGrid60;
        private string sudokuGrid61;
        private string sudokuGrid62;
        private string sudokuGrid63;
        private string sudokuGrid64;
        private string sudokuGrid65;
        private string sudokuGrid66;
        private string sudokuGrid67;
        private string sudokuGrid68;
        private string sudokuGrid69;
        private string sudokuGrid70;
        private string sudokuGrid71;
        private string sudokuGrid72;
        private string sudokuGrid73;
        private string sudokuGrid74;
        private string sudokuGrid75;
        private string sudokuGrid76;
        private string sudokuGrid77;
        private string sudokuGrid78;
        private string sudokuGrid79;
        private string sudokuGrid80;
        private string sudokuGrid81;
        private System.Windows.Visibility loadHide = System.Windows.Visibility.Visible;
        private System.Windows.Visibility generateHide = System.Windows.Visibility.Visible;
        private System.Windows.Visibility submitHide = System.Windows.Visibility.Hidden;
        private System.Windows.Visibility createHide = System.Windows.Visibility.Visible;
        MainSudokuModel m = new MainSudokuModel();

        public MainSudokuViewModel()
        {
        }

        public string SudokuGrid1
        {
            get
            {
                return sudokuGrid1;
            }
            set
            {
                sudokuGrid1 = value; this.NotifyPropertyChanged("SudokuGrid1"); m.SudokuGrid1 = value;
            }
        }

        public string SudokuGrid2
        {
            get
            {
                return sudokuGrid2;
            }
            set
            {
                sudokuGrid2 = value; this.NotifyPropertyChanged("SudokuGrid2"); m.SudokuGrid2 = value;
            }
        }

        public string SudokuGrid3
        {
            get
            {
                return sudokuGrid3;
            }
            set
            {
                sudokuGrid3 = value; this.NotifyPropertyChanged("SudokuGrid3"); m.SudokuGrid3 = value;
            }
        }

        public string SudokuGrid4
        {
            get
            {
                return sudokuGrid4;
            }
            set
            {
                sudokuGrid4 = value; this.NotifyPropertyChanged("SudokuGrid4"); m.SudokuGrid4 = value;
            }
        }

        public string SudokuGrid5
        {
            get
            {
                return sudokuGrid5;
            }
            set
            {
                sudokuGrid5 = value; this.NotifyPropertyChanged("SudokuGrid5"); m.SudokuGrid5 = value;
            }
        }

        public string SudokuGrid6
        {
            get
            {
                return sudokuGrid6;
            }
            set
            {
                sudokuGrid6 = value; this.NotifyPropertyChanged("SudokuGrid6"); m.SudokuGrid6 = value;
            }
        }

        public string SudokuGrid7
        {
            get
            {
                return sudokuGrid7;
            }
            set
            {
                sudokuGrid7 = value; this.NotifyPropertyChanged("SudokuGrid7"); m.SudokuGrid7 = value;
            }
        }

        public string SudokuGrid8
        {
            get
            {
                return sudokuGrid8;
            }
            set
            {
                sudokuGrid8 = value; this.NotifyPropertyChanged("SudokuGrid8"); m.SudokuGrid8 = value;
            }
        }

        public string SudokuGrid9
        {
            get
            {
                return sudokuGrid9;
            }
            set
            {
                sudokuGrid9 = value; this.NotifyPropertyChanged("SudokuGrid9"); m.SudokuGrid9 = value;
            }
        }

        public string SudokuGrid10
        {
            get
            {
                return sudokuGrid10;
            }
            set
            {
                sudokuGrid10 = value; this.NotifyPropertyChanged("SudokuGrid10"); m.SudokuGrid10 = value;
            }
        }

        public string SudokuGrid11
        {
            get
            {
                return sudokuGrid11;
            }
            set
            {
                sudokuGrid11 = value; this.NotifyPropertyChanged("SudokuGrid11"); m.SudokuGrid11 = value;
            }
        }

        public string SudokuGrid12
        {
            get
            {
                return sudokuGrid12;
            }
            set
            {
                sudokuGrid12 = value; this.NotifyPropertyChanged("SudokuGrid12"); m.SudokuGrid12 = value;
            }
        }

        public string SudokuGrid13
        {
            get
            {
                return sudokuGrid13;
            }
            set
            {
                sudokuGrid13 = value; this.NotifyPropertyChanged("SudokuGrid13"); m.SudokuGrid13 = value;
            }
        }

        public string SudokuGrid14
        {
            get
            {
                return sudokuGrid14;
            }
            set
            {
                sudokuGrid14 = value; this.NotifyPropertyChanged("SudokuGrid14"); m.SudokuGrid14 = value;
            }
        }

        public string SudokuGrid15
        {
            get
            {
                return sudokuGrid15;
            }
            set
            {
                sudokuGrid15 = value; this.NotifyPropertyChanged("SudokuGrid15"); m.SudokuGrid15 = value;
            }
        }

        public string SudokuGrid16
        {
            get
            {
                return sudokuGrid16;
            }
            set
            {
                sudokuGrid16 = value; this.NotifyPropertyChanged("SudokuGrid16"); m.SudokuGrid16 = value;
            }
        }

        public string SudokuGrid17
        {
            get
            {
                return sudokuGrid17;
            }
            set
            {
                sudokuGrid17 = value; this.NotifyPropertyChanged("SudokuGrid17"); m.SudokuGrid17 = value;
            }
        }

        public string SudokuGrid18
        {
            get
            {
                return sudokuGrid18;
            }
            set
            {
                sudokuGrid18 = value; this.NotifyPropertyChanged("SudokuGrid18"); m.SudokuGrid18 = value;
            }
        }

        public string SudokuGrid19
        {
            get
            {
                return sudokuGrid19;
            }
            set
            {
                sudokuGrid19 = value; this.NotifyPropertyChanged("SudokuGrid19"); m.SudokuGrid19 = value;
            }
        }

        public string SudokuGrid20
        {
            get
            {
                return sudokuGrid20;
            }
            set
            {
                sudokuGrid20 = value; this.NotifyPropertyChanged("SudokuGrid20"); m.SudokuGrid20 = value;
            }
        }

        public string SudokuGrid21
        {
            get
            {
                return sudokuGrid21;
            }
            set
            {
                sudokuGrid21 = value; this.NotifyPropertyChanged("SudokuGrid21"); m.SudokuGrid21 = value;
            }
        }

        public string SudokuGrid22
        {
            get
            {
                return sudokuGrid22;
            }
            set
            {
                sudokuGrid22 = value; this.NotifyPropertyChanged("SudokuGrid22"); m.SudokuGrid22 = value;
            }
        }

        public string SudokuGrid23
        {
            get
            {
                return sudokuGrid23;
            }
            set
            {
                sudokuGrid23 = value; this.NotifyPropertyChanged("SudokuGrid23"); m.SudokuGrid23 = value;
            }
        }

        public string SudokuGrid24
        {
            get
            {
                return sudokuGrid24;
            }
            set
            {
                sudokuGrid24 = value; this.NotifyPropertyChanged("SudokuGrid24"); m.SudokuGrid24 = value;
            }
        }

        public string SudokuGrid25
        {
            get
            {
                return sudokuGrid25;
            }
            set
            {
                sudokuGrid25 = value; this.NotifyPropertyChanged("SudokuGrid25"); m.SudokuGrid25 = value;
            }
        }

        public string SudokuGrid26
        {
            get
            {
                return sudokuGrid26;
            }
            set
            {
                sudokuGrid26 = value; this.NotifyPropertyChanged("SudokuGrid26"); m.SudokuGrid26 = value;
            }
        }

        public string SudokuGrid27
        {
            get
            {
                return sudokuGrid27;
            }
            set
            {
                sudokuGrid27 = value; this.NotifyPropertyChanged("SudokuGrid27"); m.SudokuGrid27 = value;
            }
        }

        public string SudokuGrid28
        {
            get
            {
                return sudokuGrid28;
            }
            set
            {
                sudokuGrid28 = value; this.NotifyPropertyChanged("SudokuGrid28"); m.SudokuGrid28 = value;
            }
        }

        public string SudokuGrid29
        {
            get
            {
                return sudokuGrid29;
            }
            set
            {
                sudokuGrid29 = value; this.NotifyPropertyChanged("SudokuGrid29"); m.SudokuGrid29 = value;
            }
        }

        public string SudokuGrid30
        {
            get
            {
                return sudokuGrid30;
            }
            set
            {
                sudokuGrid30 = value; this.NotifyPropertyChanged("SudokuGrid30"); m.SudokuGrid30 = value;
            }
        }

        public string SudokuGrid31
        {
            get
            {
                return sudokuGrid31;
            }
            set
            {
                sudokuGrid31 = value; this.NotifyPropertyChanged("SudokuGrid31"); m.SudokuGrid31 = value;
            }
        }

        public string SudokuGrid32
        {
            get
            {
                return sudokuGrid32;
            }
            set
            {
                sudokuGrid32 = value; this.NotifyPropertyChanged("SudokuGrid32"); m.SudokuGrid32 = value;
            }
        }

        public string SudokuGrid33
        {
            get
            {
                return sudokuGrid33;
            }
            set
            {
                sudokuGrid33 = value; this.NotifyPropertyChanged("SudokuGrid33"); m.SudokuGrid33 = value;
            }
        }

        public string SudokuGrid34
        {
            get
            {
                return sudokuGrid34;
            }
            set
            {
                sudokuGrid34 = value; this.NotifyPropertyChanged("SudokuGrid34"); m.SudokuGrid34 = value;
            }
        }

        public string SudokuGrid35
        {
            get
            {
                return sudokuGrid35;
            }
            set
            {
                sudokuGrid35 = value; this.NotifyPropertyChanged("SudokuGrid35"); m.SudokuGrid35 = value;
            }
        }

        public string SudokuGrid36
        {
            get
            {
                return sudokuGrid36;
            }
            set
            {
                sudokuGrid36 = value; this.NotifyPropertyChanged("SudokuGrid36"); m.SudokuGrid36 = value;
            }
        }

        public string SudokuGrid37
        {
            get
            {
                return sudokuGrid37;
            }
            set
            {
                sudokuGrid37 = value; this.NotifyPropertyChanged("SudokuGrid37"); m.SudokuGrid37 = value;
            }
        }

        public string SudokuGrid38
        {
            get
            {
                return sudokuGrid38;
            }
            set
            {
                sudokuGrid38 = value; this.NotifyPropertyChanged("SudokuGrid38"); m.SudokuGrid38 = value;
            }
        }

        public string SudokuGrid39
        {
            get
            {
                return sudokuGrid39;
            }
            set
            {
                sudokuGrid39 = value; this.NotifyPropertyChanged("SudokuGrid39"); m.SudokuGrid39 = value;
            }
        }

        public string SudokuGrid40
        {
            get
            {
                return sudokuGrid40;
            }
            set
            {
                sudokuGrid40 = value; this.NotifyPropertyChanged("SudokuGrid40"); m.SudokuGrid40 = value;
            }
        }

        public string SudokuGrid41
        {
            get
            {
                return sudokuGrid41;
            }
            set
            {
                sudokuGrid41 = value; this.NotifyPropertyChanged("SudokuGrid41"); m.SudokuGrid41 = value;
            }
        }

        public string SudokuGrid42
        {
            get
            {
                return sudokuGrid42;
            }
            set
            {
                sudokuGrid42 = value; this.NotifyPropertyChanged("SudokuGrid42"); m.SudokuGrid42 = value;
            }
        }

        public string SudokuGrid43
        {
            get
            {
                return sudokuGrid43;
            }
            set
            {
                sudokuGrid43 = value; this.NotifyPropertyChanged("SudokuGrid43"); m.SudokuGrid43 = value;
            }
        }

        public string SudokuGrid44
        {
            get
            {
                return sudokuGrid44;
            }
            set
            {
                sudokuGrid44 = value; this.NotifyPropertyChanged("SudokuGrid44"); m.SudokuGrid44 = value;
            }
        }

        public string SudokuGrid45
        {
            get
            {
                return sudokuGrid45;
            }
            set
            {
                sudokuGrid45 = value; this.NotifyPropertyChanged("SudokuGrid45"); m.SudokuGrid45 = value;
            }
        }

        public string SudokuGrid46
        {
            get
            {
                return sudokuGrid46;
            }
            set
            {
                sudokuGrid46 = value; this.NotifyPropertyChanged("SudokuGrid46"); m.SudokuGrid46 = value;
            }
        }

        public string SudokuGrid47
        {
            get
            {
                return sudokuGrid47;
            }
            set
            {
                sudokuGrid47 = value; this.NotifyPropertyChanged("SudokuGrid47"); m.SudokuGrid47 = value;
            }
        }

        public string SudokuGrid48
        {
            get
            {
                return sudokuGrid48;
            }
            set
            {
                sudokuGrid48 = value; this.NotifyPropertyChanged("SudokuGrid48"); m.SudokuGrid48 = value;
            }
        }

        public string SudokuGrid49
        {
            get
            {
                return sudokuGrid49;
            }
            set
            {
                sudokuGrid49 = value; this.NotifyPropertyChanged("SudokuGrid49"); m.SudokuGrid49 = value;
            }
        }

        public string SudokuGrid50
        {
            get
            {
                return sudokuGrid50;
            }
            set
            {
                sudokuGrid50 = value; this.NotifyPropertyChanged("SudokuGrid50"); m.SudokuGrid50 = value;
            }
        }

        public string SudokuGrid51
        {
            get
            {
                return sudokuGrid51;
            }
            set
            {
                sudokuGrid51 = value; this.NotifyPropertyChanged("SudokuGrid51"); m.SudokuGrid51 = value;
            }
        }

        public string SudokuGrid52
        {
            get
            {
                return sudokuGrid52;
            }
            set
            {
                sudokuGrid52 = value; this.NotifyPropertyChanged("SudokuGrid52"); m.SudokuGrid52 = value;
            }
        }

        public string SudokuGrid53
        {
            get
            {
                return sudokuGrid53;
            }
            set
            {
                sudokuGrid53 = value; this.NotifyPropertyChanged("SudokuGrid53"); m.SudokuGrid53 = value;
            }
        }

        public string SudokuGrid54
        {
            get
            {
                return sudokuGrid54;
            }
            set
            {
                sudokuGrid54 = value; this.NotifyPropertyChanged("SudokuGrid54"); m.SudokuGrid54 = value;
            }
        }

        public string SudokuGrid55
        {
            get
            {
                return sudokuGrid55;
            }
            set
            {
                sudokuGrid55 = value; this.NotifyPropertyChanged("SudokuGrid55"); m.SudokuGrid55 = value;
            }
        }

        public string SudokuGrid56
        {
            get
            {
                return sudokuGrid56;
            }
            set
            {
                sudokuGrid56 = value; this.NotifyPropertyChanged("SudokuGrid56"); m.SudokuGrid56 = value;
            }
        }

        public string SudokuGrid57
        {
            get
            {
                return sudokuGrid57;
            }
            set
            {
                sudokuGrid57 = value; this.NotifyPropertyChanged("SudokuGrid57"); m.SudokuGrid57 = value;
            }
        }

        public string SudokuGrid58
        {
            get
            {
                return sudokuGrid58;
            }
            set
            {
                sudokuGrid58 = value; this.NotifyPropertyChanged("SudokuGrid58"); m.SudokuGrid58 = value;
            }
        }

        public string SudokuGrid59
        {
            get
            {
                return sudokuGrid59;
            }
            set
            {
                sudokuGrid59 = value; this.NotifyPropertyChanged("SudokuGrid59"); m.SudokuGrid59 = value;
            }
        }

        public string SudokuGrid60
        {
            get
            {
                return sudokuGrid60;
            }
            set
            {
                sudokuGrid60 = value; this.NotifyPropertyChanged("SudokuGrid60"); m.SudokuGrid60 = value;
            }
        }

        public string SudokuGrid61
        {
            get
            {
                return sudokuGrid61;
            }
            set
            {
                sudokuGrid61 = value; this.NotifyPropertyChanged("SudokuGrid61"); m.SudokuGrid61 = value;
            }
        }

        public string SudokuGrid62
        {
            get
            {
                return sudokuGrid62;
            }
            set
            {
                sudokuGrid62 = value; this.NotifyPropertyChanged("SudokuGrid62"); m.SudokuGrid62 = value;
            }
        }

        public string SudokuGrid63
        {
            get
            {
                return sudokuGrid63;
            }
            set
            {
                sudokuGrid63 = value; this.NotifyPropertyChanged("SudokuGrid63"); m.SudokuGrid63 = value;
            }
        }

        public string SudokuGrid64
        {
            get
            {
                return sudokuGrid64;
            }
            set
            {
                sudokuGrid64 = value; this.NotifyPropertyChanged("SudokuGrid64"); m.SudokuGrid64 = value;
            }
        }

        public string SudokuGrid65
        {
            get
            {
                return sudokuGrid65;
            }
            set
            {
                sudokuGrid65 = value; this.NotifyPropertyChanged("SudokuGrid65"); m.SudokuGrid65 = value;
            }
        }

        public string SudokuGrid66
        {
            get
            {
                return sudokuGrid66;
            }
            set
            {
                sudokuGrid66 = value; this.NotifyPropertyChanged("SudokuGrid66"); m.SudokuGrid66 = value;
            }
        }

        public string SudokuGrid67
        {
            get
            {
                return sudokuGrid67;
            }
            set
            {
                sudokuGrid67 = value; this.NotifyPropertyChanged("SudokuGrid67"); m.SudokuGrid67 = value;
            }
        }

        public string SudokuGrid68
        {
            get
            {
                return sudokuGrid68;
            }
            set
            {
                sudokuGrid68 = value; this.NotifyPropertyChanged("SudokuGrid68"); m.SudokuGrid68 = value;
            }
        }

        public string SudokuGrid69
        {
            get
            {
                return sudokuGrid69;
            }
            set
            {
                sudokuGrid69 = value; this.NotifyPropertyChanged("SudokuGrid69"); m.SudokuGrid69 = value;
            }
        }

        public string SudokuGrid70
        {
            get
            {
                return sudokuGrid70;
            }
            set
            {
                sudokuGrid70 = value; this.NotifyPropertyChanged("SudokuGrid70"); m.SudokuGrid70 = value;
            }
        }

        public string SudokuGrid71
        {
            get
            {
                return sudokuGrid71;
            }
            set
            {
                sudokuGrid71 = value; this.NotifyPropertyChanged("SudokuGrid71"); m.SudokuGrid71 = value;
            }
        }

        public string SudokuGrid72
        {
            get
            {
                return sudokuGrid72;
            }
            set
            {
                sudokuGrid72 = value; this.NotifyPropertyChanged("SudokuGrid72"); m.SudokuGrid72 = value;
            }
        }

        public string SudokuGrid73
        {
            get
            {
                return sudokuGrid73;
            }
            set
            {
                sudokuGrid73 = value; this.NotifyPropertyChanged("SudokuGrid73"); m.SudokuGrid73 = value;
            }
        }

        public string SudokuGrid74
        {
            get
            {
                return sudokuGrid74;
            }
            set
            {
                sudokuGrid74 = value; this.NotifyPropertyChanged("SudokuGrid74"); m.SudokuGrid74 = value;
            }
        }

        public string SudokuGrid75
        {
            get
            {
                return sudokuGrid75;
            }
            set
            {
                sudokuGrid75 = value; this.NotifyPropertyChanged("SudokuGrid75"); m.SudokuGrid75 = value;
            }
        }

        public string SudokuGrid76
        {
            get
            {
                return sudokuGrid76;
            }
            set
            {
                sudokuGrid76 = value; this.NotifyPropertyChanged("SudokuGrid76"); m.SudokuGrid76 = value;
            }
        }

        public string SudokuGrid77
        {
            get
            {
                return sudokuGrid77;
            }
            set
            {
                sudokuGrid77 = value; this.NotifyPropertyChanged("SudokuGrid77"); m.SudokuGrid77 = value;
            }
        }

        public string SudokuGrid78
        {
            get
            {
                return sudokuGrid78;
            }
            set
            {
                sudokuGrid78 = value; this.NotifyPropertyChanged("SudokuGrid78"); m.SudokuGrid78 = value;
            }
        }

        public string SudokuGrid79
        {
            get
            {
                return sudokuGrid79;
            }
            set
            {
                sudokuGrid79 = value; this.NotifyPropertyChanged("SudokuGrid79"); m.SudokuGrid79 = value;
            }
        }

        public string SudokuGrid80
        {
            get
            {
                return sudokuGrid80;
            }
            set
            {
                sudokuGrid80 = value; this.NotifyPropertyChanged("SudokuGrid80"); m.SudokuGrid80 = value;
            }
        }

        public string SudokuGrid81
        {
            get
            {
                return sudokuGrid81;
            }
            set
            {
                sudokuGrid81 = value; this.NotifyPropertyChanged("SudokuGrid81"); m.SudokuGrid81 = value;
            }
        }
        public string GenerateNumber
        {
            get
            {
                return generateNumber;
            }
            set
            {
                generateNumber = value;
                this.NotifyPropertyChanged("GenerateNumber"); m.GenerateNumber = value;
            }
        }
        public System.Windows.Visibility LoadHide
        {
            get
            {
                return loadHide;
            }
            set
            {
                loadHide = value;
                this.NotifyPropertyChanged("LoadHide"); m.LoadHide = value;
            }
        }

        public System.Windows.Visibility GenerateHide
        {
            get
            {
                return generateHide;
            }
            set
            {
                generateHide = value;
                this.NotifyPropertyChanged("GenerateHide"); m.GenerateHide = value;
            }
        }
        public System.Windows.Visibility SubmitHide
        {
            get
            {
                return submitHide;
            }
            set
            {
                submitHide = value;
                this.NotifyPropertyChanged("SubmitHide"); m.SubmitHide = value;
            }
        }

        public System.Windows.Visibility CreateHide
        {
            get
            {
                return createHide;
            }
            set
            {
                createHide = value;
                this.NotifyPropertyChanged("CreateHide"); m.CreateHide = value;
            }
        }
        ICommand createNewPuzzleClickCommand;
        public RelayCommand CreateNewPuzzle
        {
            get
            {
                //GetDatais a method for your action on click event
                return new RelayCommand(CreateDaPuzzle);
            }
        }

        public RelayCommand GenerateSeed
        {
            get
            {
                //GetDatais a method for your action on click event
                return new RelayCommand(GenerateDaSeed);
            }
        }

        public RelayCommand LoadSeed
        {
            get
            {
                //GetDatais a method for your action on click event
                return new RelayCommand(LoadDaSeed);
            }
        }

        public event PropertyChangedEventHandler propertychange;
        public void NotifyPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        protected void CreateDaPuzzle()
        {
            Type modelType = Type.GetType("SudokuPuzzle.Model.MainSudokuModel");
            ConstructorInfo modelConstructor = modelType.GetConstructor(Type.EmptyTypes);
            object modelObject = modelConstructor.Invoke(new object[] { });
            PropertyInfo[] test2 = this.GetType().GetProperties();
            CreateSudoku cS = new CreateSudoku();
            string[,] finalPuzzle = cS.CreateSudokuPuzzle();
            int cellNumber = 1;
            for (int i = 0; i < finalPuzzle.GetLength(0); i++)
            {
                for (int j = 0; j < finalPuzzle.GetLength(1); j++)
                {
                    for (int k = 0; k < test2.Count(); k++)
                    {
                        if (test2[k].Name == "SudokuGrid" + cellNumber.ToString())
                        {
                            if (finalPuzzle[i, j] != "-")
                            {
                                MethodInfo teststst = test2[k].GetSetMethod();
                                teststst.Invoke(this, new object[] { finalPuzzle[i, j] });
                            }
                            else
                            {
                                if (test2[k].Name == "SudokuGrid" + cellNumber.ToString())
                                {
                                    MethodInfo teststst = test2[k].GetSetMethod();
                                    teststst.Invoke(this, new object[] { "" });
                                }
                            }
                        }
                    }
                    cellNumber++;
                }
            }
            CreateHide = System.Windows.Visibility.Hidden;
            SubmitHide = System.Windows.Visibility.Visible;
        }

        protected void GenerateDaSeed()
        {
            int genNum = 0;
            if (int.TryParse(m.GenerateNumber, out genNum))
            {
                SeedListWindow seed = new SeedListWindow(genNum);
                seed.ShowDialog();
            }
        }

        protected void LoadDaSeed()
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
            Random r = new Random();
            int seedNum = r.Next(list.Count - 1);
            string[] numList = list[seedNum].Split(',');
            Type modelType = Type.GetType("SudokuPuzzle.Model.MainSudokuModel");
            ConstructorInfo modelConstructor = modelType.GetConstructor(Type.EmptyTypes);
            object modelObject = modelConstructor.Invoke(new object[] { });
            PropertyInfo[] test2 = this.GetType().GetProperties();
            CreateSudoku cS = new CreateSudoku();

            int cellNumber = 1;
            for (int i = 0; i < numList.Length - 1; i++)
            {
                for (int k = 0; k < test2.Count(); k++)
                {
                    if (test2[k].Name == "SudokuGrid" + cellNumber.ToString())
                    {
                        if (numList[i] != "-")
                        {
                            MethodInfo teststst = test2[k].GetSetMethod();
                            teststst.Invoke(this, new object[] { numList[i] });
                        }
                        else
                        {
                            MethodInfo teststst = test2[k].GetSetMethod();
                            teststst.Invoke(this, new object[] { "" });
                        }
                    }
                }
                cellNumber++;
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
