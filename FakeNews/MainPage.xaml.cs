using FakeNews.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FakeNews
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<FinanceData> Financial;
        private List<FoodData> Food;
        public MainPage()
        {
            this.InitializeComponent();
            Financial = new List<FinanceData>();
            Food = new List<FoodData>();

            Financial.Add(new FinanceData { ImageSource = "Assets/Financial1.png", FirstLine = "First Line", SecondLine = "Second Line", ThirdLine = "Third Line" });
            Financial.Add(new FinanceData { ImageSource = "Assets/Financial2.png", FirstLine = "First Line", SecondLine = "Second Line", ThirdLine = "Third Line" });
            Financial.Add(new FinanceData { ImageSource = "Assets/Financial3.png", FirstLine = "First Line", SecondLine = "Second Line", ThirdLine = "Third Line" });
            Financial.Add(new FinanceData { ImageSource = "Assets/Financial4.png", FirstLine = "First Line", SecondLine = "Second Line", ThirdLine = "Third Line" });
            Financial.Add(new FinanceData { ImageSource = "Assets/Financial5.png", FirstLine = "First Line", SecondLine = "Second Line", ThirdLine = "Third Line" });

            Food.Add(new FoodData { ImageSource = "Assets/Food1.png", FirstLine = "First Line", SecondLine = "Second Line", ThirdLine = "Third Line" });
            Food.Add(new FoodData { ImageSource = "Assets/Food2.png", FirstLine = "First Line", SecondLine = "Second Line", ThirdLine = "Third Line" });
            Food.Add(new FoodData { ImageSource = "Assets/Food3.png", FirstLine = "First Line", SecondLine = "Second Line", ThirdLine = "Third Line" });
            Food.Add(new FoodData { ImageSource = "Assets/Food4.png", FirstLine = "First Line", SecondLine = "Second Line", ThirdLine = "Third Line" });
            Food.Add(new FoodData { ImageSource = "Assets/Food5.png", FirstLine = "First Line", SecondLine = "Second Line", ThirdLine = "Third Line" });
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FinanceListBoxItem.IsSelected)
            {
                TitleTextBlock.Text = "Finance";
                MyGridView.ItemTemplate = (Windows.UI.Xaml.DataTemplate)Resources["FinancialTemplate"];
                MyGridView.ItemsSource = Financial;
            }
            else if(FoodListBoxItem.IsSelected)
            {
                TitleTextBlock.Text = "Food";
                MyGridView.ItemTemplate = (Windows.UI.Xaml.DataTemplate)Resources["FoodTemplate"];
                MyGridView.ItemsSource = Food;
            }
        }
    }
}
