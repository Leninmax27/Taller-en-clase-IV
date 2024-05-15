namespace Trabajo_en_clase;

public partial class Stack : ContentPage
{
	public Stack()
	{
		InitializeComponent();
	}
    private void OnFinalButtonClick(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Flex());
    }


}