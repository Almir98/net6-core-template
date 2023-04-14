namespace Template.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TemplateCrudController : BaseCrudController<int, TemplateEntity2DTO, TemplateEntity2>
{
    public TemplateCrudController(IBaseCrudService<int, TemplateEntity2DTO, TemplateEntity2> baseCrudService, ILoggerManager logger) : base(baseCrudService, logger)
    {
    }
}