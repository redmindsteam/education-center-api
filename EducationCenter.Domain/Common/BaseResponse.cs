using System.Text.Json.Serialization;

namespace EducationCenter.Domain.Common
{
    public class BaseResponse<TSource>
    {
        [JsonIgnore]
        public int? Code { get; set; } = 200;

        public TSource Data { get; set; }

        public ErrorResponse Error { get; set; }

        public BaseResponse()
        {
            Error = new ErrorResponse();
        }
    }
}
