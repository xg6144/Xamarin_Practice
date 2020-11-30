using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SkiaSharp;
using SkiaSharp.Views.Forms;

namespace Light1
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        bool timerRun = false;
        public MainPage()
        {
            InitializeComponent();
            DependencyService.Get<ITransLabelService>().TransModel(LightText);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!timerRun)
            {
                timerRun = true;
                Device.StartTimer(TimeSpan.FromMilliseconds(300), timerCalled);
            }
        }
        private void btnQuit_Clicked(object sender, EventArgs e)
        {
            if (timerRun)
            {
                timerRun = false;
            }

            System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
        }
        private void btnStop_Clicked(object sender, EventArgs e)
        {
            if (timerRun)
            {
                timerRun = false;
            }
        }
        private bool timerCalled()
        {
            return timerRun;
        }

        public Label GetLabel()
        {
            return LightText;
        }

        private void canvasView_PaintSurface(object sender, SKPaintSurfaceEventArgs e)
        {
            DependencyService.Get<ITransLabelService>().TransColor(sender, e);
        
        }
    }
}
