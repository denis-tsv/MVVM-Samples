using CommunityToolkit.Mvvm.ComponentModel;
using MvvmSample.Core.Models;

namespace MvvmSample.Core.ViewModels.Widgets;

/// <summary>
/// A viewmodel for a post widget.
/// </summary>
public class PostWidgetNoMessageViewModel : ObservableObject
{
    private Post? post;

    /// <summary>
    /// Gets the currently selected post, if any.
    /// </summary>
    public Post? Post
    {
        get => post;
        set => SetProperty(ref post, value);
    }
}

