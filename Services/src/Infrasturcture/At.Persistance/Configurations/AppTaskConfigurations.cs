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
    public sealed class AppTaskConfigurations : IEntityTypeConfiguration<AppTask>
    {
        public void Configure(EntityTypeBuilder<AppTask> builder)
        {
            builder.Property(x => x.PriorityId).IsRequired(true);
            builder.Property(x => x.AppUserId).IsRequired(true);
            builder.Property(x => x.Description).IsRequired(true);
            builder.Property(x => x.Title).IsRequired(true);
            builder.Property(x => x.Title).HasMaxLength(250);
            builder.HasMany(x => x.TaskReports).WithOne(x => x.AppTasks).HasForeignKey(x => x.AppTaskId);

        }
    }
}
