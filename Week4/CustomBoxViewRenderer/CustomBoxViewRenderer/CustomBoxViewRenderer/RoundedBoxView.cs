using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CustomBoxViewRenderer
{
    class RoundedBoxView : BoxView
    {
        public static readonly BindableProperty CornerRadiusProperty =
            BindableProperty.Create<RoundedBoxView, double>(p => p.CornerRadius, 0);

        public double CornerRadius
        {
            get { return (double)base.GetValue(CornerRadiusProperty);}
            set { base.SetValue(CornerRadiusProperty, value);}
        }

        public static readonly BindableProperty StrokeProperty =
            BindableProperty.Create<RoundedBoxView, Color>(
                p => p.Stroke, Color.Transparent);

        public Color Stroke
        {
            get { return (Color)GetValue(StrokeProperty); }
            set { SetValue(StrokeProperty, value); }
        }

        public static readonly BindableProperty StrokeThicknessProperty =
            BindableProperty.Create<RoundedBoxView, double>(
                p => p.StrokeThickness, default(double));

        public double StrokeThickness
        {
            get { return (double)GetValue(StrokeThicknessProperty); }
            set { SetValue(StrokeThicknessProperty, value); }
        }
    }
}
