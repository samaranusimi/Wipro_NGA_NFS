using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages;

namespace RazorPages.Pages
{
    public class AddItemModel : PageModel
    {
        [BindProperty]
        public string? ItemName { get; set; }

        public IActionResult OnPost()
        {
            Item item = new Item();

            item.Name = ItemName;

            ItemStore.Items.Add(item);

            return RedirectToPage("Index");
        }
    }
}