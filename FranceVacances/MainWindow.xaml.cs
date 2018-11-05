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

namespace FranceVacances
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

        //TODO: Opret bolig
        //TODO: Brug DatePicker fra UI til at ændre datoer i SeachBar.
        //Eksempel på greb af værdien fra datepicker og display den i en textblock er vist herunder.
            //dp.SelectedDate = DateTime.Today;

            //DateTime? selectedDate = dp.SelectedDate;

            //DateBlock.Text = selectedDate.Value.ToString("dd.MM.yyyy");
    }
}
