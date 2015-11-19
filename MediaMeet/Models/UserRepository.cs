using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;

namespace MediaMeet.Models
{

    public class UserRepository
    {
        private MediaMeetDbContext db = new MediaMeetDbContext();

        public UserRepository()
        {
            Mapper.CreateMap<Member, MemberViewModel>();
        }

        public MemberViewModel showMark()
        {
            return Mapper.Map<MemberViewModel>(1);
        }

        void createUser()
        {

        }

        public void SaveChanges()
        {
            db.SaveChanges();
        }

    }
}