using Xamarin.Forms;

namespace ListViewHeaderStylesBug
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Force refresh label.Parent to update styles:
            //var temp = headerLabel.Parent;
            //headerLabel.Parent = listView;
            //headerLabel.Parent = temp;


            listView.ItemsSource = MonkeyData.Monkeys;
        }
    }
}

