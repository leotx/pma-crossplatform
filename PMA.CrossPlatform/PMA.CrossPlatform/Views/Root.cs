using System.Collections.Generic;
using PMA.CrossPlatform.Model.Enum;
using PMA.CrossPlatform.ViewModels;
using Xamarin.Forms;
using XLabs.Forms.Mvvm;
using XLabs.Forms.Pages;

namespace PMA.CrossPlatform.Views
{
    public class Root : ExtendedMasterDetailPage
    {
        private Dictionary<MenuType, Page> Pages { get; }

        public Root()
        {
            Pages = new Dictionary<MenuType, Page>();

            CreateMenu();

            Master = new MenuView(this);

            Navigate(MenuType.Test);

            InvalidateMeasure();
        }

        private void CreateMenu()
        {
            Pages.Add(MenuType.Test, ViewFactory.CreatePage<MainViewModel, MainView>() as Page);
            Pages.Add(MenuType.TestTwo, ViewFactory.CreatePage<MainViewModel, MainView>() as Page);
            Pages.Add(MenuType.TestThree, ViewFactory.CreatePage<MainViewModel, MainView>() as Page);
        }

        public void Navigate(MenuType menuType)
        {
            Detail = Pages[menuType];
        }
    }
}
