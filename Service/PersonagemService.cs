using Dragon_Ball.Data;
using Dragon_Ball.Models;
using Microsoft.EntityFrameworkCore;

namespace Dragon_Ball.Service
{
    public class PersonagemService : IPersonagemService
    {
        private readonly AppDbContext contexto;

        public PersonagemService(AppDbContext contexto)
        {
            this.contexto = contexto;
        }

        public async Task<Personagem> Criar(Personagem personagem)
        {
            contexto.DBZ.Add(personagem);
            await contexto.SaveChangesAsync();
            return personagem;
        }

        public async Task<List<Personagem>> ListarTodos()
        {
            return await contexto.DBZ.ToListAsync();
        }

        public async Task<Personagem?> BuscarPorId(int id)
        {
            return await contexto.DBZ.FindAsync(id);
        }

        public async Task<Personagem?> Atualizar(int id, Personagem personagemAtualizado)
        {
            var personagem = await contexto.DBZ.FindAsync(id);

            if (personagem == null)
                return null;

            contexto.Entry(personagem).CurrentValues.SetValues(personagemAtualizado);
            await contexto.SaveChangesAsync();

            return personagem;
        }

        public async Task<bool> Deletar(int id)
        {
            var personagem = await contexto.DBZ.FindAsync(id);

            if (personagem == null)
                return false;

            contexto.DBZ.Remove(personagem);
            await contexto.SaveChangesAsync();

            return true;
        }
    }
}
