using Microsoft.Maui.Controls.Maps;

namespace FiapFood.Models
{
    public class Place
    {
        public Location Location { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public PinType PinType { get; set; } = PinType.Place;
    }
}
