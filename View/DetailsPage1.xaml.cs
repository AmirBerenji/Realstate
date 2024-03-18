using Realstate.ViewModel;

namespace Realstate.View;

public partial class DetailsPage1 : ContentPage
{
	public DetailsPage1(Model.Property selectedProperty)
	{
		InitializeComponent();
		var viewModel = new DetailesViewModel() { SelectedProperty = selectedProperty };
		viewModel.PropertyImages = selectedProperty.Images.Take(2).ToList();
		viewModel.MoreItems = selectedProperty.Images.Count - 2;

		BindingContext = viewModel;
	}
}