using DuolingoClone.ViewModels;
using DuolingoClone.Views;
using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using Xamarin.Forms;

namespace DuolingoClone
{
    public partial class App : PrismApplication
    {
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : this(initializer, true) { }

        public App(IPlatformInitializer initializer, bool setFormsDependencyResolver) : base(initializer, setFormsDependencyResolver) { }


        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync("MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<LessonsView, LessonsViewModel>();
            containerRegistry.RegisterForNavigation<TrainingView, TrainingViewModel>();
            containerRegistry.RegisterForNavigation<ProfileView, ProfileViewModel>();
            containerRegistry.RegisterForNavigation<RankingView, RankingViewModel>();
            containerRegistry.RegisterForNavigation<StoreView, StoreViewModel>();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
