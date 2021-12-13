﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using MvvmSample.Core.Models;

namespace MvvmSample.Core.ViewModels.Widgets.NoMessages
{
    /// <summary>
    /// A viewmodel for a post widget.
    /// </summary>
    public sealed class PostWidgetViewModel : ObservableObject
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
}
