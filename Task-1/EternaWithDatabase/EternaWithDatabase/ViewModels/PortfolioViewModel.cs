using EternaWithDatabase.Models;
using System.Collections.Generic;

namespace EternaWithDatabase.ViewModels
{
    public class PortfolioViewModel
    {
        public List<Category> Categories { get; set; }
        public List<Portfolio> Portfolios { get; set; }

    }
}