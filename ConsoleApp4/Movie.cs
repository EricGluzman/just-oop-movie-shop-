namespace ConsoleApp4
{
    internal partial class Program
    {
        public class Movie
        {
            public string Name { get; private set; }
            public DateTime Date { get; private set; }
            public List<string> Actors { get; private set; }
            public string Director { get; private set; }
            public Generes Gener { get; private set; }

            public Movie(string name, DateTime date, List<string> actors, string director, Generes gener)
            {
                Name = name;
                Date = date;
                Actors = actors;
                Director = director;
                Gener = gener;
            }
            public override string ToString()
            {
                return $"Movie Name: {Name}, Date Of Release: {Date}, Main Actors: {string.Join(", ",Actors)}. Director: {Director}, Gener: {Gener}";
            }
        }
    }
}
