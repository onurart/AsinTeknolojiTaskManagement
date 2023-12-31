﻿using At.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace At.Persistance.Configurations
{
    public sealed class NotificationConfigurations : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
           builder.Property(x=>x.Description).IsRequired(true);
           builder.Property(x=>x.Description).HasMaxLength(500);
           builder.Property(x=>x.State).IsRequired(true);
           builder.Property(x=>x.AppUserId).IsRequired(true);
        }
    }
}
