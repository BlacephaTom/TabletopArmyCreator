using TabletopArmyCreator.Attributes;
using System.Data;

namespace TabletopArmyCreator.DatabaseRequests.Requests
{
    [StoredProcedure("Users.GetUserDetails")]
    public class GetUserDetailsRequest : IRequest
    {
        public GetUserDetailsRequest(long userId)
        {
            this.UserId = userId;
        }

        [StoredProcedureParameter("UserId", SqlDbType.BigInt)]
        public long UserId { get; set; }
    }
}
