namespace Template.API.Controllers.Base
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseCrudController<TModel> : ControllerBase where TModel : class
    {
        private readonly IBaseCrudService<TModel> _baseCrudService;
        private readonly ILoggerManager _logger;

        public BaseCrudController(IBaseCrudService<TModel> baseCrudService, ILoggerManager logger)
        {
            _baseCrudService = baseCrudService;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TModel model)
        {
            try
            {
                await _baseCrudService.Create(model);
                _logger.LogInfo("Post method created");

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "POST:/create-template");
                return StatusCode(500);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, TModel model)
        {
            try
            {
                if (id == 0)
                    return BadRequest("Invalid parameter");

                await _baseCrudService.Update(id, model);
                _logger.LogInfo("Update method created");

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UPDATE:/update-template");
                return StatusCode(500);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                if (id == 0)
                    return BadRequest("Invalid parameter");

                await _baseCrudService.Delete(id);
                _logger.LogInfo("Deleted method created");

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "DELETE:/delete-template");

                return StatusCode(500);
            }
        }
    }
}
