using XLabs.Forms.Mvvm;

namespace PMA.CrossPlatform.ViewModels
{
    public class BaseViewModel : ViewModel
    {
        private string _title = string.Empty;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string _subtitle = string.Empty;
        public string Subtitle
        {
            get { return _subtitle; }
            set { SetProperty(ref _subtitle, value); }
        }

        private string _icon = string.Empty;
        public string Icon
        {
            get { return _icon; }
            set { SetProperty(ref _icon, value); }
        }
    }
}
