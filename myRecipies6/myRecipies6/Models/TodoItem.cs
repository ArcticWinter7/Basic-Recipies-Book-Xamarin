using SQLite;

namespace myRecipies6.Models
{
    public class TodoItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string RecipeName { get; set; }
        public string RecipeMaker { get; set; }
        public string Ingredients { get; set; }
        public string Steps { get; set; }
    }
}
