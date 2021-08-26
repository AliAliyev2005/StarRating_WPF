using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WPF_Stars_User_Control.Command;

namespace WPF_Stars_User_Control.ViewModels
{
    public class StarsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<string> _imagePaths;
        private const string EmptyStarImagePath = "../Images/blank star.png";
        private const string FilledStarImagePath = "../Images/filled star.png";
        private int _filledStarCount;

        public RelayCommand FirstStarCommand { get; set; }
        public RelayCommand SecondStarCommand { get; set; }
        public RelayCommand ThirdStarCommand { get; set; }
        public RelayCommand FourthStarCommand { get; set; }
        public RelayCommand FifthStarCommand { get; set; }
        public RelayCommand DeleteAllCommand { get; set; }

        public StarsViewModel()
        {
            ImagePaths = new ObservableCollection<string>();

            for (int i = 0; i < 5; i++)
                ImagePaths.Add(EmptyStarImagePath);

            FirstStarCommand = new RelayCommand(FirstStarClicked);
            SecondStarCommand = new RelayCommand(SecondStarClicked);
            ThirdStarCommand = new RelayCommand(ThirdStarClicked);
            FourthStarCommand = new RelayCommand(FourthStarClicked);
            FifthStarCommand = new RelayCommand(FifthStarClicked);
            DeleteAllCommand = new RelayCommand(DeleteAll);
        }

        public ObservableCollection<string> ImagePaths
        {
            get { return _imagePaths; }
            set { _imagePaths = value; OnPropertyChanged(); }
        }

        public int FilledStarCount
        {
            get { return _filledStarCount; }
            set { _filledStarCount = value; OnPropertyChanged(); }
        }

        private void FirstStarClicked(object parameter = null)
        {
            ConfigureStarsWhenClickedWithFilling(1);
        }
        private void SecondStarClicked(object parameter = null)
        {
            ConfigureStarsWhenClickedWithFilling(2);
        }
        private void ThirdStarClicked(object parameter = null)
        {
            ConfigureStarsWhenClickedWithFilling(3);
        }

        private void FourthStarClicked(object parameter = null)
        {
            ConfigureStarsWhenClickedWithFilling(4);
        }

        private void FifthStarClicked(object parameter = null)
        {
            ConfigureStarsWhenClickedWithFilling(5);
        }

        private void DeleteAll(object parameter = null)
        {
            ConfigureStarsWhenClickedWithFilling(0);
        }

        private void ConfigureStarsWhenClickedWithFilling(int filledStarNumber)
        {
            for (int i = 0; i < filledStarNumber; i++)
            {
                ImagePaths[i] = FilledStarImagePath;
            }
            
            for (int i = filledStarNumber; i < ImagePaths.Count; i++)
            {
                ImagePaths[i] = EmptyStarImagePath;
            }

            FilledStarCount = filledStarNumber;
        }

        public void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
