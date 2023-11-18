using Microsoft.AspNetCore.Components;
using Microsoft.Fast.Components.FluentUI;
using TaskWithYou.Client.ViewModelFactories.Cards;
using TaskWithYou.Shared.ViewModels.Cards;

namespace TaskWithYou.Client.Pages.Cards
{
    public partial class _CardCreateModal
    {
        [Inject]
        private IViewModelFactory ViewModelFactory { get; set; }
        private CardCreateViewModel ViewModel { get; set; }

        private FluentDialog Dialog { get; set; }
        private bool IsModalHidden { get; set; } = true;


        public void OnShow()
        {
            ViewModel = ViewModelFactory.GenerateCreateViewModel(); 
            Dialog.Show();
        }
    }
}
