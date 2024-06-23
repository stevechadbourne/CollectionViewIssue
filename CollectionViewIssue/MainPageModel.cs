
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CollectionViewIssue
{
    public class MainPageModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public List<string> Numbers { get; set; } = ["One", "Two", "Three"];

        private string _selectedNumber;
        public string SelectedNumber
        {
            get => _selectedNumber;
            set
            {
                BottomNumber = value;
                _selectedNumber = null;
                OnPropertyChanged();
            }
        }

        private string _bottomNumber;
        public string BottomNumber
        {
            get => _bottomNumber;
            set
            {
                _bottomNumber = value;
                OnPropertyChanged();
            }
        }

        public void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
