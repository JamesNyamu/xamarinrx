using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI;
using Splat;

namespace MobileBanking.ViewModels
{
    public class ViewModelBase : ReactiveObject, IRoutableViewModel, ISupportsActivation, IScreen
    {
        public string UrlPathSegment { get; protected set; }

        public IScreen HostScreen { get; protected set; }

        public ViewModelActivator Activator => ViewModelActivator;

        protected readonly ViewModelActivator ViewModelActivator = new ViewModelActivator();

        public ViewModelBase(IScreen hostScreen = null)
        {
            HostScreen = hostScreen ?? Locator.Current.GetService<IScreen>();
        }

        public RoutingState Router { get; set; }
    }
}
