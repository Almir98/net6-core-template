namespace Template.API.Controllers.Base
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseCrudController<Tkey, TModel, TEntity> : ControllerBase where TModel : class where TEntity : class
    {
        private readonly IBaseCrudService<Tkey, TModel, TEntity> _baseCrudService;

        // Add logger

        // Add Fluent validation

        public BaseCrudController(IBaseCrudService<Tkey, TModel, TEntity> baseCrudService)
        {
            _baseCrudService = baseCrudService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TModel model)
        {
            try
            {
                await _baseCrudService.Create(model);
                return Ok();

            }
            catch (Exception ex)
            {
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
                return Ok();
            }
            catch (Exception ex)
            {
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
                return Ok();
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "POST:/create-template");
                return StatusCode(500);
            }
        }
    }
}
