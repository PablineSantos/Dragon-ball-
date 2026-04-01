using Dragon_Ball.Data;
using Dragon_Ball.Models;
using Dragon_Ball.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dragon_Ball.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonagemController : ControllerBase
    {
        private readonly IPersonagemService service;

        public PersonagemController(IPersonagemService service)
        {
            this.service = service;
        }

        [HttpPost]
        public async Task<IActionResult> AddPersonagem([FromBody] Personagem personagem)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var resultado = await service.Criar(personagem);

            return Ok(resultado);
        }

        [HttpGet]
        public async Task<IActionResult> GetPersonagens()
        {
            var lista = await service.ListarTodos();
            return Ok(lista);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPersonagem(int id)
        {
            var personagem = await service.BuscarPorId(id);

            if (personagem == null)
                return NotFound("Personagem não encontrado");

            return Ok(personagem);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePersonagem(int id, Personagem personagem)
        {
            var atualizado = await service.Atualizar(id, personagem);

            if (atualizado == null)
                return NotFound("Personagem não encontrado");

            return Ok(atualizado);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePersonagem(int id)
        {
            var deletado = await service.Deletar(id);

            if (!deletado)
                return NotFound("Personagem não encontrado");

            return Ok();
        }
    }
}

