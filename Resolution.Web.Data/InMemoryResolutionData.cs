using Resolution.Web.Core;
using Resolution.Web.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Resolution.Web.Data
{
    public class InMemoryResolutionData : IResolutionData
    {
        readonly List<ResolutionItem> resolutions;

        public InMemoryResolutionData()
        {
            resolutions = new List<ResolutionItem>
            {
                new ResolutionItem{ Id = 1, Title = "Lose 3 Stone", Description = "Lose 3 stone by the check in date", Icon = "X", TaskAmount = 4, CurrentTask = 1, CheckInDate = new DateTime(2021, 3, 1)},
                new ResolutionItem{ Id = 2, Title = "Write 8 Articles", Description = "Write 1 article per week until the check in date", Icon = "X", TaskAmount = 4, CurrentTask = 1, CheckInDate = new DateTime(2021, 3, 1)},
                new ResolutionItem{ Id = 3, Title = "Learn Guitar", Description = "Learn to play a full song on guitar", Icon = "X", TaskAmount = 4, CurrentTask = 1, CheckInDate = new DateTime(2021, 3, 1)}
            };
        }

        public ResolutionItem Add(ResolutionItem newResolution)
        {
            resolutions.Add(newResolution);
            newResolution.Id = resolutions.Max(r => r.Id) + 1;

            return newResolution;
        }

        public int Commit()
        {
            return 0;
        }

        public ResolutionItem Delete(int Id)
        {
            var resolution = resolutions.FirstOrDefault(r => r.Id == Id);

            if (resolution != null)
            {
                resolutions.Remove(resolution);
            }

            return resolution;
        }

        public IEnumerable<ResolutionItem> GetAll()
        {
            return resolutions;
        }

        public ResolutionItem GetResolutionById(int Id)
        {
            return resolutions.SingleOrDefault(r => r.Id == Id);
        }

        public ResolutionItem Update(ResolutionItem updatedResolution)
        {
            var resolution = resolutions.FirstOrDefault(r => r.Id == updatedResolution.Id);

            if (resolution != null)
            {
                resolution.Title = updatedResolution.Title;
                resolution.Description = updatedResolution.Description;
                resolution.Icon = updatedResolution.Icon;
            }

            return resolution;
        }
    }
}
