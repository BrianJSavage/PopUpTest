using CommunityToolkit.Maui.Views;

namespace PopUpTest;

public partial class SimplePopup : Popup
{
	public SimplePopup()
	{
		InitializeComponent();
	}

	void OnOKButtonClicked(object? sender, EventArgs e) => Close();
}