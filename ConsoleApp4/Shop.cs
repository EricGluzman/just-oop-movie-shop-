namespace ConsoleApp4
{
    internal partial class Program
    {
        public class Shop
        {
            public Shop(List<Media> media)
            {
                this.medias = media ?? new List<Media>();
            }
            public Shop(Media media)
            {
                this.medias = new List<Media>();
                if (media != null)
                {
                    medias.Add(media);
                }
            }

            public List<Media> medias { get; private set; }

            public async Task<bool> RentAMovie(Media media,User user,DateTime date)
            {
                TimeSpan time = date.Date - DateTime.Now.Date;
                if (!medias.Contains(media)) return false;
                else if (date <= DateTime.Now) return false;
                else if (user.Balance < (media.PriceForDay * time.TotalDays)) return false;
                else if (media.Copies <= 0) return false;
                user.Charge(media.PriceForDay * time.TotalDays);
                user.AddMedia(media);
                _ = CheckingDate(date, user, media);
                return true;
            }
            public bool RemoveAMovieFromUser(Media media, User user)
            {
                if (!user.medias.Contains(media)) return false;
                user.medias.Remove(media);
                return true;
            }
            public void AddMedia(Media media)
            {
                if (medias.Contains(media))
                {
                    media.ChangeAmountOfCopies(1);
                }
                else
                {
                    medias.Add(media);
                }
            }
            public bool RemoveMedia(Media media)
            {
                if (!medias.Contains(media)) return false;
                medias.Remove(media);
                return true;
            }
            public async Task CheckingDate(DateTime date,User user, Media media)
            {
                await Task.Delay(date - DateTime.Now);
                user.RemoveMedia(media);
                media.ChangeAmountOfCopies(1);
            }
        }
        public class RentalMenager
        {

        }
    }
}
