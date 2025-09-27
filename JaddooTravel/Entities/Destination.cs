using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace JaddooTravel.Entities
{
    public class Destination
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string DestinationId { get; set; }
        public string CityCountry { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public string DayNight { get; set; }
        public int Capacity { get; set; }
        public string Description { get; set; }

        public string btn_Detail_Task()
        {
            return "<button type=\"button\" class=\"btn btn-white tooltip-default\" data-toggle=\"tooltip\" data-placement=\"top\" data-original-title=" + "Detay" + " onclick=\"window.location.href='/Task/Detail/?q=" + "id=" + this.DestinationId + "';\"><i class=\"entypo-newspaper\"></i></button>";
        }
        public string btn_Delete_Task()
        {
            return "<button type=\"button\" class=\"btn btn-white tooltip-default\" data-toggle=\"tooltip\" data-placement=\"top\" data-original-title=" + "Sil" + " onclick=\"window.location.href='/Task/Delete/?q=" + "id=" + this.DestinationId + "';\"><i class=\"entypo-trash\"></i></button>";
        }
    }
}
