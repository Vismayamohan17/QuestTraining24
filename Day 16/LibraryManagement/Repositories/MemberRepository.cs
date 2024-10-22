using LibraryManagement.Data;
using LibraryManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Repositories
{
    internal class MemberRepository
    {
        public GenericResponse<List<Members>> GetAllMembers()
        {
            var Member = Datastore.Member;
            return new GenericResponse<List<Members>>
            {
                Success = true,
                Data = Member,
            };
        }
        public GenericResponse<Members> GetMembersByNameAndEmail(string Name, string email)
        {
            var Memberbyname = Datastore.Member.FirstOrDefault(x => x.Name == Name);
            var Memberbyemail = Datastore.Member.FirstOrDefault(x => x.email == email);
            if (Memberbyname == null && Memberbyemail == null)
            {
                return new GenericResponse<Members>
                {
                    Success = false,
                    Message = "Member not found",
                };
            }

            return new GenericResponse<Members>
            {
                Success = true,
                Data = Memberbyname

            };
        }
    }
}
