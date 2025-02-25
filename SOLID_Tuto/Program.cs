using SOLID_Tuto.Model;
using SOLID_Tuto.Service;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("CHAO MUNG BAN DEN VOI CUA HANG CUA CHUNG TOI");

        Order order = new Order();
        order.AddItem(new Pizza());
        order.AddItem(new Burger());
        order.AddItem(new Salad());

        Console.WriteLine($"Tong tien: {order.GetTotalPrice()}$\n");

        Kitchen kitchen = new Kitchen();
        kitchen.PrepareFood(new Pizza());
        kitchen.PrepareFood(new Burger());

        Console.WriteLine("\n DON HANG DA HOAN THANH. CHUC BAN NGON MIENG! ");
    }       
}