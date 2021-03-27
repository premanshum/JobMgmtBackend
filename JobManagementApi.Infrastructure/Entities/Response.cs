using JobManagementApi.Infrastructure.Enums;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace JobManagementApi.Infrastructure.Entities
{
    public class Response<T>
    {

        [JsonProperty(PropertyName = "ResultType", Order = 1)]
        public ResultType ResultType
        {
            get; set;
        }

        [JsonProperty(PropertyName = "Messages", Order = 3)]
        public string Messages { get; set; }


        [JsonProperty(PropertyName = "Data", Order = 5)]
        public List<T> Data { get; set; }
    }
}
