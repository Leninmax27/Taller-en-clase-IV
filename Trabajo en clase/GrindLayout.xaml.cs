using Microsoft.Maui.Controls;
using System;

namespace Trabajo_en_clase
{
    public partial class GrindLayout : ContentPage
    {
        public GrindLayout()
        {
            InitializeComponent();

           }

        private void OnFinalButtonClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Stack());
        }
    }
}
