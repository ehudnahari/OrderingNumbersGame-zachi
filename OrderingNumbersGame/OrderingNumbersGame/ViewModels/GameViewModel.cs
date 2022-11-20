using System.ComponentModel;

namespace OrderingNumbersGame.ViewModels
{
    public class GameViewModel : BaseViewModel
    {

        private BoardViewModel _boardViewModel;

        public BoardViewModel BoardViewModel
        {
            get { return _boardViewModel; }
            set { 
                _boardViewModel = value;
                NotifyPropertyChanged();
            }
        }

        public void StartGame(int size)
        {
            BoardViewModel = new BoardViewModel(size);
            BoardViewModel.Shuffle();
        }

        public void TryMoveSelectedCellToEmptyCell(int xSource, int ySource)
        {
            BoardViewModel.TryMoveSelectedCellToEmptyCell(xSource, ySource);
        }

    }
}