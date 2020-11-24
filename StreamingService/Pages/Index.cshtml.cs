using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CameraStream.Pages
{
    public class IndexModel : PageModel
    {
		public string Name { get; set; }
		public StreamingService.Controllers.RoomController.RoomIM Room { get; set; }
		public IndexModel()
        {

        }

        public void OnGet(string name)
        {
            this.Name = name;
        }

        public void OnPostSubmit(StreamingService.Controllers.RoomController.RoomIM room)
        {
            this.Room = room;
        }
    }
}
