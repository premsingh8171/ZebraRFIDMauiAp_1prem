using ZebraRFIDMauiAp_1.ViewModels;

namespace ZebraRFIDMauiAp_1.Views;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class LocateTag : ContentPage
{
    private LocateViewModel viewmodel;
    public LocateTag()
    {
        InitializeComponent();
        Title = "Item search";
        BindingContext = viewmodel = new LocateViewModel();
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        viewmodel.UpdateIn();
    }
    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        viewmodel.UpdateOut();
    }
}