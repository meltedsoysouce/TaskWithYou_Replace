using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskWithYou.Client.ViewModelFactories.Cards;
using TaskWithYou.Shared.ViewModels.Cards;

namespace TaskWithYou.Client.Tests.ViewModelFactories.Cards
{
    public class ViewModelFactoryTest
    {
        [Fact(DisplayName="CardListViewModelが出力されていることの確認")]
        public void GetListValueTypeCheck()
        {
            ViewModelFacotry factory = new();
            var listViewModel = factory.GetList();
            Assert.IsType<CardListViewModel>(listViewModel);
        }

        [Fact(DisplayName="CardDetailViewModelが出力されているかの確認")]
        public void GetDetailCheck()
        {
            ViewModelFacotry factory = new();
            var detailViewModel = factory.GetDetail(Guid.Empty);
            Assert.IsType<CardDetailViewModel>(detailViewModel);
        }

        [Fact(DisplayName = "CardCreateViewModelが出力されていることの確認")]
        public void GenerateCreateCheck()
        {
            ViewModelFacotry factory = new();
            var createViewModel = factory.GenerateCreateViewModel();
            Assert.IsType<CardCreateViewModel>(createViewModel);
        }

        [Fact(DisplayName = "CardEditViewModelが出力されていることの確認")]
        public void GetEditViewModelCheck()
        {
            ViewModelFacotry factory = new();
            var editViewModel = factory.GetEditViewModel(Guid.Empty);
            Assert.IsType<CardEditViewModel>(editViewModel);
        }

        [Fact(DisplayName = "CardRemoveViewModelが出力されていることの確認")]
        public void GetRemoveViewModelTest()
        {
            ViewModelFacotry facotry = new();
            var removeViewModel = facotry.GetRemoveViewModel(Guid.Empty);
            Assert.IsType<CardRemoveViewModel>(removeViewModel);
        }
    }
}
