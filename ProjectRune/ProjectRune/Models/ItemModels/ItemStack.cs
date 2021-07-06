using System.ComponentModel;
using System.Diagnostics;

namespace ProjectRune.Models.ItemModels
{
    public class ItemStack : INotifyPropertyChanged
    {
        public Item Item { get; }

        private int count = 1;
        public int Count { get => count; }

        public ItemStack(Item item, int count)
        {
            Item = item;
            this.count = count;
        }

        public void Add(int count)
        {
            this.count += count;
            OnPropertyChanged(nameof(Count));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
