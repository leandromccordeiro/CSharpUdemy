namespace SecTen.Entities
{
    public class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }
        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee)
            :base (name, price)
        {
            CustomsFee = customsFee;
        }
        public override string PriceTag()
        {
            return base.PriceTag() + $"\nCustom Fee: {CustomsFee}";
        }
        public double TotalPrice(double price, double customsFee)
        {
            return price * customsFee;
        }
    }
}
