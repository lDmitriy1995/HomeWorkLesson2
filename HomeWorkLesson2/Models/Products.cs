using Unipluss.Sign.ExternalContract.Entities;

namespace HomeWorkLesson2.Models
{
    public class Products
    {

        public Products(int iId, string Name, int Price)
        {
            this.Id = iId;
            this.Name = Name;
            this.Price = Price;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public string PathImage { get; set; }
    }
}
