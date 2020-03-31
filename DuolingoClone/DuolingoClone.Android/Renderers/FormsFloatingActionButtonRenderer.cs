using Android.Content;
using Android.Content.Res;
using Android.Support.Design.Widget;
using DuolingoClone.Controls;
using DuolingoClone.Droid.Renderers;
using DuolingoClone.Droid.Utils;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using AppCompat = Xamarin.Forms.Platform.Android.AppCompat;

[assembly: ExportRenderer(typeof(FormsFloatingActionButton), typeof(FormsFloatingActionButtonRenderer))]
namespace DuolingoClone.Droid.Renderers
{
    public class FormsFloatingActionButtonRenderer : AppCompat.ViewRenderer<FormsFloatingActionButton, FloatingActionButton>
    {
        private FloatingActionButton _floatingActionButton;
        public FormsFloatingActionButtonRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<FormsFloatingActionButton> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                //Criar novos elementos
                _floatingActionButton = new FloatingActionButton(Context);
                _floatingActionButton.UseCompatPadding = true;

                ConfigureDrawableIcon();
                ConfigureBackgroundColor();

                _floatingActionButton.Click += OnFabClick;

                SetNativeControl(_floatingActionButton);
            }
        }

        private void ConfigureDrawableIcon()
        {
            if (Element == null)
                return;

            var fileName = (Element.ImageSource as FileImageSource)?.File;

            if (fileName == null)
                return;

            var iconId = ResourcesUtil.GetIconIdByFileName(fileName, Context);
            _floatingActionButton.SetImageResource(iconId);
        }

        private void ConfigureBackgroundColor()
        {
            if (Element == null)
                return;

            var floatingActionButtonColor = Element.BackgroundColor.ToAndroid();
            _floatingActionButton.BackgroundTintList = ColorStateList.ValueOf(floatingActionButtonColor);
            Element.BackgroundColor = Color.Transparent;
        }

        private void OnFabClick(object sender, System.EventArgs e)
        {
            Element?.Command?.Execute(null);
        }
    }
}