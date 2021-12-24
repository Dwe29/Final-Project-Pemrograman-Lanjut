namespace Final_Project_Pemrograman_Lanjut.view
{
    public class GoathProduct
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public string Image { get; set; }

        public GoathProduct(string name, double value, string image)
        {
            Name = name;
            Value = value;
            Image = image;
        }
    }
}