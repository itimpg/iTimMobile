using System.Reflection;
using Autofac;
using iTimMobile.Modules;
using Xamarin.Forms;

namespace iTimMobile
{
    public partial class App : Application
    {
        public static IContainer Container;

        public App()
        {
            InitializeComponent();

            var builder = new ContainerBuilder();
            var dataAccess = Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(dataAccess)
                .AsImplementedInterfaces()
                .AsSelf();

            Container = builder.Build();

            MainPage = Container.Resolve<LoadingView>();

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
