
namespace Films.Models
{
    public class Films
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Details { get; set; }
        public string Image { get; set; }
        public bool  isActive { get; set; }
        public bool  isHome { get; set; }
    }
}