using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI;
using Splat;

namespace MobileBanking.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel()
        {
            Router = new RoutingState();
            Locator.CurrentMutable.RegisterConstant(this, typeof(IScreen));
        }
    }
}
