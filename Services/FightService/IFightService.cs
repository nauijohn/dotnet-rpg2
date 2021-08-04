using System.Threading.Tasks;
using dotnet_rpg2.Dtos.Fight;
using dotnet_rpg2.Models;

namespace dotnet_rpg2.Services.FightService
{
    public interface IFightService
    {
        Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request);
    }
}