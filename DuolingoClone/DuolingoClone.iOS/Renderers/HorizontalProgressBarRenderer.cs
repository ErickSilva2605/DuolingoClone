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

[assembly: ExportRenderer(typeof(HorizontalProgressBar), typeof(HorizontalProgressBarRenderer))]
namespace DuolingoClone.iOS.Renderers
{
    public class HorizontalProgressBarRenderer : ViewRenderer<HorizontalProgressBar, HorizontalProgressBarIOS>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<HorizontalProgressBar> e)
        {
            base.OnElementChanged(e);

            if (Element is null)
                return;

            if (Control is null)
            {
                var nativeControl = new HorizontalProgressBarIOS(
                    Element.WidthRequest,
                    Element.HeightRequest,
                    Element.TrackColor.ToCGColor(),
                    Element.ProgressColor.ToCGColor(),
                    Element.Progress
                );

                SetNativeControl(nativeControl);
            }
        }
    }
}