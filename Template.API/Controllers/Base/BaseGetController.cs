namespace Template.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseGetController<TKey, TModel> : ControllerBase where TModel : class
    {
        private readonly IBaseGetService<TKey, TModel> _baseGetService;
        private readonly ILoggerManager _logger;

        public BaseGetController(IBaseGetService<TKey, TModel> baseGetService, ILoggerManager logger)
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
                _logger.LogInfo("");

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "");
                return StatusCode(500);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(TKey id)
        {
            try
            {
                await _baseGetService.GetByIdAsync(id);
                _logger.LogInfo("");

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "");
                return StatusCode(500);
            }
        }
    }
}
