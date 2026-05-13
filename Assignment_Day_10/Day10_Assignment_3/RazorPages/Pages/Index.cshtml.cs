using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages.Pages;

public class IndexModel : PageModel
{
    public List<Item>? ItemList { get; set; }
    public void OnGet()
    {
        ItemList = ItemStore.Items;

    }
}
