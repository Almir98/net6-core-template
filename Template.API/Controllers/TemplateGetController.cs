namespace Template.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TemplateGetController : BaseGetController<int, TemplateEntity1DTO>
{
    public TemplateGetController(IBaseGetService<int, TemplateEntity1DTO> baseGetService, ILoggerManager logger) : base(baseGetService, logger)
    {
    }
}