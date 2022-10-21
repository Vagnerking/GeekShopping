namespace GeekShopping.Web.Models
{
    public class ProductViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string ImageURL { get; set; }

        public string SubstringName()
        {
            if (Name.Length < 24) return Name;

            return $"{Name.Substring(0, 23)} ...";
        }

        public string SubstringDescription()
        {
            if (Name.Length < 355) return Description;

            return $"{Name.Substring(0, 352)} ...";
        }
    }
}
