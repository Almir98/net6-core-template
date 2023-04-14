namespace Template.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TemplateGetController : BaseGetController<int, TemplateEntity1Dto>
{
    public TemplateGetController(IBaseGetService<int, TemplateEntity1Dto> baseGetService, ILoggerManager logger) : base(baseGetService, logger)
    {
    }
}