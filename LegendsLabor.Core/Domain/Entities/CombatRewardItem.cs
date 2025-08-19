using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LegendsLabor.Core.Domain.Entities
{
    public class CombatRewardItem : AuditableEntity, IEntity<int>
    {
        [BsonElement("itemId")]
        public int Id { get; set; }

        [BsonElement("quantity")]
        public int Quantity { get; set; }
    }
}
