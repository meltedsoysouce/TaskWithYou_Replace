using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskWithYou.Shared.VIewModels.Cards
{
    public class CardListViewModel
    {
        public List<CardListItem> CardList { get; set; }
    }

    public class CardListItem
    {
        public Guid Uid { get; set; }

        public string Title { get; set; }

        public DateTime CreateAt { get;set; }

        public DateTime? DeadLine { get; set; }

        public string Description { get; set; }
}
