using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Net;
using TicketApi.Data;

namespace TicketApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoyaltyProgramController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IRepository<LoyaltyProgram> _db;
        private readonly IMapper _mapper;
        private readonly ILogger<LoyaltyProgram> _logger;

        public LoyaltyProgramController(IRepository<LoyaltyProgram> db, IMapper mapper, ILogger<LoyaltyProgram> logger)
        {
            _db = db;
            _mapper = mapper;
            _logger = logger;
            this._response = new APIResponse();
        }

        //Get All Entities
        [HttpGet]
        public async Task<ActionResult<APIResponse>> GetAll()
        {
            try
            {
                _logger.LogInformation("Getting all Scedules");
                IEnumerable<LoyaltyProgram> entities = await _db.GetAllAsync();
                _response.Result = _mapper.Map<List<LoyaltyProgramDTO>>(entities);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessage = new List<string> { ex.ToString() };
            }

            return _response;
        }

        //Get Single entity
        [HttpGet("{id:int}")]
        [Authorize(Roles = "Passenger")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> Get(int id)
        {
            try
            {
                if (id == 0)
                {
                    _logger.LogError("Error with id" + id);
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }

                var result = await _db.GetAsync(id);
                if (result == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }
                _response.Result = _mapper.Map<LoyaltyProgramDTO>(result);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessage = new List<string> { ex.ToString() };
            }

            return _response;
        }


        //Add new entity
        [HttpPost]
        [Authorize(Roles = "Passenger")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> Create([FromBody] CreateLoyaltyProgramDTO createDTO)
        {
            try
            {
                if (createDTO == null)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                LoyaltyProgram model = _mapper.Map<LoyaltyProgram>(createDTO);
                await _db.CreateAsync(model);
                _response.Result = _mapper.Map<LoyaltyProgramDTO>(model);
                _response.StatusCode = HttpStatusCode.Created;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessage = new List<string> { ex.ToString() };
            }

            return _response;
        }

        //Delete entity
        [HttpDelete("{id:int}")]
        [Authorize(Roles = "Passenger")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> Delete(int id)
        {
            try
            {
                if (id == 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                var entity = await _db.GetAsync(id);

                if (entity == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }

                _db.DeleteAsync(entity);
                _response.StatusCode = HttpStatusCode.NoContent;
                _response.IsSuccess = true;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessage = new List<string> { ex.ToString() };
            }
            return _response;
        }


        //Update entity
        [HttpPut("{id:int}")]
        [Authorize(Roles = "Passenger")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult<APIResponse>> Update(int id, [FromBody] LoyaltyProgramDTO updateDTO)
        {
            try
            {
                if (updateDTO == null || id != updateDTO.Id)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                LoyaltyProgram model = _mapper.Map<LoyaltyProgram>(updateDTO);
                _db.UpdateAsync(model);
                _response.StatusCode = HttpStatusCode.NoContent;
                _response.IsSuccess = true;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessage = new List<string> { ex.ToString() };
            }
            return _response;
        }
    }
}
