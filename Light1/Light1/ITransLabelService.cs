using System;
using Xamarin.Forms;
using SkiaSharp;
using SkiaSharp.Views.Forms;
namespace Light1
{
    public interface ITransLabelService
    {
        void TransModel(Label label);
        void TransVersion(Label label);
        void TransColor(object sender, SKPaintSurfaceEventArgs e);
    }
}
