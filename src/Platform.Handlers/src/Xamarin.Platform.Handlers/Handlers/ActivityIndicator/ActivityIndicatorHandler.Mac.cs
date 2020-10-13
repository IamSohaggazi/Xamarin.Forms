﻿using AppKit;
using CoreGraphics;

namespace Xamarin.Platform.Handlers
{
	public partial class ActivityIndicatorHandler : AbstractViewHandler<IActivityIndicator, NSProgressIndicator>
	{
		protected override NSProgressIndicator CreateView()
		{
			return new NSProgressIndicator(CGRect.Empty) { Style = NSProgressIndicatorStyle.Spinning };
		}
	}
}