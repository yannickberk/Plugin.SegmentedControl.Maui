using SegmentedControlDemoApp.ViewModels;

namespace SegmentedControlDemoApp.Views
{
    public partial class MainPage : TabbedPage
    {
        public MainPage(MainViewModel mainViewModel)
        {
            this.InitializeComponent();
            this.BindingContext = mainViewModel;
        }
    }
}
