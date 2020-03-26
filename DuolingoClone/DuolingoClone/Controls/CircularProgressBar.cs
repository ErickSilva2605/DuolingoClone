using Xamarin.Forms;

namespace DuolingoClone.Controls
{
    public class CircularProgressBar : View
    {
        public static readonly BindableProperty TrackColorProperty =
            BindableProperty.Create(
                nameof(TrackColor),
                typeof(Color),
                typeof(CircularProgressBar),
                Color.Transparent
            );

        public static readonly BindableProperty ProgressColorProperty =
            BindableProperty.Create(
                nameof(ProgressColor),
                typeof(Color),
                typeof(CircularProgressBar),
                Color.Transparent
            );

        public static readonly BindableProperty ProgressProperty =
            BindableProperty.Create(
                nameof(Progress),
                typeof(double),
                typeof(CircularProgressBar),
                0,0
            );

        public Color TrackColor
        {
            get => (Color)GetValue(TrackColorProperty);
            set => SetValue(TrackColorProperty, value);
        }

        public Color ProgressColor
        {
            get => (Color)GetValue(ProgressColorProperty);
            set => SetValue(ProgressColorProperty, value);
        }

        public double Progress 
        {
            get => (double)GetValue(ProgressProperty);
            set => SetValue(ProgressProperty, value);
        }
    }
}
