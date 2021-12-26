namespace Final_Project_Pemrograman_Lanjut.model
{
    public class DataProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public string Image { get; set; }

        public DataProduct(int id, string name, double value, string image)
        {
            Id = id;
            Name = name;
            Value = value;
            Image = image;
        }
    }
}