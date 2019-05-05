namespace GlobalAzureBootcampLandingSite.Models
{
    public class ConferenceInfo
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string BeginDate { get; set; }
        public string BeginTime { get; set; }
        public string EndDate { get; set; }
        public string EndTime { get; set; }
        public string[] Tags { get; set; }
        public string RegisterUrl { get; set; }
        public string MarketingImageUrl { get; set; }
        public string MarketingTitle { get; set; }
        public string MarketingDescription { get; set; }
        public string GoogleAnalyticsId { get; set; }
        public string FacebookAppId { get; set; }

        public VenueInfo Venue { get; set; }
        public BasicTicketInfo BasicTicket { get; set; }
        public SynopsisInfo Synopsis { get; set; }

        public UniqueInfoCollection<SpeakerInfo> Speakers { get; set; }
        public UniqueInfoCollection<SponsorInfo> Sponsors { get; set; }
        public UniqueInfoCollection<TrackInfo> Tracks { get; set;}
        public UniqueInfoCollection<SessionInfo> Sessions { get; set; }
    }
}