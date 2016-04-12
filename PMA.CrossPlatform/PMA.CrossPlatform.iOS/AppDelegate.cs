using Foundation;
using Ninject;
using UIKit;
using Xamarin.Forms;
using XLabs.Forms;
using XLabs.Ioc;
using XLabs.Ioc.Ninject;

namespace PMA.CrossPlatform.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : XFormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Forms.Init();

            if (!Resolver.IsSet) SetIoc();

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
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
