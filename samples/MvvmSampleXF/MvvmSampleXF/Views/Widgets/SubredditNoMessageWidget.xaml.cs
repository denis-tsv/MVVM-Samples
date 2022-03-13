using MvvmSample.Core.ViewModels.Widgets;
using System;
using MvvmSample.Core.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvmSampleXF.Views.Widgets
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SubredditNoMessageWidget : ContentView
    {
        public event EventHandler PostSelected;
        public SubredditNoMessageWidget()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            if (BindingContext is RedditBrowserNoMessagePageViewModel pageViewModel)
                BindingContext = pageViewModel.SubredditWidgetViewModel;
        }

        public SubredditWidgetNoMessageViewModel ViewModel => (SubredditWidgetNoMessageViewModel)BindingContext;

        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PostSelected?.Invoke(this, EventArgs.Empty);
        }

        public void OnAppearing()
        {
            ViewModel.LoadPostsCommand.Execute(null);
        }
    }
}