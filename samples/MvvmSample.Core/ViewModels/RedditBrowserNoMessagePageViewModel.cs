using System;
using System.ComponentModel;
using System.Reactive.Linq;
using MvvmSample.Core.ViewModels.Widgets;

namespace MvvmSample.Core.ViewModels;

public class RedditBrowserNoMessagePageViewModel
{
    public RedditBrowserNoMessagePageViewModel(PostWidgetNoMessageViewModel postWidgetViewModel, SubredditWidgetNoMessageViewModel subredditWidgetViewModel)
    {
        PostWidgetViewModel = postWidgetViewModel;
        SubredditWidgetViewModel = subredditWidgetViewModel;

        var subscription = Observable.FromEventPattern<PropertyChangedEventArgs>(SubredditWidgetViewModel, nameof(INotifyPropertyChanged.PropertyChanged))
            .Where(x => x.EventArgs.PropertyName == nameof(SubredditWidgetViewModel.SelectedPost))
            .Subscribe(pattern => PostWidgetViewModel.Post = SubredditWidgetViewModel.SelectedPost);
    }

    public PostWidgetNoMessageViewModel PostWidgetViewModel { get; }
    public SubredditWidgetNoMessageViewModel SubredditWidgetViewModel { get; }

}

