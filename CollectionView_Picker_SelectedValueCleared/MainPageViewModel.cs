using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace CollectionView_Picker_SelectedValueCleared
{
    public partial class MainPageViewModel : ObservableObject
    {
        public MainPageViewModel()
        {
            Items.Add("Item 1");
            Items.Add("Item 2");
            Items.Add("Item 3");
            Items.Add("Item 4");
            Items.Add("Item 5");
            Items.Add("Item 6");
            Items.Add("Item 7");
            Items.Add("Item 8");
            Items.Add("Item 9");
            Items.Add("Item 10");
            Items.Add("Item 11");
            Items.Add("Item 11");
            Items.Add("Item 11");
            Items.Add("Item 11");
            Items.Add("Item 11");
            Items.Add("Item 11");
        }

        // Add ObservableCollections using the ObservableProperty attribute that is a collection of strings
        [ObservableProperty]
        private ObservableCollection<string> _items = [];
    }
}