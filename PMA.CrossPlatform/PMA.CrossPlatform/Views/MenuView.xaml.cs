using System.Collections.Generic;
using PMA.CrossPlatform.Model;
using PMA.CrossPlatform.Model.Enum;
using PMA.CrossPlatform.ViewModels;
using Xamarin.Forms;

namespace PMA.CrossPlatform.Views
{
    public partial class MenuView : ContentPage
    {
        public MenuView(Root root)
        {
            InitializeComponent();

            BackgroundColor = Color.FromHex("#03A9F4");
            ListViewMenu.BackgroundColor = Color.FromHex("#F5F5F5");

            BindingContext = new BaseViewModel
            {
                Title = "PMA.CrossPlatform",
                Subtitle = "PMA.CrossPlatform",
                Icon = ""
            };

            var menuItems = new List<MenuViewItem>
                {
                    new MenuViewItem { Title = "Test One", MenuType = MenuType.Test, Icon ="" },
                    new MenuViewItem { Title = "Test Two", MenuType = MenuType.TestTwo, Icon = "" },
                    new MenuViewItem { Title = "Test Three", MenuType = MenuType.TestThree, Icon = "" }

                };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];

            ListViewMenu.ItemSelected += (sender, e) =>
            {
                if (ListViewMenu.SelectedItem == null) return;

                root.Navigate(((MenuViewItem)e.SelectedItem).MenuType);
            };
        }
    }
}
