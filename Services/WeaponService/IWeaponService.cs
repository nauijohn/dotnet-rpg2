using System.Threading.Tasks;
using dotnet_rpg2.Dtos.Character;
using dotnet_rpg2.Dtos.Weapon;
using dotnet_rpg2.Models;

namespace dotnet_rpg2.Services.WeaponService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}