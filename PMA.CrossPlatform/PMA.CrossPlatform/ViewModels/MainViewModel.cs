namespace PMA.CrossPlatform.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private string _message;

        public MainViewModel()
        {
            Message = "Hello Xamarin Forms Labs MVVM Basics!!";
        }

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }
    }
}
