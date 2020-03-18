using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Views;
using Android.Widget;
using DuolingoClone.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using TabPagRenderer = Xamarin.Forms.Platform.Android.AppCompat;

[assembly: ExportRenderer(typeof(TabbedPage), typeof(CustomTabbedPageRenderer))]
namespace DuolingoClone.Droid.Renderers
{
    public class CustomTabbedPageRenderer : TabPagRenderer.TabbedPageRenderer
    {
        public CustomTabbedPageRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<TabbedPage> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                var relativeLayout = base.GetChildAt(0) as Android.Widget.RelativeLayout;
                var bottomNavigationView = relativeLayout.GetChildAt(1)as BottomNavigationView;

                var bottomNavigationHeight = bottomNavigationView.MinimumHeight;

                bottomNavigationView.SetMinimumHeight(220);
            }
        }
    }
}