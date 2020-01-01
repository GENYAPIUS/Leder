﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Leder.Models;

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
    }
}