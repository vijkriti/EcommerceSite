// Controllers/LoginCredentialsController.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Data;
using Ecommerce.Models;

[Route("api/[controller]")]
[ApiController]
public class LoginCredentialsController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public LoginCredentialsController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<LoginCredentials>>> GetLoginCredentials()
    {
        return await _context.LoginCredentials.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<LoginCredentials>> GetLoginCredentials(int id)
    {
        var loginCredentials = await _context.LoginCredentials.FindAsync(id);

        if (loginCredentials == null)
        {
            return NotFound();
        }

        return loginCredentials;
    }

    [HttpPost]
    public async Task<ActionResult<LoginCredentials>> PostLoginCredentials(LoginCredentials loginCredentials)
    {
        _context.LoginCredentials.Add(loginCredentials);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetLoginCredentials", new { id = loginCredentials.Id }, loginCredentials);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutLoginCredentials(int id, LoginCredentials loginCredentials)
    {
        if (id != loginCredentials.Id)
        {
            return BadRequest();
        }

        _context.Entry(loginCredentials).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!LoginCredentialsExists(id))
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
    public async Task<IActionResult> DeleteLoginCredentials(int id)
    {
        var loginCredentials = await _context.LoginCredentials.FindAsync(id);
        if (loginCredentials == null)
        {
            return NotFound();
        }

        _context.LoginCredentials.Remove(loginCredentials);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool LoginCredentialsExists(int id)
    {
        return _context.LoginCredentials.Any(e => e.Id == id);
    }
}
