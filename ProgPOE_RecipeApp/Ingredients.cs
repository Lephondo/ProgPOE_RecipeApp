using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgPOE_RecipeApp
{
    public class Ingredients
    {
        private string _RecipeName;
        private string _IngredientName;
        private int _Quantity;
        private string _Unit;
        private int _Calories;
        private string _Steps;

        public string RecipeName { get { return _RecipeName; } set { _RecipeName = value; } }

        public string IngredientName { get { return _IngredientName; } set { _IngredientName = value; } }

        public int Quantity { get { return _Quantity;} set { _Quantity = value; } }

        public string Unit { get { return _Unit; } set { _Unit = value; } }

        public int Calories { get { return _Calories;} set { _Calories = value; } }

        public string Steps { get { return _Steps; } set { _Steps = value; } }
    }
}
