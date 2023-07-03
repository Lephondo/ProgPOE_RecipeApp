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
using System.Windows.Shapes;

namespace ProgPOE_RecipeApp
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        List<Ingredients> ingredients = new List<Ingredients>();

        public Window2()
        {
            InitializeComponent();
        }

        private void btnSteps_Click(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.Show();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            ingredients.Add(new Ingredients() RecipeName = txtRecipeName.Text, IngredientName = txtIngredientName.Text, Quantity = Convert.ToInt32(txtQuantity.Text), Unit = txtUnit.Text, Calories = Convert.ToInt32(txtCalories.Text));
            txtRecipeName.Text = "";
            txtIngredientName.Text = "";
            txtQuantity.Text = "";
            txtUnit.Text = "";
            txtCalories.Text = "";
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }
    }
}
