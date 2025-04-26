namespace _01PC_PortfolioCore.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string ClassName { get; set; }

        public List<Portfolio> Portfolios { get; set; }
    }
}
