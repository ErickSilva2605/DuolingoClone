using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DuolingoClone.Controls;
using DuolingoClone.iOS.Controls;
using DuolingoClone.iOS.Renderers;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CircularProgressBar), typeof(CircularProgressBarRenderer))]
namespace DuolingoClone.iOS.Renderers
{
    public class CircularProgressBarRenderer : ViewRenderer<CircularProgressBar, CircularProgressBarIOS>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<CircularProgressBar> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                var nativeControl = new CircularProgressBarIOS(
                    Element.WidthRequest,
                    Element.HeightRequest
                );
                SetNativeControl(nativeControl);
            }
        }
    }
}