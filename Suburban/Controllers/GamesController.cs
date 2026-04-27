using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Suburban.Data;
using Suburban.Models;
using Suburban.Services.Commands;

namespace Suburban.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GamesController : ControllerBase
{
    private readonly AppDbContext _context;

    public GamesController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Game>>> GetGames([FromQuery] GetGamesCommand command)
    {
        var query = _context.Games.AsQueryable();

        if (!string.IsNullOrEmpty(command.Query))
        {
            query = query.Where(g => EF.Functions.ILike(g.Title, $"%{command.Query}%"));
        }

        return await query.Skip((command.Page - 1) * command.PageSize)
                           .Take(command.PageSize)
                           .ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Game>> GetGameById(int id)
    {
        var game = await _context.Games.FindAsync(id);

        if (game == null)
        {
            return NotFound();
        }

        return game;
    }

    [HttpPost]
    public async Task<ActionResult<Game>> PostGame(Game game)
    {
        _context.Games.Add(game);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetGame", new { id = game.Id }, game);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutGame(int id, Game game)
    {
        if (id != game.Id)
        {
            return BadRequest();
        }

        _context.Entry(game).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!GameExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteGame(int id)
    {
        var game = await _context.Games.FindAsync(id);
        if (game == null)
        {
            return NotFound();
        }

        _context.Games.Remove(game);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool GameExists(int id)
    {
        return _context.Games.Any(e => e.Id == id);
    }
}