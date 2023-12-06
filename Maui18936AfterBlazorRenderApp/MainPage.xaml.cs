
namespace Maui18936AfterBlazorRenderApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage(FirstRazorLayoutRenderedService firstRazorLayoutRenderedService)
        {
            InitializeComponent();

            firstRazorLayoutRenderedService.FirstRazorLayoutRendered += FirstRazorLayoutRenderedService_FirstRazorLayoutRendered;
        }

        private void FirstRazorLayoutRenderedService_FirstRazorLayoutRendered(object? sender, EventArgs e)
        {
            DisplayAlert("First Razor Layout Rendered", "The first Razor layout has been rendered.", "OK");
        }
    }
}
