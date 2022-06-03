using EternaWithDatabase.Models;
using System.Collections.Generic;

namespace EternaWithDatabase.ViewModels
{
    public class HomeViewModel
    {
        public List<Slider> Sliders { get; set; }
        public List<Feature> Features { get; set; }
        public List<Service> Services { get; set; }
    }
}