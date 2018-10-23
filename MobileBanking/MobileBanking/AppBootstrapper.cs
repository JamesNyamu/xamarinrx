using MobileBanking.ViewModels.Home;
using MobileBanking.ViewModels.Login;
using MobileBanking.Views;
using MobileBanking.Views.Home;
using MobileBanking.Views.Login;
using ReactiveUI;
using Splat;
using System;
using Xamarin.Forms;

namespace MobileBanking
{
    public class AppBootstrapper
    {
        private readonly NavigationPage _navigationPage;

        public AppBootstrapper()
        {
            Locator.CurrentMutable.InitializeSplat();
            Locator.CurrentMutable.InitializeReactiveUI();

            RegisterViews();
            RegisterServices();

            IView mainView = new MainView(RxApp.TaskpoolScheduler, RxApp.MainThreadScheduler, ViewLocator.Current);
            _navigationPage = mainView as NavigationPage;
            IViewStackService viewStackService = new ViewStackService(mainView);
            Locator.CurrentMutable.RegisterConstant(viewStackService, typeof(IViewStackService));

            viewStackService
                .PushPage(new LoginViewModel(viewStackService))
                .Subscribe();
        }

        private void RegisterViews()
        {
            Locator.CurrentMutable.Register(() => new LoginPage(), typeof(IViewFor<ILoginViewModel>));
            Locator.CurrentMutable.Register(() => new HomePage(), typeof(IViewFor<HomeViewModel>));
        }

        private void RegisterServices()
        {
        }

        public NavigationPage GetMainView()
        {
            return _navigationPage;
        }
    }
}