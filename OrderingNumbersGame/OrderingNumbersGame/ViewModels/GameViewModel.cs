using OrderingNumbersGame.Models;
using OrderingNumbersGame.Utils;
using System.ComponentModel;

namespace OrderingNumbersGame.ViewModels
{
	public class GameViewModel : NotificationObject
	{

		private BoardViewModel _boardViewModel;

		public BoardViewModel BoardViewModel
		{
			get => _boardViewModel;
			set
			{
				_boardViewModel = value;
				OnPropertyChanged(() => BoardViewModel);
			}
		}

		public GameViewModel(int size)
		{
			BoardViewModel = new BoardViewModel(size);
		}

		public void StartGame()
		{

			BoardViewModel.Shuffle();
		}

		public void TryMoveSelectedCellToEmptyCell(int xSource, int ySource)
		{
			BoardViewModel.TryMoveSelectedCellToEmptyCell(xSource, ySource);
		}

	}
}