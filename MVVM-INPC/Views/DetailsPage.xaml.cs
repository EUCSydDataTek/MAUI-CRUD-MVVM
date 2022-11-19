using MVVM_INPC.ViewModels;

namespace MVVM_INPC.Views;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(DetailsPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}