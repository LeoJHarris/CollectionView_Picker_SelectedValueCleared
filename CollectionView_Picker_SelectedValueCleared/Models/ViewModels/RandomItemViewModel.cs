using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace CollectionView_Picker_SelectedValueCleared.Models.ViewModels;

public partial class RandomItemViewModel : ObservableObject
{
    public RandomItemViewModel(string name)
    {
        Name = name;

        for (int i = 1; i < 5; i++)
        {
            PickerItems.Add(new PickerItem { Name = $"Picker Item {i}" });
        }
    }

    [ObservableProperty]
    private string _name = string.Empty;

    [ObservableProperty]
    private ObservableCollection<PickerItem> _pickerItems = [];

    [ObservableProperty]
    private int _selectedPickerIndex = -1;
}