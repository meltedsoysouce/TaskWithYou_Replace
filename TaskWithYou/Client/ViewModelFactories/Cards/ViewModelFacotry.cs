﻿using TaskWithYou.Shared.ViewModels.Cards;

namespace TaskWithYou.Client.ViewModelFactories.Cards
{
    public interface IViewModelFactory
    {
        CardListViewModel GetList();

        CardDetailViewModel GetDetail(Guid Uid);

        CardCreateViewModel GenerateCreateViewModel();

        CardEditViewModel GetEditViewModel(Guid Uid);

        CardRemoveViewModel GetRemoveViewModel(Guid Uid);
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

        public CardDetailViewModel GetDetail(Guid Uid)
        {
            return new()
            {
                Uid = Uid,
                Title = "test",
                CreateAt = DateTime.Now,
                DeadLine = DateTime.Now,
                Description = "表示テスト"
            };
        }

        public CardEditViewModel GetEditViewModel(Guid Uid)
        {
            return new()
            {
                Uid = Uid,
                Title = "test",
                CreateAt = DateTime.Now,
                DeadLine = DateTime.Now,
                Description = "表示テスト"
            };
        }

        public CardRemoveViewModel GetRemoveViewModel(Guid Uid)
        {
            return new()
            {
                Title = "test",
                CreateAt = DateTime.Now,
                DeadLine = DateTime.Now,
                Description = "表示テスト"
            };
        }
    }
}
