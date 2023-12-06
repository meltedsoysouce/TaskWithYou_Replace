using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskWithYou.Shared.ViewModels.Cards;
using TaskWithYou.Server.Controllers.Cards;

namespace TaskWithYou.Server.Tests.Controllers.Cards
{
    public class CardContentControllerTests
    {
        [Fact]
        public void GetListTests()
        {
            var controller = new CardContentController();

            var result = controller.GetList();

            Assert.IsType<CardListViewModel>(result);
        }
    }
}
