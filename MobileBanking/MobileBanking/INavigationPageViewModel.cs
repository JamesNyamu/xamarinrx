namespace MobileBanking.ViewModels
{
    public interface INavigationPageViewModel : IPageViewModel
    {
        BehaviorSubject<IImmutableList<IPageViewModel>> PageStack { get; set; }
    }
}