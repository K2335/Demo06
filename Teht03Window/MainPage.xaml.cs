using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Teht03Window
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void laske_Click(object sender, RoutedEventArgs e)
        {
            int ikkunanleveys = int.Parse(ikkunanleveysBox.Text);
            int ikkunankorkeus = int.Parse(ikkunankorkeusBox.Text);
            int karmipuunleveys = int.Parse(karmipuunleveysBox.Text);


            int area = ikkunanleveys * ikkunankorkeus;
            ikkunanpintaalaBox.Text = area.ToString();


            int glassarea = (ikkunanleveys - karmipuunleveys * 2) * (ikkunankorkeus - karmipuunleveys * 2);
            lasinpintaalaBox.Text = glassarea.ToString();


            int perimeter = ikkunanleveys * 2 + ikkunankorkeus * 2;
            karminpiiriBox.Text = perimeter.ToString();
        }
    }
}
