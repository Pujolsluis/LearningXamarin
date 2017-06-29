using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using CustomBoxViewRenderer.Droid;
using CustomBoxViewRenderer.Controls;
using Xamarin.Forms;
using Android.Graphics;

[assembly: ExportRendererAttribute(typeof(RoundedBoxView), typeof(RoundedBoxViewRenderer))]
namespace CustomBoxViewRenderer.Droid
{
    class RoundedBoxViewRenderer : BoxRenderer
    {
        public RoundedBoxViewRenderer()
        {
            this.SetWillNotDraw(false);
        }

        public override void Draw(Canvas canvas)
        {
            RoundedBoxView rbv = (RoundedBoxView)this.Element;

            Rect rc = new Rect();
            GetDrawingRect(rc);

            Rect interior = rc;
            interior.Inset((int)rbv.StrokeThickness, (int)rbv.StrokeThickness);

            Paint p = new Paint()
            {
                Color = rbv.Color.ToAndroid(),
                AntiAlias = true,
            };

            canvas.DrawRoundRect(new RectF(interior), (float)rbv.CornerRadius, (float)rbv.CornerRadius, p);

            p.Color = rbv.Stroke.ToAndroid();
            p.StrokeWidth = (float)rbv.StrokeThickness;
            p.SetStyle(Paint.Style.Stroke);

            canvas.DrawRoundRect(new RectF(interior), (float)rbv.CornerRadius, (float)rbv.CornerRadius, p);
            
        }

    }
}