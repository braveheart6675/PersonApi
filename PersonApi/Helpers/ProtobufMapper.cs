using PersonApi.Models;
using PersonApi.Protos;

namespace PersonApi.Helpers
{
    public static class ProtobufMapper
    {
        public static Models.Person ToEntity(this Protos.Person proto)
        {
            return new Models.Person
            {
                Id = proto.Id,
                Name = proto.Name,
                FamilyName = proto.FamilyName,
                SocialNumber = proto.SocialNumber,
                BirthDate = DateTime.Parse(proto.BirthDate)
            };
        }

        public static Protos.Person ToProto(this Models.Person entity)
        {
            return new Protos.Person
            {
                Id = entity.Id,
                Name = entity.Name,
                FamilyName = entity.FamilyName,
                SocialNumber = entity.SocialNumber,
                BirthDate = entity.BirthDate.ToString("yyyy-MM-dd")
            };
        }
    }
}
