using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskWithYou.Server.Data;
using TaskWithYou.Server.Models.Cards;
using TaskWithYou.Shared.ViewModels.Cards;
using DateTimeIntegerUtility;

namespace TaskWithYou.Server.Controllers.Cards
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardContentController : ControllerBase
    {
        private TaskWithYouAppDbContext DbContext { get; init; }

        public CardContentController(TaskWithYouAppDbContext dbContext)
        {
            DbContext = dbContext;
        }

        [HttpGet]
        public CardListViewModel GetList()
        {
            var cardcontents = DbContext.CardContents.ToList();
            CardListViewModel viewModel = new();
            viewModel.CardList = cardcontents
                .Select(x =>
                {
                    var deadLine = x.DeadLine ?? 0;
                    return new CardListItem()
                    {
                        Uid = x.Uid,
                        Title = x.Title,
                        CreateAt = DateTimeConverter.IntToDateTime(x.CreateAt),
                        DeadLine = DateTimeConverter.IntToDateTime(deadLine),
                        Description = x.Description ?? "",
                    };
                })
               .ToList();
            return viewModel;
        }
    }
}
