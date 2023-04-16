namespace Template.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TemplateGetController : BaseGetController<TemplateEntity1Dto>
{
    public TemplateGetController(IBaseGetService<TemplateEntity1Dto> baseGetService, ILoggerManager logger) : base(baseGetService, logger)
    {
    }
}