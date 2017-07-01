using System;
using Android.Graphics;
using Android.Widget;
using HomeWorkWeek4.Droid.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("XamarinWorkShopINTEC")]
[assembly: ExportEffect(typeof(MyDroidFontLabelEffect), "FontEffect")]
namespace HomeWorkWeek4.Droid.Effects
{
	public class MyDroidFontLabelEffect : PlatformEffect
	{
		Typeface oldFont;

		protected override void OnAttached()
		{
			if (Element is Label == false)
				return;

			var label = Control as TextView;

			oldFont = label.Typeface;

			var font = Typeface.CreateFromAsset(Forms.Context.Assets, "Pacifico.ttf");
			label.Typeface = font;
		}

		protected override void OnDetached()
		{
			if (oldFont != null)
			{
				var label = Control as TextView;

				label.Typeface = oldFont;
			}
		}


		protected override void OnElementPropertyChanged(System.ComponentModel.PropertyChangedEventArgs args)
		{
			base.OnElementPropertyChanged(args);
		}
	}
}
