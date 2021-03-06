﻿using Android.Content;
using Android.Support.Design.BottomNavigation;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using DuolingoClone.Droid.Renderers;
using DuolingoClone.Droid.Utils;
using DuolingoClone.Interfaces;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using TabPagRenderer = Xamarin.Forms.Platform.Android.AppCompat;

[assembly: ExportRenderer(typeof(TabbedPage), typeof(CustomTabbedPageRenderer))]
namespace DuolingoClone.Droid.Renderers
{
    public class CustomTabbedPageRenderer : TabPagRenderer.TabbedPageRenderer
    {
        private readonly int _minimumHeight = 220;
        private readonly int _iconSize = 130;
        private BottomNavigationView _bottomNavigationView;
        private TabbedPage _formsTabs;

        private ViewPager PagerLayout { get; set; }

        public CustomTabbedPageRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<TabbedPage> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                _formsTabs = Element;
                _formsTabs.CurrentPageChanged += OnCurrentPageChanged;

                var relativeLayout = base.GetChildAt(0) as Android.Widget.RelativeLayout;
                PagerLayout = relativeLayout.GetChildAt(0) as ViewPager;

                _bottomNavigationView = relativeLayout.GetChildAt(1) as BottomNavigationView;
                _bottomNavigationView.ItemIconTintList = null;
                _bottomNavigationView.ItemIconSize = _iconSize;
                _bottomNavigationView.SetShiftMode(false, false);
                _bottomNavigationView.LabelVisibilityMode = LabelVisibilityMode.LabelVisibilityUnlabeled;

                _bottomNavigationView.SetMinimumHeight(_minimumHeight);
                UpdateAllTabs();
            }

            if (e.OldElement != null)
            {
                _formsTabs.CurrentPageChanged -= OnCurrentPageChanged;
            }
        }

        private void OnCurrentPageChanged(object sender, EventArgs e)
        {
            UpdateAllTabs();
        }

        private void UpdateAllTabs()
        {
            for (var index = 0; index < _formsTabs.Children.Count; index++)
            {
                var androidTab = _bottomNavigationView.Menu.GetItem(index);

                if (_formsTabs.Children[index] is ITabPageIcons tabPage)
                {
                    if (_formsTabs.Children[index] == _formsTabs.CurrentPage)
                    {
                        androidTab.SetIcon(ResourcesUtil.GetIconIdByFileName(tabPage.GetSelectedIcon(), Context));
                        continue;
                    }

                    androidTab.SetIcon(ResourcesUtil.GetIconIdByFileName(tabPage.GetIcon(), Context));
                    continue;
                }
            }
        }
    }
}