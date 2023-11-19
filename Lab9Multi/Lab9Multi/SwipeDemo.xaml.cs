using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab9Multi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwipeDemo : ContentPage
    {
        public SwipeDemo()
        {
            InitializeComponent();
        }
        void OnSwiped(object sender, SwipedEventArgs e)
        {
            string direccion = e.Direction.ToString();
            if(direccion == "Right")
                ((BoxView)sender).BackgroundColor = Color.Red;
            if (direccion == "Left")
                ((BoxView)sender).BackgroundColor = Color.Blue;
            if (direccion == "Up")
                ((BoxView)sender).BackgroundColor = Color.Violet;
            if (direccion == "Down")
                ((BoxView)sender).BackgroundColor = Color.Orange;

            _label.Text = $"You swiped: {e.Direction.ToString()}";
        }
    }
}