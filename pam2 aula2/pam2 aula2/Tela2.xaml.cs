namespace pam2_aula2;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

    private void btnVoltar_Clicked(object sender, EventArgs e)
    {
		this.Navigation.PopAsync();
    }
}