
using Autofac;
using Xamarin.Forms;

namespace iTimMobile.Modules.MainModule
{
    public partial class MainShell : Shell
    {
        public MainShell()
        {
            InitializeComponent();
            BindingContext = App.Container.Resolve<MainShellViewModel>();
        }
    }
}
