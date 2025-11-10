using System.Threading.Tasks;

namespace MauiAppHotel.Views;

public partial class DescricaoSuites : ContentPage
{
	public DescricaoSuites()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}