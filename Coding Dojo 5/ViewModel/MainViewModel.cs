using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System.Collections.ObjectModel;
using System;
using System.Windows.Media.Imaging;

namespace Coding_Dojo_5.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private ToyItemVm currentCategory;
        private ObservableCollection<ToyItemVm> toyCart;
        private RelayCommand<ToyItemVm> buyBtnClickedCmd;

        public ObservableCollection<ToyItemVm> ToyCategories { get; set; }

        public ObservableCollection<ToyItemVm> ToyCart
        {
            get { return toyCart; }
            set { toyCart = value; RaisePropertyChanged(); }
        }

        public ToyItemVm CurrentCategory {
            get {
                return currentCategory;
            }
            set {
                currentCategory = value;
                RaisePropertyChanged(); }
        }


        public RelayCommand<ToyItemVm> BuyBtnClickedCmd {
            get
            {
                return buyBtnClickedCmd;
            }
            set
            {
                buyBtnClickedCmd = value;
                RaisePropertyChanged();
            }
        }

        public MainViewModel()
        {
            GenerateDemoData();

            ToyCart = new ObservableCollection<ToyItemVm>();

            BuyBtnClickedCmd = new RelayCommand<ToyItemVm>(
                (act) =>
                {
                    ToyCart.Add(act);
                },
                (act) => 
                {
                    return true;
                }
            );

            ToyCart.Add(new ToyItemVm("Lego", "-", new BitmapImage(new Uri("Images/Lego-Batman.jpg", UriKind.Relative))));
            ToyCart.Add(new ToyItemVm("Lego", "-", new BitmapImage(new Uri("Images/Lego-Batman.jpg", UriKind.Relative))));
            ToyCart.Add(new ToyItemVm("Lego", "-", new BitmapImage(new Uri("Images/Lego-Batman.jpg", UriKind.Relative))));
        }

        private void GenerateDemoData()
        {
            ToyCategories = new ObservableCollection<ToyItemVm>();
            ToyCategories.Add(new ToyItemVm("Lego", "-", new BitmapImage(new Uri("Images/Lego-Batman.jpg", UriKind.Relative))));
            ToyCategories.Add(new ToyItemVm("Playmobil", "-", new BitmapImage(new Uri("Images/playmobil-band.jpg", UriKind.Relative))));

            ToyCategories[0].addToy(new ToyItemVm("Batman", "6+", new BitmapImage(new Uri("Images/Lego-Batman.jpg", UriKind.Relative))));
            ToyCategories[0].addToy(new ToyItemVm("Joker", "8+", new BitmapImage(new Uri("Images/Lego-Joker.jpg", UriKind.Relative))));
            ToyCategories[0].addToy(new ToyItemVm("Catwoman", "8+", new BitmapImage(new Uri("Images/Lego-Catwoman.jpg", UriKind.Relative))));
            ToyCategories[0].addToy(new ToyItemVm("Batman", "6+", new BitmapImage(new Uri("Images/Lego-Batman.jpg", UriKind.Relative))));
            ToyCategories[0].addToy(new ToyItemVm("Joker", "8+", new BitmapImage(new Uri("Images/Lego-Joker.jpg", UriKind.Relative))));
            ToyCategories[0].addToy(new ToyItemVm("Catwoman", "8+", new BitmapImage(new Uri("Images/Lego-Catwoman.jpg", UriKind.Relative))));
            ToyCategories[0].addToy(new ToyItemVm("Batman", "6+", new BitmapImage(new Uri("Images/Lego-Batman.jpg", UriKind.Relative))));
            ToyCategories[0].addToy(new ToyItemVm("Joker", "8+", new BitmapImage(new Uri("Images/Lego-Joker.jpg", UriKind.Relative))));
            ToyCategories[0].addToy(new ToyItemVm("Catwoman", "8+", new BitmapImage(new Uri("Images/Lego-Catwoman.jpg", UriKind.Relative))));

            ToyCategories[1].addToy(new ToyItemVm("Band", "6+", new BitmapImage(new Uri("Images/playmobil-band.jpg", UriKind.Relative))));
            ToyCategories[1].addToy(new ToyItemVm("Elvis", "8+", new BitmapImage(new Uri("Images/playmobil-elvis.jpg", UriKind.Relative))));
            ToyCategories[1].addToy(new ToyItemVm("Rocker", "8+", new BitmapImage(new Uri("Images/playmobil-rocker.jpg", UriKind.Relative))));
            ToyCategories[1].addToy(new ToyItemVm("Band", "6+", new BitmapImage(new Uri("Images/playmobil-band.jpg", UriKind.Relative))));
            ToyCategories[1].addToy(new ToyItemVm("Elvis", "8+", new BitmapImage(new Uri("Images/playmobil-elvis.jpg", UriKind.Relative))));
            ToyCategories[1].addToy(new ToyItemVm("Rocker", "8+", new BitmapImage(new Uri("Images/playmobil-rocker.jpg", UriKind.Relative))));
        }
    }
}