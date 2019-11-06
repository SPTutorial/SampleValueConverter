using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleValueConverter
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            List<Data> myData = new List<Data>();
            myData.Add(new Data { Name = "This is red color", ColorNumber = 1 });
            myData.Add(new Data { Name = "This is blue color", ColorNumber = 4 });
            myData.Add(new Data { Name = "This is green color", ColorNumber = 2 });
            myData.Add(new Data { Name = "This is violate color", ColorNumber = 5 });
            myData.Add(new Data { Name = "This is orange color ", ColorNumber = 3 });

            listData.ItemsSource = myData;
        }
    }
    public class Data
    {
        public string Name { get; set; }
        public int ColorNumber { get; set; }
    }
}
