using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Resolution.Web.Core;
using Resolution.Web.Data.Interfaces;

namespace Resolution.Web.Pages.Resolutions
{
    public class DashboardModel : PageModel
    {
        private readonly IResolutionData resolutionData;
        public IEnumerable<ResolutionItem> Resolutions { get; set; }

        public DashboardModel(IResolutionData resolutionData)
        {
            this.resolutionData = resolutionData;
        }

        public void OnGet()
        {
            Resolutions = resolutionData.GetAll();
        }
    }
}
