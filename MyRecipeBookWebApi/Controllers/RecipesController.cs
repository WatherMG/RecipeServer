using MyRecipeBookWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyRecipeBookWebApi.Controllers
{
    public class RecipesController : ApiController
    {
        private static List<Recipe> recipes = new List<Recipe>()
        {
            new Recipe()
            {
                Id = 0,
                CategoryId = 3,
                Time = 200,
                Name = "Miso Soup",
                Details = "Miso soup is a traditional Japanese soup consisting of a stock called dashi into which softened miso paste is mixed. Many ingredients are added depending on regional and seasonal recipes, and personal preference.",
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient() { Product= "Mushrooms", Measurement = "гр.", Quantity= 100 },
                    new Ingredient() { Product= "Potatoes", Measurement = "кг.", Quantity= 0.5 },
                    new Ingredient() { Product= "Seaweed", Measurement = "гр.", Quantity= 150 },
                    new Ingredient() { Product= "Onion", Measurement = "шт.", Quantity= 1 },
                    new Ingredient() { Product= "Shrimp", Measurement = "гр.", Quantity= 250 },
                    new Ingredient() { Product= "Water", Measurement = "мл.", Quantity= 600 },

                }
            },
            new Recipe()
            {
                Id = 1,
                CategoryId = 2,
                Time = 45,
                Name = "Holiday Fudge Bites",
                Details = @"LINE 8-inch square pan with foil, with ends of foil extending over sides. Microwave first 4 ingredients in large microwaveable bowl on HIGH 2 min. or until butter is melted; stir until chocolate is completely melted.

                    ADD dry pudding mix; stir with whisk 2 min. Add powdered sugar, 1 cup at a time, stirring after each addition until blended; press onto bottom of prepared pan. Top with sprinkles; press into fudge to secure.

                    REFRIGERATE 2 hours or until firm. Use foil handles to lift fudge from pan before cutting into pieces.",
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient() { Product= "White Chocolate", Measurement = "гр.", Quantity= 250 },
                    new Ingredient() { Product= "Semi-Sweet Chocolate", Measurement = "гр.", Quantity= 250 },
                    new Ingredient() { Product= "Butter", Measurement = "ч.л.", Quantity= 5 },
                    new Ingredient() { Product= "Water", Measurement = "стакан", Quantity= 1 },
                    new Ingredient() { Product= "Chocolate Instant Pudding", Measurement = "гр.", Quantity= 250 },

                }
            },
            new Recipe()
            {
                Id = 2,
                CategoryId = 7,
                Time= 60,
                Name = "Baked Garlic Parmesan Chicken",
                Details = "Serve with a salad and pasta or rice for a quick, scrumptious dinner.",
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient() { Product= "Olive oil", Measurement = "ч.л", Quantity= 2 },
                    new Ingredient() { Product= "Dry bread crumbs", Measurement = "стакан", Quantity= 1 },
                    new Ingredient() { Product= "Garlic", Measurement = "шт.", Quantity= 1 },
                    new Ingredient() { Product= "Parmesan cheese", Measurement = "стакан", Quantity= 1 },
                    new Ingredient() { Product= "Dried basil", Measurement = "ч.л.", Quantity= 1 },
                    new Ingredient() { Product= "Chicken breasts", Measurement = "гр.", Quantity= 400 },

                }
            }
        };

        [HttpGet]
        public IQueryable<Recipe> Get()
        {
            return recipes.AsQueryable();
        }

        [HttpGet]
        public Recipe Get(int id)
        {
            return recipes[id];
        }
    }
}