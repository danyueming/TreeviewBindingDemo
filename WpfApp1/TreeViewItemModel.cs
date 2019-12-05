using System.Collections.ObjectModel;
using System.Windows;

namespace WpfApp1
{
    public class TreeViewItemModel : BaseModel
    {

        public TreeViewItemModel(string header, string tag)
        {
            Header = header;
            Tag = tag;
            CustomItems = new ObservableCollection<TreeViewItemModel>();
        }

        public string Header { get; set; }

        public string Tag { get; set; }

        public Visibility Visibility
        {
            get => _visibility;
            set { _visibility = value; NotifyPropertyChanged(); }
        }
        private Visibility _visibility = Visibility.Visible;

        public bool IsExpanded
        {
            get => _isExpanded;
            set { _isExpanded = value; NotifyPropertyChanged(); }
        }
        private bool _isExpanded = true;

        /// <summary>
        /// 第二层的集合
        /// </summary>
        public ObservableCollection<TreeViewItemModel> CustomItems
        {
            get => _customItems;
            set { _customItems = value; NotifyPropertyChanged(); }
        }
        private ObservableCollection<TreeViewItemModel> _customItems;
    }


}