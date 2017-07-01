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
using Xamarin.Forms;
using FinalProjectWeek4.Controls;
using FinalProjectWeek4.Droid.Renderers;
using Xamarin.Forms.Platform.Android;
using System.ComponentModel;

[assembly: ExportRenderer(typeof(DrawView), typeof(DrawViewRenderer))]
namespace FinalProjectWeek4.Droid.Renderers
{

    class DrawViewRenderer : ViewRenderer<DrawView, NativeDrawView>
    {
        public DrawViewRenderer()
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<DrawView> e)
        {
            //SetNativeControl ‐ Establece el custom view nativo que queremos usar
            if (Control == null)
                SetNativeControl(new NativeDrawView(Android.App.Application.Context));
            if (e.NewElement != null)
            //Esto basicamente convierte el color que tenemos en forms al color nativo de la plataforma.
                Control.PaintColor = e.NewElement.DrawColor.ToAndroid();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == DrawView.DrawColorProperty.PropertyName)
                Control.PaintColor = Element.DrawColor.ToAndroid();
        }

    }
}