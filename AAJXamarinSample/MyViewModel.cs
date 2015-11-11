using System;
using System.ComponentModel;

namespace AAJXamarinSample
{
	public class MyViewModel : INotifyPropertyChanged
	{
		private String _lblText;

		public String LblText {
			get{ return _lblText; }
			set{ 
				_lblText = value;
				OnPropertyChanged("LblText");
			}
		}
		public MyViewModel ()
		{
			LblText = "Welcome to Xamarin Forms!";
		}

		#region INPC
		public void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}

		public event PropertyChangedEventHandler PropertyChanged;
		#endregion
	}
}