using CommunityToolkit.Maui.Views;

namespace PopUpTest;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	protected override void OnAppearing()
	{
		//DisplayPopup();
	}

		private void OnCounterClicked(object sender, EventArgs e)
	{
		DisplayPopup();
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

	public void DisplayPopup()
	{
		var popup = new SimplePopup();

		this.ShowPopup(popup);
	}
}

