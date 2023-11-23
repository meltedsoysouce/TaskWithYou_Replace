namespace TaskWithYou.Server.Models.Cards
{
    /// <summary>
    /// カードの内容を表現するクラス
    /// </summary>
    public class CardContent
    {
        public Guid Uid { get; set; }

        public string Title { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime? DeadLine { get; set; }

        public string Description { get; set; }
    }
}
