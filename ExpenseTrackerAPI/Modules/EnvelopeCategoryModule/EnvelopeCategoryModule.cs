using Codewrinkles.MinimalApi.SmartModules;

using ExpenseTrackerAPI.Models;

using Microsoft.AspNetCore.Http.HttpResults;

namespace ExpenseTrackerAPI.Modules.EnvelopeCategoryModule
{
    public class EnvelopeCategoryModule : IModule
    {
        public IEndpointRouteBuilder MapEndpointDefinitions(IEndpointRouteBuilder app)
        {
            app.MapGet("/GetAll", (HttpContext httpContext) =>
            {
                List<EnvelopeCategory> envelopeCategories = new List<EnvelopeCategory>();
                envelopeCategories.Add(new EnvelopeCategory { Id = 1, Name = "Food", IsActive = true });
                envelopeCategories.Add(new EnvelopeCategory { Id = 2, Name = "Gas", IsActive = true });
                envelopeCategories.Add(new EnvelopeCategory { Id = 3, Name = "Entertainment", IsActive = true });
                envelopeCategories.Add(new EnvelopeCategory { Id = 4, Name = "Clothing", IsActive = true });
                envelopeCategories.Add(new EnvelopeCategory { Id = 5, Name = "Misc", IsActive = true });
                envelopeCategories.Add(new EnvelopeCategory { Id = 6, Name = "Savings", IsActive = true });

                return envelopeCategories;
            })
          .WithName("EnvelopeCategory")
          .WithOpenApi();
            return app;

        }
    }
}
