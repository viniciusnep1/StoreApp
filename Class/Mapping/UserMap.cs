using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Mapping
{
    public class UserMap
    {
        public UserMap(EntityTypeBuilder<User> user)
        {
            user.HasKey(t => t.Id);
            user.Property(t => t.Username).IsRequired();
            user.Property(t => t.Password).IsRequired();
            user.Property(t => t.FirstName).IsRequired();
            user.Property(t => t.LastName).IsRequired();
        }
    }
}
