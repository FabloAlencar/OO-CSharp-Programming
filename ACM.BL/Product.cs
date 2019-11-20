namespace ACM.BL
{
    public class Product : EntityBase
    {
        public Product()
        {
        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public decimal? CurrentPrice { set; get; }
        public string Description { set; get; }
        public int ProductId { get; private set; }
        public string ProductName { set; get; }

        public override string ToString() => ProductName;

        /// <summary>
        /// Validates the product data.
        /// </summary>
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}