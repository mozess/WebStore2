using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace WebStore.Domain.DTO.Identity
{
    public abstract class ClaimDTO:UserDTO
    {
        public IEnumerable<Claim> Claims { get; init; }
    }

    public class AddClaimDTO : ClaimDTO { }

    public class RemoveClaimDTO : ClaimDTO { }

    public class ReplaceClaimDTO : UserDTO
    {
        public Claim Claim { get; init; }
        public Claim NewClaim { get; init; }
        public IEnumerable<Claim> Claims { get; init; } //не уверен

    }
}
