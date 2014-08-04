using System;
using System.Data.Entity;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace RestaurantApp.Voting.AcceptanceTests.Steps
{
    [Binding]
    public class PollClosingSteps
    {
        
        protected VotingTestContext VotingTestContext { get; set; }
        protected PollClosingSteps(VotingTestContext context)
        {
            VotingTestContext = context;
        }

        [Given(@"que o restaurante '(.*)' já foi escolhido '(.*)'")]
        public async Task DadoQueORestauranteJaFoiEscolhido(string restaurantId, DateTime date)
        {
            var restaurant = await VotingTestContext.Db.Restaurants.FirstAsync(r => r.Name == restaurantId);
            //restaurant.
        }
    }
}
