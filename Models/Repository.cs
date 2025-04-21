
namespace film.Models
{
    public class Repository
    {
        private static readonly List<Films> _filmler =new();

        static Repository()
        {
            _filmler= new List<Films>()
            {
                new Films (){Id=1, Title="Siccin 2", Details="Korku dolu ve gerilim dolu bir film", Image="1.jpg", isActive=true, isHome=true},
                new Films (){Id=2, Title="hılı ve öfkeli 5", Details="Aksiyon dolu bir film", Image="1.jpg", isActive=true, isHome=true},
                new Films (){Id=3, Title="recep ivedik 2", Details="komedinin dibine vuracaksınız", Image="1.jpg", isActive=true, isHome=true},
                new Films (){Id=4, Title="james bond ", Details="Harika bir süper ajan filmi, aksiyon dolu", Image="1.jpg", isActive=true, isHome=true},
                new Films (){Id=5, Title="Dabbe", Details="Korku dolu ve gerilim dolu bir film, çok fena olacaksınız", Image="1.jpg", isActive=true, isHome=true},
                new Films (){Id=6, Title="Kolpaçino", Details="Mükemmel bir komedi filmi", Image="1.jpg", isActive=true, isHome=true},
            }
        }

        public static List<Categ
    }
}