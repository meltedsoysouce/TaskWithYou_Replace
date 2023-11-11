using Microsoft.AspNetCore.Components;
using TaskWithYou.Client.ViewModelFactories.Cards;
using TaskWithYou.Shared.VIewModels.Cards;

namespace TaskWithYou.Client.Pages.Cards
{
    public partial class CardListView
    {
        [Inject]
        private IViewModelFactory ViewModelFacotry { get; set; }

        private CardListViewModel ViewModel { get; set; }

        protected override void OnInitialized()
        {
            ViewModel = ViewModelFacotry.GetList();
            base.OnInitialized();
        }
    }
}
