namespace Template.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TemplateGetController : BaseGetController<TemplateEntity2Dto>
{
    public TemplateGetController(IBaseGetService<TemplateEntity2Dto> baseGetService, ILoggerManager logger) : base(baseGetService, logger)
    {
    }
}