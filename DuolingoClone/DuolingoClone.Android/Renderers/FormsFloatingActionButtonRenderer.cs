using Android.Content;
using Android.Support.Design.Widget;
using DuolingoClone.Controls;
using DuolingoClone.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using AppCompat = Xamarin.Forms.Platform.Android.AppCompat;

[assembly: ExportRenderer(typeof(FormsFloatingActionButton), typeof(FormsFloatingActionButtonRenderer))]
namespace DuolingoClone.Droid.Renderers
{
    public class FormsFloatingActionButtonRenderer : AppCompat.ViewRenderer<FormsFloatingActionButton, FloatingActionButton>
    {
        public FormsFloatingActionButtonRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<FormsFloatingActionButton> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                //Criar novos elementos
                var fab = new FloatingActionButton(Context);
                fab.UseCompatPadding = true;
                fab.Click += OnFabClick;

                SetNativeControl(fab);
            }
        }

        private void OnFabClick(object sender, System.EventArgs e)
        {
            Element?.Command?.Execute(null);
        }
    }
}