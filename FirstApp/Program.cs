namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int[] arr = new int[2];
			Console.WriteLine("Number of small carpets: ");
			arr[0] = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Number of large carpets: ");
			arr[1] = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Pirce per small carpet: 25$");
			Console.WriteLine("Pirce per large carpet: 35$");
			int cost = arr[0] * 25 + arr[1] * 35;
			double tax = cost * 0.06;
			Console.WriteLine($"Cost : {cost}");
			Console.WriteLine($"Tax : {tax}");
			double total = cost + tax;
			Console.WriteLine($"Total estimate: {total} ");
			Console.WriteLine("This estamite is valid for 30 days");
			
		}
	}
}
