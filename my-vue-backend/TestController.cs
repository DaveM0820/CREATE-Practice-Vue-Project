using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    private readonly PatientContext _context;

    public TestController(PatientContext context) {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetPatients() {
        try
        {
            var patients = await _context.Patients.ToListAsync();
            return Ok(patients);
        }
        catch (Exception ex)
        {
            // Log the exception details
            Console.WriteLine(ex.ToString()); // Or use a logging framework
            return StatusCode(500, "Internal Server Error: " + ex.Message);
        }
    }

}
