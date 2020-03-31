using Android.Content;
using Android.Content.Res;
using Android.Graphics.Drawables;
using DuolingoClone.Controls;
using DuolingoClone.Droid.Renderers;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using AW = Android.Widget;

[assembly: ExportRenderer(typeof(HorizontalProgressBar), typeof(HorizontalProgressBarRenderer))]
namespace DuolingoClone.Droid.Renderers
{
    public class HorizontalProgressBarRenderer : ViewRenderer<HorizontalProgressBar, AW.ProgressBar>
    {
        private const int PROGRESS_MAX_VALUE = 100;
        public HorizontalProgressBarRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<HorizontalProgressBar> e)
        {
            base.OnElementChanged(e);

            if (Control is null)
            {
                var nativeControl = new AW.ProgressBar(
                    Context,
                    null,
                    Android.Resource.Attribute.ProgressBarStyleHorizontal
                 );

                nativeControl.SetBackground(GetHorizontalTrack(Element.TrackColor.ToAndroid()));
                nativeControl.ProgressDrawable = GetHorizontalProgress(Element.ProgressColor.ToAndroid());
                nativeControl.Max = PROGRESS_MAX_VALUE;
                nativeControl.Progress = GetProgress(Element.Progress);

                SetNativeControl(nativeControl);
            }
        }

        private Drawable GetHorizontalTrack(Android.Graphics.Color color)
        {
            var drawable = Context.GetDrawable(Resource.Drawable.horizontal_track_bar) as GradientDrawable;
            drawable.SetColor(ColorStateList.ValueOf(color));
            return drawable;
        }

        private Drawable GetHorizontalProgress(Android.Graphics.Color color)
        {
            var scale = Context.GetDrawable(Resource.Drawable.horizontal_progress_bar) as ScaleDrawable;

            var drawable = scale.Drawable as GradientDrawable;
            drawable.SetColor(ColorStateList.ValueOf(color));

            return scale;
        }

        private int GetProgress(double progress)
        {
            return Convert.ToInt32(
                Math.Floor(progress * PROGRESS_MAX_VALUE)
            );
        }
    }
}