using System.Threading.Tasks;
using dotnet_rpg2.Dtos.Character;
using dotnet_rpg2.Dtos.Weapon;
using dotnet_rpg2.Models;
using dotnet_rpg2.Services.WeaponService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg2.Controllers
{
    [Authorize]
    [ApiController]
    [Route("controller")]
    public class WeaponController : ControllerBase
    {
        private readonly IWeaponService _weaponService;
        public WeaponController(IWeaponService weaponService)
        {
            _weaponService = weaponService;

        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> AddWeapon(AddWeaponDto newWeapon)
        {
            return Ok(await _weaponService.AddWeapon(newWeapon));
        }
    }
}