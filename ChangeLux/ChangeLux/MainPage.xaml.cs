using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SkiaSharp;
using SkiaSharp.Views.Forms;

namespace ChangeLux
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            DependencyService.Get<ITransLabelService>().TransModel(LightText);
            DependencyService.Get<ITransLabelService>().TransDes(Description);
        }

        

        public Label GetLabel()
        {
            return LightText;
        }
    }
}