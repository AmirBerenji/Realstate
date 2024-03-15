using Realstate.ViewModel;

namespace Realstate.View;

public partial class LandingPage : ContentPage
{
	public LandingPage()
	{
		InitializeComponent();
		BindingContext = new LandingViewModel();
	}
}