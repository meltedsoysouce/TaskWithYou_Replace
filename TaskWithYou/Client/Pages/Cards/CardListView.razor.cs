﻿using Microsoft.AspNetCore.Components;
using Microsoft.FluentUI.AspNetCore.Components;
using TaskWithYou.Client.ViewModelFactories.Cards;
using TaskWithYou.Shared.ViewModels.Cards;

namespace TaskWithYou.Client.Pages.Cards
{
    public partial class CardListView
    {
        [Inject]
        private IViewModelFactory ViewModelFacotry { get; set; }

        // FluentUIでDialogを表示させるのに使用
        [Inject]
        private IDialogService DialogService { get; set; }

        private CardListViewModel ViewModel { get; set; }

        protected override void OnInitialized()
        {
            ViewModel = ViewModelFacotry.GetList();
            base.OnInitialized();
        }

        // 将来的にはうまいことファイルを分割したい
        #region カード作成モーダル
        private _CardCreateModal CardCreateModal { get; set; }
        // private async Task AsyncInvokeCreateCardModal()
        // {
        //     var dialog = await DialogService
        //         .ShowDialogAsync<_CardCreateModal>(
        //             ViewModelFacotry.GenerateCreateViewModel(),
        //             new DialogParameters()
        //                 {
        //                     Title = "カードの新規作成",
        //                     Modal = true,
        //                     Height = "240px"
        //                 });
            
        //     var result = await dialog.Result;
        //     var data = result.Data as CardCreateViewModel;
        // }
        #endregion

        #region カード更新モーダル
        private _CardEditModal CardEditModal { get; set; }

        // private async Task AsyncInvokeEditCardModal()
        // {
        //     var dialog = await DialogService
        //         .ShowDialogAsync<_CardEditModal>(
        //             ViewModelFacotry.GetEditViewModel(Guid.Empty),
        //             new DialogParameters()
        //             {
        //                 Title = "カードの編集",
        //                 Modal = true
        //             }
        //         );

        //     var result = await dialog.Result;
        //     var date = result.Data as CardEditViewModel;
        // }
        #endregion

        #region カード削除モーダル
        private _CardRemoveModal CardRemoveModal { get; set;}
        // private async Task AsyncInvokeRemoveCardModal()
        // {
        //     var dialog = await DialogService
        //         .ShowDialogAsync<_CardRemoveModal>(
        //             ViewModelFacotry.GetRemoveViewModel(Guid.Empty),
        //             new DialogParameters()
        //             {
        //                 Title = "カードの削除",
        //                 Modal = true
        //             }
        //         );

        //     var result = await dialog.Result;
        //     var date = result.Data as CardRemoveViewModel;
        // }
        #endregion

    }
}
