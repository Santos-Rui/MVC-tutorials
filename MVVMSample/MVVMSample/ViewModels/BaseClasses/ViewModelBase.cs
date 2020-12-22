using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVVMSample.ViewModels.BaseClasses
{
    public class ViewModelBase
    {
        public ViewModelBase()
        {
            EventCommand = string.Empty;
        }

        public string EventCommand { get; set; }
        public virtual void HandleRequest() { }
    }
}