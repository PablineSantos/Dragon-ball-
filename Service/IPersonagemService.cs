using Dragon_Ball.Models;

namespace Dragon_Ball.Service
{
    public interface IPersonagemService
    {
        Task<Personagem> Criar(Personagem personagem);
        Task<List<Personagem>> ListarTodos();
        Task<Personagem?> BuscarPorId(int id);
        Task<Personagem?> Atualizar(int id, Personagem personagem);
        Task<bool> Deletar(int id);
    }
}
