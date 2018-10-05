using System.Collections.Generic;

namespace ConfigOptions.Infrastructure.Configurations.Feed
{
    public class FeedOptions
    {
        public bool IsActive { get; set; }
        public List<Endpoint> Endpoints { get; set; }
    }
}
