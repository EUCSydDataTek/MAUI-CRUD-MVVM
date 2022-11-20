using MVVM_INPC.ViewModels;

namespace MVVM_INPC.Views;

public partial class AddEditPage : ContentPage
{
	public AddEditPage(AddEditPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}