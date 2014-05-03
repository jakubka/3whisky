namespace Whisky.TextFormatting
{
    public static class PriceFormatExtensions
    {
        public static string AsPrice(this decimal price)
        {
            return price + " Kč";
        }
    }
}
