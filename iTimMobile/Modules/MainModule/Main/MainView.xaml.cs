using Autofac;
using Xamarin.Forms;

namespace iTimMobile.Modules.MainModule.Main
{
    public partial class MainView : ContentPage
    {
        public MainView()
        {
            InitializeComponent();
            BindingContext = App.Container.Resolve<MainViewModel>();
        }

        protected override async void OnAppearing()
        {
            await (BindingContext as MainViewModel).InitializeAsync(null);
        }
    }
}
