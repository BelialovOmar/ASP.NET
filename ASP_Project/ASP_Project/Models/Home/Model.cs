namespace ASP_Project.Models.Home
{
    public class Model
    {
        public string Tittle { get; set; } = null!;

        public string Header { get; set; } = null!;

        public List<string> Departments
        {
            get; set;
        } = null!;
        public List<Product> Products
        {
            get; set;
        } = null!;


        public class Product
        {
            public string Name { get; set; } = null!;
            
            public double Price
            {
               get; set;
            }
        }
    }
}
