using System;
using FinalProjectWeek4.iOS.Effects;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("XamarinWorkShopINTEC")]
[assembly: ExportEffect(typeof(MyIOSFontLabelEffect), "FontEffect")]
namespace FinalProjectWeek4.iOS.Effects
{
	public class MyIOSFontLabelEffect : PlatformEffect
	{
		UIFont oldFont;

		protected override void OnAttached()
		{
			if (Element is Label == false)
				return;

			var label = Control as UILabel;

			oldFont = label.Font;

			label.Font = UIFont.FromName("Pacifico", label.Font.PointSize);
		}

		protected override void OnDetached()
		{
			if (oldFont != null)
			{
				var label = Control as UILabel;
				label.Font = oldFont;
			}
		}
		protected override void OnElementPropertyChanged(System.ComponentModel.PropertyChangedEventArgs args)
		{
			base.OnElementPropertyChanged(args);
		}
	}
}
