using ZebraRFIDMauiAp_1.ViewModels;

namespace ZebraRFIDMauiAp_1.Views;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class TriggerMapping : ContentPage
{
    private TriggerMappingViewModel viewModel;
    public TriggerMapping()
    {
        InitializeComponent();
        BindingContext = viewModel = new TriggerMappingViewModel();
        Title = "Trigger Key Mapping";
    }
    private void ButtonApplyClicked(object sender, EventArgs e)
    {
        viewModel.ButtonApplyClicked();
    }
}