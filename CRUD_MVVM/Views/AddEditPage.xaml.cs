using CRUD_MVVM.ViewModels;

namespace CRUD_MVVM.Views;

public partial class AddEditPage : ContentPage
{
	public AddEditPage(AddEditPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}