using OrderingNumbersGame.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OrderingNumbersGame
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow
	{
		public string Size
		{
			get { return (string)GetValue(SizeProperty); }
			set { SetValue(SizeProperty, value); }
		}

		// Using a DependencyProperty as the backing store for Size.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty SizeProperty =
			DependencyProperty.Register("Size", typeof(string), typeof(MainWindow), new PropertyMetadata("4"));


		public MainWindow()
		{
			InitializeComponent();
		}

		private void StartButton_Click(object sender, RoutedEventArgs e)
		{
			var gameViewModel = new GameViewModel(int.Parse(Size));
			DataContext = gameViewModel;
			//gameViewModel.StartGame();
			 
		}
	}
}
