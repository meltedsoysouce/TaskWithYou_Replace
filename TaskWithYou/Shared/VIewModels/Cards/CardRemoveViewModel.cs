namespace TaskWithYou.Shared.ViewModels.Cards
{
    public class CardRemoveViewModel
    {
        public Guid Uid { get; init; }

        public string Title { get; init; }

        public DateTime CreateAt { get; init; }

        public DateTime DeadLine { get; init; }

        public string Description { get; init; }

    }
}
