﻿using System;
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
using FranceVacances.Model;
using FranceVacances.ViewModel;

namespace FranceVacances.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            Searchbar search = new Searchbar(travelType.Text, airportFrom.Text, airportTo.Text, dateInput.SelectedDate,
                Convert.ToInt32(numberOfTravelers.Text));
            search.MakeSearch();

        }

        private void HouseButton_OnClick(object sender, RoutedEventArgs e)
        {
            //TODO: Navigér til CreateHouse.xaml

            DataContext = new UserControl1ViewModel();
        }



        //TODO: Brug DatePicker fra UI til at ændre datoer i SeachBar.
        //Eksempel på greb af værdien fra datepicker og display den i en textblock er vist herunder.
        //dp.SelectedDate = DateTime.Today;

        //DateTime? selectedDate = dp.SelectedDate;
        //DateBlock.Text = selectedDate.Value.ToString("dd.MM.yyyy");
    }
}
