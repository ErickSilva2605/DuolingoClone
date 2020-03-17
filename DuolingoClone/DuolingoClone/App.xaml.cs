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
            containerRegistry.RegisterForNavigation<LessonsView>();
            containerRegistry.RegisterForNavigation<TrainingView>();
            containerRegistry.RegisterForNavigation<ProfileView>();
            containerRegistry.RegisterForNavigation<RankingView>();
            containerRegistry.RegisterForNavigation<StoreView>();
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
