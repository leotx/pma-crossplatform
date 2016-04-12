using Android.App;
using Android.Content.PM;
using Android.OS;
using Ninject;
using Xamarin.Forms;
using XLabs.Forms;
using XLabs.Ioc;
using XLabs.Ioc.Ninject;

namespace PMA.CrossPlatform.Droid
{
    [Activity(Label = "PMA.CrossPlatform", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : XFormsApplicationDroid
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Forms.Init(this, bundle);

            if (!Resolver.IsSet) SetIoc();

            LoadApplication(new App());
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