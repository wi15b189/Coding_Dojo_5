using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Coding_Dojo_5.ViewModel
{
    public class ToyItemVm : ViewModelBase
    {
        private string description;
        private string ageRecom;
        private BitmapImage image;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public BitmapImage Image
        {
            get { return image; }
            set { image = value; }
        }

        public string AgeRecom
        {
            get { return ageRecom; }
            set { ageRecom = value; }
        }



        public ObservableCollection<ToyItemVm> Toys { get; set; }

        public void addToy(ToyItemVm toy)
        {
            if (Toys == null)
            {
                Toys = new ObservableCollection<ToyItemVm>();
            }
            Toys.Add(toy);
        }

        public ToyItemVm(string description, string ageRecom, BitmapImage image)
        {
            Description = description;
            Image = image;
            AgeRecom = ageRecom;
        }

    }
}
