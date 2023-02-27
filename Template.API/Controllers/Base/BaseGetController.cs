namespace Template.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseGetController<TKey, TModel> : ControllerBase where TModel : class
    {
        private readonly IBaseGetService<TKey, TModel> _baseGetService;
        // Add logger


        public BaseGetController(IBaseGetService<TKey, TModel> baseGetService)
        {
            _baseGetService = baseGetService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                await _baseGetService.GetAllAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(TKey id)
        {
            try
            {
                await _baseGetService.GetByIdAsync(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }
    }
}
