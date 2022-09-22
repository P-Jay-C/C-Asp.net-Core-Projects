using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaShop.Models;

namespace PizzaShop.Pages
{
    public class PizzaModel : PageModel
    {

        public List<PizzasModel> FakePizzadb = new List<PizzasModel>()
        {
            new PizzasModel(){ImageTitle = "Bolognese", PizzaName = "Bolognese", BasePrice = 5, FinalPrice = 7, Beaf = true, Pineapple = true },
            new PizzasModel(){ImageTitle = "Carbonara", PizzaName = "Carbonara", BasePrice = 5, FinalPrice = 7, Beaf = true, Pineapple = true },
            new PizzasModel(){ImageTitle = "Hawaiian", PizzaName = "Hawaiian", BasePrice = 5, FinalPrice = 7, Beaf = true, Pineapple = true },
            new PizzasModel(){ImageTitle = "Margarita", PizzaName = "Margarita", BasePrice = 5, FinalPrice = 7, Beaf = true, Pineapple = true },
            new PizzasModel(){ImageTitle = "MeatFeast", PizzaName = "MeatFeast", BasePrice = 5, FinalPrice = 7, Beaf = true, Pineapple = true },
            new PizzasModel(){ImageTitle = "Mushroom", PizzaName = "Mushroom", BasePrice = 5, FinalPrice = 7, Beaf = true, Pineapple = true },
            new PizzasModel(){ImageTitle = "Pepperoni", PizzaName = "Pepperoni", BasePrice = 5, FinalPrice = 7, Beaf = true, Pineapple = true },
            new PizzasModel(){ImageTitle = "Seafood", PizzaName = "Seafood", BasePrice = 5, FinalPrice = 7, Beaf = true, Pineapple = true },
            new PizzasModel(){ImageTitle = "Vegetarian", PizzaName = "Vegetarian", BasePrice = 5, FinalPrice = 7, Beaf = true, Pineapple = true },
        };
        public void OnGet()
        {

        }
    }
}
