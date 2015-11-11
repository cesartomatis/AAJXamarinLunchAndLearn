using System;
using Xamarin.Forms;
using AAJXamarinSample;
using AAJXamarinSample.Droid;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer (typeof(CustomLabel), typeof(AndroidCustomLabel))]
namespace AAJXamarinSample.Droid
{
	public class AndroidCustomLabel : LabelRenderer
	{
		public CustomLabel customLabel
		{
			get { return this.Element == null ? null : (CustomLabel)Element; }
		}

		protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
		{
			base.OnElementChanged(e);

			Control.Text = customLabel.CustomText;
			Control.SetTextColor(customLabel.CustomTextColor.ToAndroid());
			Control.TextSize = (float)customLabel.CustomTextSize;
		}
	}
}

