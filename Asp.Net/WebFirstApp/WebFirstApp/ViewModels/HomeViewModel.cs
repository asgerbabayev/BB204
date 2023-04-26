using WebFirstApp.Models;

namespace WebFirstApp.ViewModels;

public class HomeViewModel
{
    public List<Student> Students { get; set; }
    public List<Group> Groups { get; set; }
    public int[] Numbers { get; set; }
}
