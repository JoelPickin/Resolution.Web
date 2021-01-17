using System;
using System.Collections.Generic;
using System.Text;
using Resolution.Web.Core;

namespace Resolution.Web.Data.Interfaces
{
    public interface IResolutionData
    {
        IEnumerable<ResolutionItem> GetAll();
        ResolutionItem GetResolutionById(int Id);
        ResolutionItem Update(ResolutionItem updatedResolution);
        ResolutionItem Add(ResolutionItem newResolution);
        ResolutionItem Delete(int Id);
        int Commit();
    }
}
