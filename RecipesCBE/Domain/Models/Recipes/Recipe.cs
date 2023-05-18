namespace Domain.Models.Recipes
{
    public class Recipe
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int CookingTimeInMinutes { get; set; }

        public int Persons { get; set; }
    }
}