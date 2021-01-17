using System;
using System.Collections.Generic;
using System.Text;

namespace Resolution.Web.Core
{
    public class ResolutionItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public int TaskAmount { get; set; }
        public int CurrentTask { get; set; }
        public DateTime CheckInDate { get; set; }
    }
}
