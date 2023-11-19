using Microsoft.AspNetCore.Components;
using Microsoft.FluentUI.AspNetCore.Components;
using TaskWithYou.Shared.ViewModels.Cards;
using TaskWithYou.Client.ViewModelFactories.Cards;

namespace TaskWithYou.Client.Pages.Cards
{
    public partial class _CardEditModal
    {
        [Inject]
        private IViewModelFactory ViewModelFactory { get; set; }

        private CardEditViewModel ViewModel { get; set; }
        private FluentDialog Dialog { get; set; }

        public void OnShow(Guid Uid)
        {
            ViewModel = ViewModelFactory.GetEditViewModel(Uid);
            Dialog.Show();
        }
    }
}

