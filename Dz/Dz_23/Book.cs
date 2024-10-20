using System.ComponentModel.DataAnnotations;

namespace Dz_23
{
    public class Book
    {
        private static Random random = new Random();
        private static HashSet<int> existingId = new HashSet<int>();
        private int id;
        private string title;
        private string description;
        private int price;
        public Book(string title, string description, int price)
        {
            Id = Generate();
            Title = title;
            Description = description;
            Price = price;
        }
        [Required(ErrorMessage = "Title is required.")]
        public string Title
        {
            get => title;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Cant be empty");
                title = value;
            }
        }
        [Required(ErrorMessage = "Description is required.")]
        public string Description
        {
            get => description;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Cant be empty");
                description = value;
            }
        }
        [Range(0, int.MaxValue, ErrorMessage = "Price must be a positive number.")]
        public int Price
        {
            get => price;
            set
            {
                price = value;
            }
        }
        public int Id
        {
            get => id;
            set
            {
                if (!existingId.Add(value))
                    throw new ArgumentException("Id must be unique, plese regenerate");
                id = value;
            }
        }
        public int Generate() 
        {
            int newId;
            do
            {
                newId = random.Next(1,1000);
            } while (!existingId.Add(newId));
            return newId;
        }
    }
}
