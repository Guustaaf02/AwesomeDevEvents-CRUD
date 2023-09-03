namespace AwesomeDevEvents.API.Entities
{
    public class DevEventSpeaker
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string TalkTtitle { get; set; }
        public string TalkTDescription { get; set; }

        public string LinkedInProfile { get; set; }
    }
}