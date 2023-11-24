using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using TaskWithYou.Shared.ViewModels.Cards;

namespace TaskWithYou.Client.ViewModelFactories.Cards
{
    public interface IViewModelFactory
    {
        Task<CardListViewModel> GetList(HttpClient Client);

        CardDetailViewModel GetDetail(Guid Uid);

        CardCreateViewModel GenerateCreateViewModel();

        CardEditViewModel GetEditViewModel(Guid Uid);

        CardRemoveViewModel GetRemoveViewModel(Guid Uid);
    }

    public class ViewModelFacotry : IViewModelFactory
    {
        [Inject]
        private HttpClient HttpClient { get; set; }

        public async Task<CardListViewModel> GetList(HttpClient Client)
        {
            return await Client.GetFromJsonAsync<CardListViewModel>("/api/CardContent");
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
