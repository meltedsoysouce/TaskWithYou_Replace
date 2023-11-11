using TaskWithYou.Shared.VIewModels.Cards;

namespace TaskWithYou.Client.ViewModelFactories.Cards
{
    public interface IViewModelFactory
    {
        CardListViewModel GetList();

        CardCreateViewModel GenerateCreateViewModel();
    }

    public class ViewModelFacotry : IViewModelFactory
    {
        public CardListViewModel GetList()
        {
            CardListViewModel viewModel = new ();
            viewModel.CardList = Enumerable.Range(0, 5)
                .Select(x =>
                {
                    return new CardListItem()
                    {
                        Uid = Guid.Empty,
                        Title = $"test {x}",
                        CreateAt = DateTime.Today,
                        DeadLine = null,
                        Description = $"This is a test {x}"
                    };
                })
                .ToList();
            return viewModel;
        }

        public CardCreateViewModel GenerateCreateViewModel() 
        {
            CardCreateViewModel viewModel = new();
            return viewModel;
        }
    }
}
