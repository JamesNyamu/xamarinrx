using MobileBanking.ViewModels;
using ReactiveUI.XamForms;

namespace MobileBanking.Views
{
    public class ContentPageBase<TViewModel> : ReactiveContentPage<TViewModel> where TViewModel : ViewModelBase
    {
    }
}