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
    public sealed class PriorityConfigurations : IEntityTypeConfiguration<Priority>
    {
        public void Configure(EntityTypeBuilder<Priority> builder)
        {
            builder.Property(x => x.Definition).IsRequired(true);
            builder.Property(x => x.Definition).HasMaxLength(250);
            builder.HasMany(x => x.AppTasks).WithOne(x => x.Priority).HasForeignKey(x => x.PriorityId);
        }
    }
}
