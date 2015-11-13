using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MediaMeet.Models
{
    public class MediaMeetDbContext : DbContext
    {

        public MediaMeetDbContext() : base("name = MediaMeetDbContext")
        {
        }

        public System.Data.Entity.DbSet<MediaMeet.Models.Member> Member { get; set; }

        public System.Data.Entity.DbSet<MediaMeet.Models.Profile> Profile { get; set; }

        public System.Data.Entity.DbSet<MediaMeet.Models.Demographics> Demographics { get; set; }

        public System.Data.Entity.DbSet<MediaMeet.Models.Interest> Interest { get; set; }

        public System.Data.Entity.DbSet<MediaMeet.Models.Friend> Friend { get; set; } 

        public System.Data.Entity.DbSet<MediaMeet.Models.Photo> Photo { get; set; }

        public System.Data.Entity.DbSet<MediaMeet.Models.Message> Message { get; set; }

       protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
   
                modelBuilder.Entity<Member>()
                .HasOptional<Profile>(m => m.assocProfile)
                .WithRequired(m => m.assocMember)
                .Map(p => p.MapKey("MemberId"));
        }

    }
}