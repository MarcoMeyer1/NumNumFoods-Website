namespace NumNumFoods.Models
{
    public class Event
    {
        public int EventId { get; set; }          // Unique identifier for the event
        public string Title { get; set; }         // Title of the event
        public string Description { get; set; }   // Description of the event
        public DateTime StartDate { get; set; }   // Start date of the event
        public DateTime EndDate { get; set; }     // End date of the event
        public string PromoCode { get; set; }     // Promo code associated with the event
    }
}
