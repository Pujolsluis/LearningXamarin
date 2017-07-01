using System;
using Android.Views;
using Android.Content;
using Android.Util;
using Android.Graphics;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using HomeWorkWeek4.Droid;
using FinalProjectWeek4.Controls;

[assembly: ExportRenderer(typeof(DrawView), typeof(NativeDrawView))]
namespace HomeWorkWeek4.Droid
{
	public class NativeDrawView : View
	{
		IList<Tuple<Path,Color>> paths = new List<Tuple<Path, Color>>();
		//drawing path
		private Path drawPath;
		//drawing and canvas paint
		private Paint drawPaint, canvasPaint;
        public Color PaintColor { get { return drawPaint?.Color ?? Color.Black; } set { drawPaint.Color = value; var path = new Path(); paths.Add(new Tuple<Path, Color>(path,drawPaint.Color)); } }
		//canvas
		private Canvas drawCanvas;
		//canvas bitmap
		private Bitmap canvasBitmap;

		public NativeDrawView(Context context, IAttributeSet attrs, int defStyle) : base(context, attrs, defStyle)
		{
			Initialize();
		}

		public NativeDrawView(Context context, IAttributeSet attrs) : base(context, attrs)
		{
			Initialize();
		}

		public NativeDrawView(Context context) : base(context)
		{
			Initialize();
		}



		void Initialize()
		{
			drawPath = new Path();
			drawPaint = new Paint();
			drawPaint.Color = Color.Black;
			drawPaint.AntiAlias = true;
			drawPaint.StrokeWidth = 20;
			drawPaint.SetStyle(Paint.Style.Stroke);
			drawPaint.StrokeJoin = Paint.Join.Round;
			drawPaint.StrokeCap = Paint.Cap.Round;
			canvasPaint = new Paint(PaintFlags.Dither);
			DrawingCacheEnabled = true;
		}
		protected override void OnSizeChanged(int w, int h, int oldw, int oldh)
		{
			base.OnSizeChanged(w, h, oldw, oldh);
			canvasBitmap = Bitmap.CreateBitmap(w, h, Bitmap.Config.Argb8888);
		}

		protected override void OnDraw(Canvas canvas)
		{

			drawCanvas = canvas;
			canvas.DrawBitmap(canvasBitmap, 0, 0, canvasPaint);
			//canvas.DrawPath(drawPath, drawPaint);

			foreach(Tuple<Path, Color> path in paths)
			{
                drawPaint.Color = path.Item2;
                canvas.DrawPath(path.Item1, drawPaint);
			}
		}

		public override bool OnTouchEvent(Android.Views.MotionEvent e)
		{
			var touchX = e.GetX();
			var touchY = e.GetY();
			switch (e.Action)
			{
				case MotionEventActions.Down:
                    drawPath = paths.LastOrDefault().Item1;
					drawPath.MoveTo(touchX, touchY);
					break;
				case MotionEventActions.Move:
					drawPath.LineTo(touchX, touchY);
					break;
				default:
					return false;
			}
			Invalidate();
			return true;
		}
	}
}