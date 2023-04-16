namespace Template.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseGetController<TModel> : ControllerBase where TModel : class
    {
        private readonly IBaseGetService<TModel> _baseGetService;
        private readonly ILoggerManager _logger;

        public BaseGetController(IBaseGetService<TModel> baseGetService, ILoggerManager logger)
        {
            _baseGetService = baseGetService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                await _baseGetService.GetAllAsync();
                _logger.LogInfo("GetAll method created");

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "GET:/get-all");
                return StatusCode(500);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                await _baseGetService.GetByIdAsync(id);
                _logger.LogInfo("GetId method created");

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "GET:/get-by-id");
                return StatusCode(500);
            }
        }
    }
}
