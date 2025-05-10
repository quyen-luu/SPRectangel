
//Nhập chiều dài và chiều rộng từ bàn phím.
//Tính diện tích, chu vi hình chữ nhật và in ra màn hìnhhình
public class Program
{
    private static void Main(string[] args)
    {   
        //Nhập chiều rộng từ bàn phím.
        Console.Write("Nhập chiều rộng hình chữ nhật: ");
        float width = Convert.ToSingle(Console.ReadLine());
        //Nhập chiều dài từ bàn phím.
        Console.Write("Nhập chiều dài hình chữ nhật: ");
        float height = Convert.ToSingle(Console.ReadLine());
        //Tính diện tính hình chữ nhật.
        float S = width * height;
        Console.WriteLine("Diện tích hình chữ nhật: " + S);
        //Tính chu vi hình chữ nhật
        float P = 2 * (width + height);
        Console.WriteLine("Chu vi hình chữ nhật: " + P);

        
    }
}