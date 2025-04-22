
namespace film.Models
{
    public class Repository
    {
        private static readonly List<Filmss> _filmler = new();

        static Repository()
        {
            _filmler = new List<Filmss>()
            {
                new Filmss (){Id=1, Title="Siccin 2", Details="Korku dolu ve gerilim dolu bir film", Image="/img/siccin2.jpg", isActive=true, isHome=true},
                new Filmss (){Id=2, Title="Hılı Ve Öfkeli 2", Details="Aksiyon dolu bir film", Image="/img/hizliveöfkeli.jpg", isActive=true, isHome=true},
                new Filmss (){Id=3, Title="Recep ivedik 2", Details="komedinin dibine vuracaksınız", Image="/img/recepivedik2.jpg", isActive=true, isHome=true},
                new Filmss (){Id=4, Title="James Bond ", Details="Harika bir süper ajan filmi, aksiyon dolu", Image="/img/jamesbond.jpg", isActive=true, isHome=true},
                new Filmss (){Id=5, Title="Dabbe2", Details="Korku dolu ve gerilim dolu bir film, çok fena olacaksınız", Image="/img/dabbe2.jpg", isActive=true, isHome=true},
                new Filmss (){Id=6, Title="Kolpaçino", Details="Mükemmel bir komedi filmi", Image="/img/kolpaçino.jpg", isActive=true, isHome=true},
            };
        }


        public static List<Filmss> Films
        {
            get
            {
                return _filmler;      //Listenin dışarıdan okunabilmesini sağlayan kod bloğu
            }
        }

        public static Filmss GetById(int id)
        {
            return _filmler.FirstOrDefault(c => c.Id == id);
        }



    }
}