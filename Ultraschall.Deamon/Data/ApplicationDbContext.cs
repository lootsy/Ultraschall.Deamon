// Copyright (c) 2017 Ultraschall. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.EntityFrameworkCore;
using Ultraschall.Deamon.Data.Models;

namespace Ultraschall.Deamon.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Value> Values { get; set; }
    }
}
