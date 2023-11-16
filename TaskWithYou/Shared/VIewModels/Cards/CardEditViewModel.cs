using System.ComponentModel.DataAnnotations;

namespace TaskWithYou.Shared.ViewModels.Cards
{
    public class CardEditViewModel
    {
        [Required]
        public Guid Uid { get; init; }

        [Required]
        public string Title { get; set; }

        [Required]
        public DateTime CreateAt { get; set; }

        public DateTime DeadLine { get; set; }
        
        public string Description { get; set; }
    }
}

