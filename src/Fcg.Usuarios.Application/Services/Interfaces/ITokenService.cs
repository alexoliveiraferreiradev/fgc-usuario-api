using Fcg.Usuarios.Application.Dtos;
using System.Security.Claims;

namespace Fcg.Usuarios.Application.Services.Interfaces
{
    public interface ITokenService
    {
        string TokenGenerate(IEnumerable<Claim> claims);
        Task<IEnumerable<Claim>> ObtemClaims(UsuarioResponse usuario);
        Task<LoginResponse> RetornaJwt(UsuarioResponse usuario);
    }
}
