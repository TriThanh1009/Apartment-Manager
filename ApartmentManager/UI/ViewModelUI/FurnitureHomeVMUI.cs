using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Dtos;
using ViewModel.Furniture;
using ViewModel.People;

namespace AM.UI.ViewModelUI
{
    public class FurnitureHomeVMUI : Utilities.ViewModelBase
    {
        private List<FurnitureVm> _fur;
        public IFurniture _ifur;
        public List<FurnitureVm> Fur
        {
            get => _fur;
            set
            {
                _fur = value;
                OnPropertyChanged();
            }
        }
        public FurnitureHomeVMUI(IFurniture ifur)
        {
            _ifur = ifur;
            Fur =new List<FurnitureVm>();
            LoadData();
        }
        public void LoadData()
        {
            var paged = new RequestPaging { PageIndex = 1, PageSize = 10 };
            PagedResult<FurnitureVm> f = _ifur.GetAllPage(paged);
            f.Items.ForEach(x => Fur.Add(x));
        }
 
    }
}