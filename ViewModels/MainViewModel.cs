namespace CMTestApp.ViewModels
{
    using Caliburn.Micro;
    using System.Windows;
    class MainViewModel : PropertyChangedBase
    {
        private const string WindowTitleDefault = "So. Just Note It";
        private string _WindowTitle = WindowTitleDefault;
        public string WindowTitle
        {
            get { return _WindowTitle; }
            set 
            {
                _WindowTitle = value;
                NotifyOfPropertyChange(() => WindowTitle);
            }
        }


        public MainViewModel()
        {
            this.WindowTitle = "yeppers";
        }
    }
}
