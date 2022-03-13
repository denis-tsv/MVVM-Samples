using MvvmSample.Core.ViewModels;
using MvvmSample.Core.ViewModels.Widgets;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvmSampleXF.Views.Widgets
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PostNoMessageWidget : ContentView
    {
        public PostNoMessageWidget()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            if (BindingContext is RedditBrowserNoMessagePageViewModel pageViewModel)
                BindingContext = pageViewModel.PostWidgetViewModel;
        }

        public PostWidgetNoMessageViewModel ViewModel => (PostWidgetNoMessageViewModel)BindingContext;

    }
}