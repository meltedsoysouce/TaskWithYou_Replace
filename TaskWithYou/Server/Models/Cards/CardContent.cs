using System.ComponentModel.DataAnnotations;

namespace TaskWithYou.Server.Models.Cards
{
    /// <summary>
    /// カードの内容を表現するクラス
    /// </summary>
    public class CardContent
    {
        [Key]
        public Guid Uid { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [Range(19000101, 99991231)]
        public int CreateAt { get; set; }

        [Range(19000101, 99991231)]
        public int? DeadLine { get; set; }

        public string Description { get; set; }
    }
}
