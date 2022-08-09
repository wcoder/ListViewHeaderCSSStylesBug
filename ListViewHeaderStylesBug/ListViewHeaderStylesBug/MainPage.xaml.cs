using Xamarin.Forms;

namespace ListViewHeaderStylesBug
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            listView.ItemsSource = MonkeyData.Monkeys;
        }
    }
}

