using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Client.ViewModels.Base;
using TaskManager.Common.Dtos;

namespace TaskManager.Client.ViewModels
{
    public class MenuViewModel : ViewModelBase
    {
        public ObservableCollection<ProjectDto> Projects { get; set; } = new()
        {
            new() { FullTitle = "Bobik Sosed" },
            new() { FullTitle = "Suka" }
        };
    }
}
