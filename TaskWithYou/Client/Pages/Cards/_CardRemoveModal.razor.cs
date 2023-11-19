using Microsoft.AspNetCore.Components;
using Microsoft.FluentUI.AspNetCore.Components;
using TaskWithYou.Shared.ViewModels.Cards;

namespace TaskWithYou.Client.Pages.Cards
{
    public partial class _CardRemoveModal
    {
        [CascadingParameter]
        public FluentDialog Dialog { get; set; }

        [Parameter]
        public CardRemoveViewModel Content { get; set; }
    }
}

