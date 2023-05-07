using CommunityToolkit.Mvvm.ComponentModel;

using System.ComponentModel;

namespace TestBindingCode
{
    [INotifyPropertyChanged]
    partial class Temp
    {
        [ObservableProperty]
        private int num;

        [ObservableProperty]
        private double floatWithFormatting;

        [ObservableProperty]
        private double floatWithConverter;
    }
}
