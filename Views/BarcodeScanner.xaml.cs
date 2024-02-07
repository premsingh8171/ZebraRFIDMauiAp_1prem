using ZebraRFIDMauiAp_1.ViewModels;
namespace ZebraRFIDMauiAp_1.Views;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class BarcodeScanner : ContentPage
{
    private BarcodeScannerViewModel viewmodel;
    public BarcodeScanner()
    {
        BindingContext = viewmodel = new BarcodeScannerViewModel();
        InitializeComponent();
        Title = "Barcode Scanner";
    }

    private void ClearClicked(object sender, EventArgs e)
    {
        viewmodel.ClearBarcode();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        viewmodel.UpdateBarcodeIn();
    }
    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        viewmodel.UpdateBarcodeOut();
    }
}
