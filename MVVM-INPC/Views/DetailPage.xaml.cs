using MVVM_INPC.ViewModels;

namespace MVVM_INPC.Views;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}