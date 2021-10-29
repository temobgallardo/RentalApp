using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System.Threading.Tasks;

namespace Litio.P.RentalApp.ViewModels
{
    public class ViewModelBase : BindableBase, IInitialize, INavigationAware, IDestructible
    {
        protected INavigationService NavigationService { get; private set; }

        private string _title;
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public DelegateCommand<string> NavigateCommand { get; set; }
        public DelegateCommand GoHomeCommand { get; set; }

        public ViewModelBase(INavigationService navigationService)
        {
            NavigationService = navigationService;
            Title = GetType().Name.Replace("ViewModel", string.Empty);
            NavigateCommand = new DelegateCommand<string>(OnNavigateCommandExecuted);
            GoHomeCommand = new DelegateCommand(OnGoHomeCommandExecuted);
        }

        public virtual void Initialize(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {

        }

        public virtual void Destroy()
        {

        }

        protected virtual async void OnNavigateCommandExecuted(string path)
        {
            var result = await NavigationService.NavigateAsync(path);
            if (!result.Success)
            {
                System.Diagnostics.Debugger.Break();
            }
        }

        protected virtual async void OnGoHomeCommandExecuted()
        {
            var result = await NavigationService.NavigateAsync("/NavigationPage/MainPage");
            if (!result.Success)
            {
                System.Diagnostics.Debugger.Break();
            }
        }
    }
}
