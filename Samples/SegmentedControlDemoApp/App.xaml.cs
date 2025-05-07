using SegmentedControlDemoApp.Views;

namespace SegmentedControlDemoApp
{
    public partial class App : Application
    {
        public App(IServiceProvider serviceProvider)
        {
            this.InitializeComponent();

            var mainPage = serviceProvider.GetRequiredService<MainPage>();
            var testpage1 = serviceProvider.GetRequiredService<Test1Page>();
            var testpage2 = serviceProvider.GetRequiredService<Test2Page>();
            var testpage3 = serviceProvider.GetRequiredService<Test3Page>();
            var testpage4 = serviceProvider.GetRequiredService<Test4Page>();
            var testpage5 = serviceProvider.GetRequiredService<Test5Page>();
            mainPage.Children.Add(testpage1);
            mainPage.Children.Add(testpage2);
            mainPage.Children.Add(testpage3);
            mainPage.Children.Add(testpage4);
            mainPage.Children.Add(testpage5);
            this.MainPage = new NavigationPage(mainPage);
        }
    }
}
