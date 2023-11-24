using Microsoft.AspNetCore.Components;
using Microsoft.FluentUI.AspNetCore.Components;
using TaskWithYou.Client.ViewModelFactories.Cards;
using TaskWithYou.Shared.ViewModels.Cards;

namespace TaskWithYou.Client.Pages.Cards
{
    public partial class CardListView
    {
        [Inject]
        private IViewModelFactory ViewModelFacotry { get; set; }

        [Inject]
        private HttpClient HttpClient { get; set; }

        private CardListViewModel ViewModel { get; set; }

        protected override async Task OnInitializedAsync()
        {
            ViewModel = await ViewModelFacotry.GetList(HttpClient);
            await base.OnInitializedAsync();
        }

        # region 各種モーダル
        private _CardCreateModal CardCreateModal { get; set; }

        private _CardEditModal CardEditModal { get; set; }
        
        private _CardRemoveModal CardRemoveModal { get; set;}

        private _CardDetailModal CardDetailModal { get; set; }
        #endregion
    }
}
