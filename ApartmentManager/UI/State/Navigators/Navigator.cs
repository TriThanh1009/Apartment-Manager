using AM.UI.Utilities;
using System;

namespace AM.UI.State.Navigators
{
    public class Navigator : INavigator
    {
        private ViewModelBase _currentViewModel;

        public ViewModelBase CurrentViewModel
        {
            get
            {
                return _currentViewModel;
            }
            set
            {
                _currentViewModel?.Dispose();

                _currentViewModel = value;
                StateChanged?.Invoke();
            }
        }

        private ViewModelBase _CurrentHomeViewModel;

        public ViewModelBase CurrentHomeViewModel
        {
            get
            {
                return _CurrentHomeViewModel;
            }
            set
            {
                _CurrentHomeViewModel?.Dispose();

                _CurrentHomeViewModel = value;
                StateChanged?.Invoke();
            }
        }

        public event Action StateChanged;
    }
}