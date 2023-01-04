using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenThiKham330.Model;

    public class LTQLDb : DbContext
    {
        public LTQLDb (DbContextOptions<LTQLDb> options)
            : base(options)
        {
        }

        public DbSet<NguyenThiKham330.Model.UniversityNTK330> UniversityNTK330 { get; set; } = default!;

        public DbSet<NguyenThiKham330.Model.NTK0330> NTK0330 { get; set; } = default!;
    }
