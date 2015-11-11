using System;

using Xamarin.Forms;

namespace AAJXamarinSample
{
	public class App : Application
	{
		public App ()
		{
			//Pagina creada con C# desde 
			//MainPage = new MyPageWithoutXAML();

			//Pagina levantada desde xaml usando Xamarin.Forms al 100%
			//MainPage = new MyPage();

			//Pagina levantada desde xaml usando Xamarin.Forms y Code-Behind
			MainPage = new MyPageWithCodeBehind();

			//Pagina levantada desde xaml usando Xamarin.Forms y MVVM
			//MainPage = new MyPageWithViewModel();

			//Pagina levantada desde xaml usando Xamarin.Forms y Custom Renderers
			//MainPage = new MyPageWithCustomRenderers();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}

	public class MyPageWithoutXAML : ContentPage
	{
		public MyPageWithoutXAML(){
			Device.OnPlatform(iOS: () => { Padding = new Thickness(0, 20, 0, 0); });
			Content = new StackLayout {
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				BackgroundColor = Color.White,
				Children = {
					new Label {
						VerticalOptions = LayoutOptions.CenterAndExpand,
						HorizontalOptions = LayoutOptions.CenterAndExpand,
						XAlign = TextAlignment.Center,
						TextColor = Color.Accent,
						FontSize = 46,
						Text = "Welcome to Xamarin Forms!"
					}
				}
			};
		}
	}
}

