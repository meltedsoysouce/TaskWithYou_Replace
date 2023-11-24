using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskWithYou.Server.Models.Cards;
using TaskWithYou.Shared.ViewModels.Cards;

namespace TaskWithYou.Server.Controllers.Cards
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardContentController : ControllerBase
    {
        [HttpGet]
        public CardListViewModel GetList()
        {
            var viewModel = new CardListViewModel();
            viewModel.CardList = Enumerable.Range(0, 10)
                .Select(x =>
                {
                    return new CardListItem()
                    {
                        Uid = Guid.NewGuid(),
                        Title = $"test {x}",
                        CreateAt = DateTime.Today,
                        DeadLine = null,
                        Description = $"This is api test {x}"
                    };
                })
                .ToList();
            return viewModel;
        }
    }
}
