namespace Trabajo_en_clase;

public partial class Flex : ContentPage
{
    public Flex()
    {
        InitializeComponent();
    }
    private void ButtonS(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Absolute());
    }
}