using Microsoft.AspNetCore.Components;
using Microsoft.Fast.Components.FluentUI;
using TaskWithYou.Shared.ViewModels.Cards;

namespace TaskWithYou.Client.Pages.Cards
{
    public partial class _CardEditModal
    {
        [CascadingParameter]
        public FluentDialog Dialog { get; set; }

        [Parameter]
        public CardEditViewModel Content { get; set; }
    }
}

