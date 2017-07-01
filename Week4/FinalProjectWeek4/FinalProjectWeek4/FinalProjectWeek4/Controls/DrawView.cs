using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FinalProjectWeek4
{
    class DrawView : View
    {
        public static readonly BindableProperty DrawColorProperty = BindableProperty.Create <DrawView,Color>(p => p.DrawColor, Color.Black);
        
            public Color DrawColor
                {
                    get { return (Color)GetValue(DrawColorProperty); }
                    set { SetValue(DrawColorProperty, value); }
                }

    }
}
