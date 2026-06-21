using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;

namespace ConsoleApp4
{
    internal partial class Program
    {
        public class User
        {
            public string Name { get; private set; }
            public double Balance { get; private set; }
            public int Id { get; private set; }
            public List<Media> medias { get; private set; }
            private static int IdCount = 1;
            public User(string name, double balance, List<Media> medias)
            {
                Name = name;
                Balance = balance;
                Id = IdCount;
                this.medias = medias;
                IdCount++;
            }
            public bool Charge(double amount)
            {
                if (amount > Balance) return false;
                else Balance -= amount;
                return true;
            }
            public void AddBalance(double amount)
            {
                Balance += amount;
            }
            public bool AddMedia(Media media)
            {
                if (medias.Contains(media)) return false;
                else medias.Add(media);
                return true;
            }
            public bool RemoveMedia(Media media)
            {
                if (!medias.Contains(media)) return false;
                else medias.Remove(media);
                return true;
            }
            public override string ToString()
            {
                return $"Username: {Name}, User Id: {Id}, User Balance: {Balance}, User`s Medias: {string.Join("| ", medias)}";
            }
        }
    }
}
