using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Leder.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Leder.Repository
{
    public class MemberRepository
    {
        private LederContext _db;
        public MemberRepository(LederContext memberContext)
        {
            _db = memberContext;
        }

        public IEnumerable<UserDetail> GetAllMember()
        {
            var result = _db.UserDetail.AsQueryable();
            return result;
        }

        public UserDetail GetMemberDetail(string email)
        {
            var result = _db.UserDetail.FirstOrDefault(x => x.Email == email);
            return result;
        }

        public string GetRoleName(string email)
        {
            string result;
            var user = _db.Users.FirstOrDefault(x => x.Email == email);
            var role = user.Roles.FirstOrDefault(x => x.UserId == user.Id);
            if (role != null)
            {                
                result = _db.Roles.FirstOrDefault(x => x.Id == role.RoleId).Name;
            }
            else
            {
                result = "";
            }            

            return result;
        }

        public string GetUserId(string email)
        {
            string result;
            var user = _db.Users.FirstOrDefault(x => x.Email == email);
            if(user != null)
            {
                result = user.Id;                
            }
            else
            {
                result = "";                
            }
            return result;
        }
    }
}