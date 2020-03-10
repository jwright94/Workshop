
namespace Demo
{
    public class Picture 
    {
        public int Width {get; set;}
        public int Height {get; set;}
        public string URL { get; set;}

        public override string ToString()
        {
            return $"Size: {Width} x {Height}\r\nURL: {URL}";
        }
    }
}