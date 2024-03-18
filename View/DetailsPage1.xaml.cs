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
		SetViewPositions();


		Loaded += (s, e) =>
		{
			FadeAndScale(detailsBtn);
			RotateView(detailsBtn);
			FadeAndTranslate(imageView);

			Task.Delay(500);

			FadeAndTranslate(popView, 1000, 1000);
			FadeAndTranslate(addressView, 100, 100);
			FadeAndScale(buyBtn,1000,1000);

		};
    }

	private void SetViewPositions()
	{
		detailsBtn.Opacity = 0;
		detailsBtn.Scale = 0.2;
		detailsBtn.Rotation = 300;

		imageView.TranslationX = 300;
		imageView.Opacity = 0;


		addressView.TranslationX = addressView.TranslationY = -30;
		addressView.Opacity = 0;


		buyBtn.Opacity = 0;
		buyBtn.Scale = 0.2;

		popView.TranslationY = 300;
		popView.Opacity = 0.5;
		
	}

	private void FadeAndTranslate(VisualElement view, uint fadeLength = 1000, uint translateLength = 1500)
	{
		view.FadeTo(1, fadeLength, Easing.SinInOut);
		view.TranslateTo(0,0, translateLength,Easing.SinInOut);
	}

	private void FadeAndScale(VisualElement view, uint fadeLength = 1000, uint scaleLength = 1500)
	{
		view.FadeTo(1, fadeLength, Easing.SinInOut);
		view.ScaleTo(1,scaleLength, Easing.SinInOut);
	}

	private void RotateView(VisualElement view) => view.RotateTo(0,1500,Easing.SinInOut);
}