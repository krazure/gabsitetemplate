namespace GlobalAzureBootcampLandingSite.Models
{
    public class SessionInfo : IUniqueInfo
    {
        public string Id { get; set; }
        public string Track { get; set; }
        public string Time { get; set; }
        public string Title { get; set; }
        public string[] Speakers { get; set; }
        public bool Presentation { get; set; }
        public string Abstract { get; set; }
        public string Level { get; set; }
        public string Description { get; set; }
        public string SlideUrl { get; set; }
    }
}