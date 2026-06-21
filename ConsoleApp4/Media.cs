namespace ConsoleApp4
{
    internal partial class Program
    {
        public class Media
        {
            public Movie movie { get; private set; }
            public MediaTypes mediatype { get; private set; }
            public double PriceForDay { get; private set; }
            public int Copies { get; private set; }

            public void ChangePrice(double price)
            {
                PriceForDay = price;
            }
            public void ChangeAmountOfCopies(int amount)
            {
                Copies += amount;
                if (Copies < 0) Copies = 0;
            }
            public Media(Movie movie, MediaTypes mediatype, double priceForDay, int Copies)
            {
                this.movie = movie;
                this.mediatype = mediatype;
                this.PriceForDay = priceForDay;
                this.Copies = Copies;
            }
            public override string ToString()
            {
                return $"Movie info: {movie}, Media Type: {mediatype}, Price for day: {PriceForDay}.";
            }
        }
    }
}
