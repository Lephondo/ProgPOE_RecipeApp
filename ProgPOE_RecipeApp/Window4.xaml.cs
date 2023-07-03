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
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        List<Ingredients> ingredients = new List<Ingredients>();

        public Window4()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            lstDisplay.Items.Clear();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.Show();
        }

        private void btnDisplay_Click(object sender, RoutedEventArgs e)
        {
            foreach(Ingredients ingredients in ingredients) 
            {
                lstDisplay.Items.Add(ingredients.RecipeName + 
                    "/n" + ingredients.IngredientName +
                    "/n" + ingredients.Quantity +
                    "/n" + ingredients.Unit + 
                    "/n" + ingredients.Calories +
                    "/n" + "Recipe Steps" +
                    "/n" + ingredients.Steps);
            }
        }

        private void btnScale_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
