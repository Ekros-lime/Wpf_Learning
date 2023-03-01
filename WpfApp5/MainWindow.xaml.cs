using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp5
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<ListItem> list = new List<ListItem>();
            list.Add(new ListItem() { Color = "Red", Name = "Red" });
            list.Add(new ListItem() { Color = "Orange", Name = "Orange" });
            list.Add(new ListItem() { Color = "Yellow", Name = "Yellow" });
            list.Add(new ListItem() { Color = "Green", Name = "Green" });
            list.Add(new ListItem() { Color = "Blue", Name = "Blue" });
            list.Add(new ListItem() { Color = "Indigo", Name = "Indogo" });
            list.Add(new ListItem() { Color = "Purple", Name = "Purple" });
            listBox.ItemsSource = list;
        }
    }

    public class ListItem
    {
        public string Color { get; set; }
        public string Name { get; set; }
    }
}
