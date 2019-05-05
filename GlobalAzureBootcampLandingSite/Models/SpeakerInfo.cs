namespace GlobalAzureBootcampLandingSite.Models
{
    public class SpeakerInfo : IUniqueInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Org { get; set; }
        public string Bio { get; set; }
    }
}