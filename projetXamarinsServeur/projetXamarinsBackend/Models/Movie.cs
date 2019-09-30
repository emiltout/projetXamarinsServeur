using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace projetXamarinsBackend.Models
{
    public class Movie
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Title")]
        [JsonProperty("Title")]
        public string Title { get; set; }

        public string Poster { get; set; }

        public int Year { get; set; }

        public string Plot { get; set; }

        public string Comment { get; set; }
    }
}
