using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class MainwindowVM : BaseModel
    {

        /// <summary>
        /// 第一层的集合
        /// </summary>
        public ObservableCollection<TreeViewItemModel> MenuItems { get; } = new ObservableCollection<TreeViewItemModel>();
        public MainwindowVM()
        {
            MenuItems = new ObservableCollection<TreeViewItemModel>()
            {
                new TreeViewItemModel("label1","doctor"),
  new TreeViewItemModel("label2","doctor"),
  new TreeViewItemModel("label3","polic"){CustomItems=new ObservableCollection<TreeViewItemModel>
  {new TreeViewItemModel("button","test1"),
  new TreeViewItemModel("textbox","test2"),
  new TreeViewItemModel("combox","test3")} ,
 }
            };
        }
    }
}
