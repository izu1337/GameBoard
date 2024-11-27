public class GameDto
{
    //permet d'afficher les différentes données
    public int Id { get; set; }
    public string Name { get; set; }
    public string Editor { get; set; }
    public StarRatingDto StarRating { get; set; }

    public List<string> Platforms { get; set; }

    public class StarRatingDto
    {
        public decimal Rate { get; set; }
        public int NbRates { get; set; }
    }
}
