using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.UI.Utilities;

namespace AM.UI.Utilities
{
    public class NavigationService<TViewModel> where TViewModel : ViewModelBase
    {
        private readonly Navigation _navigation;
        private readonly Func<TViewModel> _CreateModel;

        public NavigationService(Navigation navigation, Func<TViewModel> CreateModel)
        {
            _navigation=navigation;
            _CreateModel=CreateModel;
        }

        public ViewModelBase Navigate()
        {
            return _CreateModel();
        }
    }
}