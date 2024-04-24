using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;

namespace EasyTimeV2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<MyDataModel> YourItemsSource { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            // Initialize YourItemsSource with mockup data
            YourItemsSource = new ObservableCollection<MyDataModel>
            {
                new MyDataModel { Property1 = "Data 1", Property2 = "Data A" },
                new MyDataModel { Property1 = "Data 2", Property2 = "Data B" },
                new MyDataModel { Property1 = "Data 1", Property2 = "Data A" },
                new MyDataModel { Property1 = "Data 2", Property2 = "Data B" },
                new MyDataModel { Property1 = "Data 1", Property2 = "Data A" },
                new MyDataModel { Property1 = "Data 2", Property2 = "Data B" },
                new MyDataModel { Property1 = "Data 1", Property2 = "Data A" },
                new MyDataModel { Property1 = "Data 2", Property2 = "Data B" },
                new MyDataModel { Property1 = "Data 1", Property2 = "Data A" },
                new MyDataModel { Property1 = "Data 2", Property2 = "Data B" },
                new MyDataModel { Property1 = "Data 1", Property2 = "Data A" },
                new MyDataModel { Property1 = "Data 2", Property2 = "Data B" },
                new MyDataModel { Property1 = "Data 1", Property2 = "Data A" },
                new MyDataModel { Property1 = "Data 2", Property2 = "Data B" },
                new MyDataModel { Property1 = "Data 1", Property2 = "Data A" },
                new MyDataModel { Property1 = "Data 2", Property2 = "Data B" },
                new MyDataModel { Property1 = "Data 1", Property2 = "Data A" },
                new MyDataModel { Property1 = "Data 2", Property2 = "Data B" },
                // Add more mockup data as needed
            };

            // Set the DataContext to the MainWindow itself
            DataContext = this;
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

    public class MyDataModel
    {
        public string Property1 { get; set; }
        public string Property2 { get; set; }
        // Add more properties as needed
    }
}