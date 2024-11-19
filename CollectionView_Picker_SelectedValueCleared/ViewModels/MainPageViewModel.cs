using CollectionView_Picker_SelectedValueCleared.Models.ViewModels;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace CollectionView_Picker_SelectedValueCleared;

public partial class MainPageViewModel : ObservableObject
{
    public MainPageViewModel()
    {
        for (int i = 1; i < 30; i++)
        {
            RandomItemViewModels.Add(new RandomItemViewModel($"Random Row Item {i}"));
        }
    }

    [ObservableProperty]
    private ObservableCollection<RandomItemViewModel> _randomItemViewModels = [];
}