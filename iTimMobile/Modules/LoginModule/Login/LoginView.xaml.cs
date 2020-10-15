
using Autofac;
using Xamarin.Forms;

namespace iTimMobile.Modules.LoginModule.Login
{
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
            BindingContext = App.Container.Resolve<LoginViewModel>();
        }
    }
}
