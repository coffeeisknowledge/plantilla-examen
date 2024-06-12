using System.Net.Mime;
using si730pc2u20201b380.API.Publishing.Domain.Model.Queries;
using si730pc2u20201b380.API.Publishing.Domain.Services;
using si730pc2u20201b380.API.Publishing.Interfaces.REST.Transform;
using Microsoft.AspNetCore.Mvc;

namespace si730pc2u20201b380.API.Publishing.Interfaces.REST;

[ApiController]
[Route("/api/v1/categories/{categoryId}/tutorials")]
[Produces(MediaTypeNames.Application.Json)]
[Tags("Categories")]
public class CategoryTutorialsController(ITutorialQueryService tutorialQueryService) : ControllerBase
{
    /**
     * Get Tutorials by Category Id.
     * <summary>
     *     Get Tutorials for a given category.
     * </summary>
     * <param name="categoryId">Category Id</param>
     * <returns>Tutorial Resources</returns>
     */
    [HttpGet]
    public async Task<IActionResult> GetTutorialsByCategoryId([FromRoute] int categoryId)
    {
        var getAllTutorialsByCategoryIdQuery = new GetAllTutorialsByCategoryIdQuery(categoryId);
        var tutorials = await tutorialQueryService.Handle(getAllTutorialsByCategoryIdQuery);
        var resources = tutorials.Select(TutorialResourceFromEntityAssembler.ToResourceFromEntity);
        return Ok(resources);
    }
}