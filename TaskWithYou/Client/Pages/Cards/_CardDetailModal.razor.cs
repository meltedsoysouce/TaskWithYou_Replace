using Microsoft.AspNetCore.Components;
using Microsoft.FluentUI.AspNetCore.Components;
using TaskWithYou.Client.ViewModelFactories.Cards;
using TaskWithYou.Shared.ViewModels.Cards;

namespace TaskWithYou.Client.Pages.Cards
{
    public partial class _CardDetailModal
    {
        [Inject]
        private IViewModelFactory ViewModelFactory { get; set; }

        private CardDetailViewModel ViewModel { get; set; }

        private FluentDialog Dialog { get; set; }

        public void OnShow(Guid Uid)
        {
            ViewModel = ViewModelFactory.GetDetail(Uid:Uid);
            Dialog.Show();
        }
    }
}

