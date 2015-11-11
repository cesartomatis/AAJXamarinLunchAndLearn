using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AAJXamarinSample
{
	public partial class MyPageWithCodeBehind : ContentPage
	{
		public MyPageWithCodeBehind ()
		{
			InitializeComponent ();

			var lblHelloWorld = this.FindByName<Label> ("lblHelloWorld");
			lblHelloWorld.Text = "Welcome to Xamarin Forms!";
		}
	}
}

