using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace WPFWindowTemplate
{
    public class ViewModel : BindableBase, IViewModel
    {
        private string _testBindingText = "test";
        public string TestBindingText
        {
            get => _testBindingText;
            set
            {
                if (_testBindingText != value)
                {
                    _testBindingText = value;
                    RaisePropertyChanged();
                }
            }
        }
    }
}
