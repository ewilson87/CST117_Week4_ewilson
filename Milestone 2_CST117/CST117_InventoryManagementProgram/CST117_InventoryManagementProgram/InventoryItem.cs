namespace CST117_InventoryManagementProgram
{
    class InventoryItem
    {
        private string name;
        private string model;
        private string type;
        private int quantity;
        private decimal msrp;
        private decimal salePrice;

        public InventoryItem()
        {

        }

        public InventoryItem(string name, string model, string type, int quantity, decimal msrp, decimal salePrice)
        {
            this.name = name;
            this.model = model;
            this.type = type;
            this.quantity = quantity;
            this.msrp = msrp;
            this.salePrice = salePrice;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Model
        {
            get => model;
            set => model = value;
        }

        public string Type
        {
            get => type;
            set => type = value;
        }

        public int Quantity
        {
            get => quantity;
            set => quantity = value;
        }

        public decimal Msrp
        {
            get => msrp;
            set => msrp = value;
        }

        public decimal SalePrice
        {
            get => salePrice;
            set => salePrice = value;
        }
    }
}
