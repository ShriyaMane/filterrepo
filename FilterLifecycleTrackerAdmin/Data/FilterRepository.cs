using System;
using System.Collections.Generic;
using FilterLifecycleTrackerAdmin.Models;

namespace FilterLifecycleTrackerAdmin.Data
{
    public static class FilterRepository
    {
        public static List<Filter> GetFilters()
        {
            return new List<Filter>
            {
                new Filter { Id = 1, Name = "HEPA #1", Status = FilterStatus.Active, Location = "Lab 1", LastChanged = DateTime.Now.AddDays(-10) },
                new Filter { Id = 2, Name = "Carbon #3", Status = FilterStatus.NeedsReplacement, Location = "Lab 2", LastChanged = DateTime.Now.AddDays(-45) },
                new Filter { Id = 3, Name = "Pre-Filter #7", Status = FilterStatus.Replaced, Location = "Warehouse", LastChanged = DateTime.Now.AddDays(-2) }
            };
        }
    }
}