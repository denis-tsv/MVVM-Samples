﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using MvvmSample.Core.ViewModels.Widgets.NoMessages;
using Windows.UI.Xaml.Controls;

namespace MvvmSampleUwp.Views.Widgets
{
    public sealed partial class PostWidget : UserControl
    {
        public PostWidget()
        {
            this.InitializeComponent();
        }

        public PostWidgetViewModel ViewModel => DataContext as PostWidgetViewModel;
    }
}