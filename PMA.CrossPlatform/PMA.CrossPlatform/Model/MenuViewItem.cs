using PMA.CrossPlatform.Model.Enum;

namespace PMA.CrossPlatform.Model
{
    public class MenuViewItem
    {
        public MenuViewItem()
        {
            MenuType = MenuType.Test;
        }

        public string Icon { get; set; }
        public string Title { get; set; }
        public MenuType MenuType { get; set; }
    }
}
