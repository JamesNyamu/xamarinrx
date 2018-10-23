using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;
using MobileBanking.ViewModels.Home;
using ReactiveUI;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileBanking.Views.Home
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : BaseContentPage<HomeViewModel>
	{
	    public HomePage()
	    {
	        InitializeComponent();

	        this.WhenActivated(
	            disposables =>
	            {
	                this
	                    .BindCommand(ViewModel, vm => vm.PushPage, v => v.PushPageButton)
	                    .DisposeWith(disposables);
	                this
	                    .BindCommand(ViewModel, vm => vm.PushModalWithNav, v => v.PushModalWithNavButton)
	                    .DisposeWith(disposables);
	                this
	                    .BindCommand(ViewModel, vm => vm.PushModalWithoutNav, v => v.PushModalWithoutNavButton)
	                    .DisposeWith(disposables);
	                this
	                    .Bind(ViewModel, vm => vm.PopCount, v => v.PopCountEntry.Text)
	                    .DisposeWith(disposables);
	                this
	                    .BindCommand(ViewModel, vm => vm.PopPages, v => v.PopPagesButton)
	                    .DisposeWith(disposables);
	                this
	                    .Bind(ViewModel, vm => vm.PageIndex, v => v.PageIndexEntry.Text)
	                    .DisposeWith(disposables);
	                this
	                    .BindCommand(ViewModel, vm => vm.PopToNewPage, v => v.PopToNewPageButton)
	                    .DisposeWith(disposables);
	                this
	                    .OneWayBind(ViewModel, vm => vm.PageCount, v => v.PageCountLabel.Text)
	                    .DisposeWith(disposables);
	            });
	    }
	}
}