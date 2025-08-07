using System;

namespace FilterLifecycleTrackerAdmin.Models
{
    public class Filter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public FilterStatus Status { get; set; }
        public string Location { get; set; }
        public DateTime LastChanged { get; set; }
    }
}