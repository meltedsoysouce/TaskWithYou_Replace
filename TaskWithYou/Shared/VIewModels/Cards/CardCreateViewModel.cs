using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TaskWithYou.Shared.ViewModels.Cards
{
    public class CardCreateViewModel
    {
        [Required]
        public Guid Uid { get; set; } = Guid.NewGuid();

        [Required]
        public string Title { get; set; }

        [Required]
        public DateTime CreateAt { get; set; } = DateTime.Today;

        public DateTime DeadLine { get; set; }
        
        public string Description { get; set; }
    }
}
