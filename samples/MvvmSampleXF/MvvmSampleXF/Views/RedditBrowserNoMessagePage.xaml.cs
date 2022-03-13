using System;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvmSampleXF.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RedditBrowserNoMessagePage : ContentPage
    {
        public RedditBrowserNoMessagePage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            SubredditWidget.PostSelected += SubredditWidget_PostSelected;
            SubredditWidget.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            SubredditWidget.PostSelected -= SubredditWidget_PostSelected;
        }

        private void SubredditWidget_PostSelected(object sender, EventArgs e)
        {
            //Ugly workaround for https://github.com/xamarin/XamarinCommunityToolkit/issues/595
            MethodInfo dynMethod = RedditTabView.GetType().GetMethod("UpdateSelectedIndex", BindingFlags.NonPublic | BindingFlags.Instance);
            dynMethod?.Invoke(RedditTabView, new object[] { 1, false });
        }

    }
}