using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using si730pc2u20201b380.API.Subscriptions.Domain.Model.Queries;
using si730pc2u20201b380.API.Subscriptions.Domain.Services;
using si730pc2u20201b380.API.Subscriptions.Interfaces.REST.Resources;
using si730pc2u20201b380.API.Subscriptions.Interfaces.REST.Transform;

namespace si730pc2u20201b380.API.Subscriptions.Interfaces.REST;

[ApiController]
[Route("api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
public class PlansController(IPlanCommandService planCommandService, IPlanQueryService planQueryService) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreatePlan([FromBody]CreatePlanResource resource)
    {
        var createPlanCommand = CreatePlanCommandFromResourceAssembler.ToCommandFromResource(resource);
        var plan = await planCommandService.Handle(createPlanCommand);
        if (plan is null)
        {
            return BadRequest();
        }
        var planResource = PlanResourceFromEntityAssembler.ToResourceFromEntity(plan);
        return CreatedAtAction(nameof(GetPlanById), new { planId = plan.Id }, planResource);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllPlans()
    {
        var getAllPlansQuery = new GetAllPlansQuery();
        var plans = await planQueryService.Handle(getAllPlansQuery);
        var planResources = plans.Select(PlanResourceFromEntityAssembler.ToResourceFromEntity);
        return Ok(planResources);
    }

    [HttpGet("{planId:int}")]
    public async Task<IActionResult> GetPlanById(int planId)
    {
        var getPlanByIdQuery = new GetPlanByIdQuery(planId);
        var plan = await planQueryService.Handle(getPlanByIdQuery);
        if (plan == null)
        {
            return NotFound();
        }

        var planResource = PlanResourceFromEntityAssembler.ToResourceFromEntity(plan);
        return Ok(planResource);
    }
}