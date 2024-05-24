using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Client.ViewModels.Base
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string props = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(props));

        protected virtual void Set<T>(ref T field, T value, [CallerMemberName] string props = "")
        {
            field = value;
            OnPropertyChanged(props);
        }
    }
}
