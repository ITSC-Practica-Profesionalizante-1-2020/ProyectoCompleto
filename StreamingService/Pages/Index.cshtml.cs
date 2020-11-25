using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace CameraStream.Pages
{
    public class IndexModel : PageModel
    {
		public string Name { get; set; }

        public bool Persist { get; set; }
        public string Password { get; set; }
        public StreamingService.Controllers.RoomController.RoomIM Room { get; set; }
		public IndexModel()
        {

        }
        public void OnGet(string name, string pass, bool persist)
        {
            this.Name = name;
            this.Persist = persist;
            this.Password = pass;

        }

        public void OnPostSubmit(StreamingService.Controllers.RoomController.RoomIM room)
        {
            this.Room = room;
        }
    }
}
