using Fcg.Usuarios.Domain.Entitites;

namespace Fcg.Usuarios.Domain.Repositories.Interfaces
{
    public interface IUsuarioRepository 
    {
        Task Adicionar(Usuario usuario);
        Task Atualizar(Usuario usuario);
        Task<Usuario> ObterPorId(Guid id);
        Task<IEnumerable<Usuario>> ObterTodos();
        Task SaveChanges();
        Task<Usuario?> ObterPorEmail(string email);
        Task<bool> VerificaEmailCadastrado(string emailCadastrado);
        Task<bool> VerificaMaisDeUmAdminCadastrado();
        Task<bool> VerificaNomeCadastrado(string nomeCadastrado);
        Task<bool> VerificaNomeCadastradoParaAlteracao(Guid usuarioId, string nomeCadastrado);
    }
}
