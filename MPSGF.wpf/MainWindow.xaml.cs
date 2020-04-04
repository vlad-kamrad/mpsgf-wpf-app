using MPSGF.wpf.Common;
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace MPSGF.wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeGrouping();
        }

        // Ascending sort direction
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ChangeListBoxSortDirection(ListSortDirection.Ascending);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ChangeListBoxSortDirection(ListSortDirection.Descending);
        }

        private void ChangeListBoxSortDirection(ListSortDirection direction)
        {
            listBox1.Items.SortDescriptions.Clear();

            if (isCustomSort.IsChecked == true)
            {
                var list = (ListCollectionView)CollectionViewSource.GetDefaultView(listBox1.ItemsSource);
                list.CustomSort = new UserComparer(direction);
            }
            else
            {
                listBox1.Items.SortDescriptions.Add(new SortDescription("Name", direction));
            }
        }

        private void InitializeGrouping()
        {
            // Custom grouping
            listBox2.Items.GroupDescriptions.Add(new PropertyGroupDescription("Gender", new GenderGrouper()));

            // Or you can manual grouping
            // listBox2.Items.GroupDescriptions.Add(new PropertyGroupDescription("Gender"));

            ChangeListBoxSortDirection(ListSortDirection.Ascending);
        }

        private void RadioButtonChange(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content)
            {
                case "Only Male":
                    SetFilter(UserFilterConditions.IsMale);
                    break;
                case "Only Female":
                    SetFilter(UserFilterConditions.IsFemale);
                    break;
                case "Only Managers":
                    SetFilter(UserFilterConditions.IsManager);
                    break;
                case "Only Workers":
                    SetFilter(UserFilterConditions.IsWorker);
                    break;
                default:
                    SetFilter((object param) => true);
                    break;
            }
        }

        private void SetFilter(Predicate<object> predicate)
        {
            listBox3.Items.Filter = new Predicate<object>(predicate);
        }
    }
}
