using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IBAS_menu.Pages;

public class Kontakt : PageModel
{
    private readonly ILogger<Kontakt> _logger;

    public Kontakt(ILogger<Kontakt> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
