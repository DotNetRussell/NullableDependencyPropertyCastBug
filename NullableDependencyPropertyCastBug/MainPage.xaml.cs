using Windows.UI.Xaml.Controls;
namespace NullableDependencyPropertyCastBug
{
    public sealed partial class MainPage : Page
    {
        public decimal? ViewModelTestDecimal { get; set; }

        public MainPage()
        {
            this.InitializeComponent();
            this.DataContext = this;
        }
    }
}
