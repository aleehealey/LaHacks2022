using LaHacks2022.OM;
using LaHacks2022.Services;
using Microsoft.AspNetCore.Mvc;

namespace LaHacks2022.Controllers
{
    public class UserController : ControllerBase
    {
        private UserService _userService;
        public UserController(UserService userService)
        {
            _userService = userService;
        }

        // get user (send token)
        // return token with google token in it as well as userId
        [HttpGet("GetUser")]
        public async Task<IActionResult> GetUser(long userId)
        {
            try
            {
                var user = await _userService.GetUser(userId);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // add activities
        [HttpPost("AddActivities")]
        public async Task<IActionResult> AddActivities([FromBody] List<long> activityIds)
        {
            try
            {
                long userId = 0;
                await _userService.AddActivities(userId, activityIds);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        // Create group
        [HttpPost("CreateGroup")]
        public async Task<IActionResult> CreateGroup(long userId)
        {
            try
            {
                await _userService.CreateGroup(userId);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        // add people to group
        [HttpPost("AddPeopleToGroup")]
        public async Task<IActionResult> AddPeopleToGroup([FromBody] AddPeopleToGroupRequest req)
        {
            try
            {
                await _userService.AddPeopleToGroup(req.GroupCode, req.UserIds);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        // get activity recomendations - for group
        [HttpPost("Schedule")]
        public async Task<IActionResult> Schedule(long userId)
        {
            return null;
        }



    }
}
