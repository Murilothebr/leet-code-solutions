namespace Can_Place_Flower;

internal class Program
{
    static void Main(string[] args)
    {
        int[] x = { 1, 0, 0, 0, 1 };

        var y = CanPlaceFlowers(x, 2);
        Console.WriteLine("Hello, World!");
    }

    public static bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        int canPlace = 0;

        for (int i = 0; i < flowerbed.Length; i++)
        {
            if ((i == 0 || flowerbed[i - 1] == 0) && flowerbed[i] == 0 && (flowerbed[i + 1] == 0) || i == flowerbed.Length - 1)
            {
                flowerbed[i] = 1;
                canPlace++;
            }
        }

        return canPlace >= n;
    }
}
