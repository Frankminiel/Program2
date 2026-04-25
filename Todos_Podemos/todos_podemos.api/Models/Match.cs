namespace Todos_Podemos.Moduls
{
    public class Match
    {
        public int Id { get; set; }
        public int Player1Id { get; set; }
        public int Player2Id { get; set; }
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public DateTime Date { get; set; }
    }
}