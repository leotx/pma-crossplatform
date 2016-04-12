using Ninject;
using PMA.CrossPlatform.ViewModels;
using PMA.CrossPlatform.Views;
using Xamarin.Forms;
using XLabs.Forms.Mvvm;
using XLabs.Ioc;
using XLabs.Ioc.Ninject;

namespace PMA.CrossPlatform
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            if (!Resolver.IsSet) SetIoc();

            RegisterViews();

            var mainPage = ViewFactory.CreatePage<MainViewModel, MainView>() as Page;

            MainPage = new NavigationPage(mainPage);
        }

        private static void RegisterViews()
        {
            ViewFactory.Register<MainView, MainViewModel>();
        }

        private static void SetIoc()
        {
            var standardKernel = new StandardKernel();

            var resolverContainer = new NinjectContainer(standardKernel);

            //standardKernel.Bind<IDevice>().ToConstant(AndroidDevice.CurrentDevice); TODO: Binds

            Resolver.SetResolver(resolverContainer.GetResolver());
        }
    }
}
