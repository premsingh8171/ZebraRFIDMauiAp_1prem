using ZebraRFIDMauiAp_1.Models;

namespace ZebraRFIDMauiAp_1.Views;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class InventoryList : ContentPage
{
    private InventoryListModel viewmodel;

    public InventoryList()
    {
        InitializeComponent();
        BindingContext = viewmodel = new InventoryListModel();
        Title = "Item inventory";
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