namespace MovieApp.Models.Entities
{
    public class Movie : BaseEntity
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string VideoUrl { get; set; }
        public string Description { get; set; } // Acıklama
        public string IMDB { get; set; }
        public string YearCfConstruction { get; set; } // Yapım Yılı
        public string Producer { get; set; } // Yapımcı
        public string Players { get; set; } // Oyuncular
        public string Duration { get; set; } // Süre or (Dizi)Ortalama Süre
        public bool IsMovie { get; set; }
        public string TotalSeason { get; set; } // Toplam Sezon
        public string TotalSection { get; set; } // Toplam Bölüm
        
        public int PlatformId { get; set; }
        public  virtual Platform  Platform { get; set; }

        public ICollection<MovieCategory>  MovieCategories { get; set; }

    }
}
