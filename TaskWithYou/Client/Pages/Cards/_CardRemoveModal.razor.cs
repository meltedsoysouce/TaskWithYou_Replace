using Microsoft.AspNetCore.Components;
using Microsoft.FluentUI.AspNetCore.Components;
using TaskWithYou.Client.ViewModelFactories.Cards;
using TaskWithYou.Shared.ViewModels.Cards;

namespace TaskWithYou.Client.Pages.Cards
{
    public partial class _CardRemoveModal
    {
        // [CascadingParameter]
        // public FluentDialog Dialog { get; set; }

        // [Parameter]
        // public CardRemoveViewModel Content { get; set; }
        [Inject]
        private IViewModelFactory ViewModelFactory { get; set; }

        private CardRemoveViewModel ViewModel { get; set; }

        private FluentDialog Dialog { get; set; }

        public void OnShow(Guid Uid)
        {
            ViewModel = ViewModelFactory.GetRemoveViewModel(Uid);
            Dialog.Show();
        }
    }
}

