namespace Template.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TemplateCrudController : BaseCrudController<TemplateEntity2Dto>
{
    public TemplateCrudController(IBaseCrudService<TemplateEntity2Dto> baseCrudService, ILoggerManager logger) : base(baseCrudService, logger)
    {
    }
}