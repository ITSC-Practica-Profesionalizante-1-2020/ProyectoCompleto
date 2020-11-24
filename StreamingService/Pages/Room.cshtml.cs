using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StreamingService.Pages.Shared
{
    public class RoomModel : PageModel
    {
		public string Room { get; set; }
		public void OnGet()
        {
        }

    }
}
