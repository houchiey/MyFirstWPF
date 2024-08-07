using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryMVVM.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        private int _count = 0;

        [RelayCommand]
        private void CountUp() => Count++;

        [RelayCommand]
        private void CountDown() => Count--;
    }
}
