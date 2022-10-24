 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using ДЗ_11.ViewModels.Base;

namespace ДЗ_11.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private Page Authorization;
        private Page Working;

        private Page _currentPage;
        public Page CurrentPage
        {
            get => _currentPage;
            set => Set(ref _currentPage, value);
        }

        public MainWindowViewModel()
        {
            Authorization = new Views.Pages.Authorization();
            Working = new Views.Pages.Working();

            CurrentPage = Authorization;
        }
    }
}
