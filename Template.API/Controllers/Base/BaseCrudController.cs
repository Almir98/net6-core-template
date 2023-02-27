namespace Template.API.Controllers.Base
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseCrudController<Tkey, TModel, TEntity> : ControllerBase where TModel : class where TEntity : class
    {
        private readonly IBaseCrudService<Tkey, TModel, TEntity> _baseCrudService;
        private readonly ILoggerManager _logger;


        // Add Fluent validation

        public BaseCrudController(IBaseCrudService<Tkey, TModel, TEntity> baseCrudService, ILoggerManager logger)
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
                _logger.LogInfo("");
                
                return Ok();

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "");
                return StatusCode(500);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Tkey id, TModel model)
        {
            try
            {
                if (id is null)
                    return BadRequest("Invalid parameter");

                await _baseCrudService.Update(id, model);
                _logger.LogInfo("");

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "");
                return StatusCode(500);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Tkey id)
        {
            try
            {
                if (id is null)
                    return BadRequest("Invalid parameter");

                await _baseCrudService.Delete(id);
                _logger.LogInfo("");

                return Ok();
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "POST:/create-template");
                _logger.LogError(ex, "");

                return StatusCode(500);
            }
        }
    }
}
