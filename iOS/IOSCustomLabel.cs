using System;
using Xamarin.Forms;
using AAJXamarinSample;
using AAJXamarinSample.iOS;
using Xamarin.Forms.Platform.iOS;
using UIKit;

[assembly: ExportRenderer (typeof(CustomLabel), typeof(IOSCustomLabel))]
namespace AAJXamarinSample.iOS
{
	public class IOSCustomLabel : LabelRenderer
	{
		public CustomLabel customLabel
		{
			get { return this.Element == null ? null : (CustomLabel)Element; }
		}

		protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
		{
			base.OnElementChanged(e);

			Control.Text = customLabel.CustomText;
			Control.TextColor = customLabel.CustomTextColor.ToUIColor ();
			Control.Font = UIFont.FromName(this.Control.Font.Name, (float)customLabel.CustomTextSize);
		}
	}
}

