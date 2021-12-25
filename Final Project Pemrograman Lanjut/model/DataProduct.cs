namespace Final_Project_Pemrograman_Lanjut.model
{
    public class DataProduct
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public string Image { get; set; }

        public DataProduct(string name, double value, string image)
        {
            Name = name;
            Value = value;
            Image = image;
        }
    }
}