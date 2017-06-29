using CustomBoxViewRenderer.iOS;
using CoreGraphics;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using CustomBoxViewRenderer.Controls;

[assembly: ExportRendererAttribute(typeof(RoundedBoxView), typeof(RoundedBoxViewRenderer))]
namespace CustomBoxViewRenderer.iOS
{
    public class RoundedBoxViewRenderer : BoxRenderer
    {
        public override void Draw(CGRect rect)
        {
            RoundedBoxView rbv = (RoundedBoxView) this.Element;
        }
    }
}