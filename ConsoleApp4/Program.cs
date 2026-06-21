using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal partial class Program
    {
        static async Task Main(string[] args)
        {
            var p1 = new Movie("Joker", new DateTime(2022, 11, 8), new List<string> { "joker", "hahah" }, "Christopher Nolan", Generes.Action);
            var p2 = new Movie("Joker 2", new DateTime(2026,6,21), new List<string> { "Joker", "hahah" }, "Christopher Nolan", Generes.Comedy);
            var media1 = new Media(p1, MediaTypes.DVD, 16.99,4);
            var media2 = new Media(p2, MediaTypes.Digital, 29.99,70);
            var user1 = new User("eric", 100,new List<Media> {media2});
            var shop = new Shop(new List<Media> {media1,media2});

            if (await shop.RentAMovie(media1, user1, new DateTime(2026, 6, 22, 21, 15, 40)))
            {
                Console.WriteLine("Rented the movie!");
            }
            else Console.WriteLine("Cant rent.");
            Console.WriteLine(user1);
            Console.ReadKey();
            Console.WriteLine(user1);
        }
    }
}
