namespace Trabajo_en_clase;

public partial class Absolute : ContentPage
{
	public Absolute()
	{
		InitializeComponent();
	}
    private void OnFinalButtonClick(object sender, EventArgs e)
    {
        Navigation.PopToRootAsync();
    }

}