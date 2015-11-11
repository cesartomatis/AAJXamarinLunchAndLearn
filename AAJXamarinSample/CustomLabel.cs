using System;
using Xamarin.Forms;

namespace AAJXamarinSample
{
	public class CustomLabel : Label
	{		
		public static readonly BindableProperty CustomTextProperty =
			BindableProperty.Create<CustomLabel, string>(
				p => p.CustomText, string.Empty);

		public string CustomText
		{
			get	{ return (string)GetValue(CustomTextProperty); }
			set { SetValue(CustomTextProperty, value); }
		}

		public static readonly BindableProperty CustomTextColorProperty =
			BindableProperty.Create<CustomLabel, Color>(
				p => p.CustomTextColor, Color.Black);

		public Color CustomTextColor
		{ 
			get { return (Color)GetValue(CustomTextColorProperty); }
			set { SetValue(CustomTextColorProperty, value); }
		}

		public static readonly BindableProperty CustomTextSizeProperty =
			BindableProperty.Create<CustomLabel, double>(
				p => p.CustomTextSize, 8.0);

		public double CustomTextSize
		{
			get { return (double)GetValue(CustomTextSizeProperty); }
			set { SetValue(CustomTextSizeProperty, value); }
		}
	}
}