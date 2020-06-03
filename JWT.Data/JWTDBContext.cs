using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using JWT.Model;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace JWT.Data
{
    public class JWTDBContext : DbContext
    {
        public JWTDBContext( DbContextOptions<JWTDBContext> options ) : base(options)
        {
            
        }
        #region Lịch sử tương tác
        public DbSet<Interactive_History> Interactive_Historys { get; set; }
        #endregion
        #region App
        public DbSet<AppUser> AppUsers { get; set; }
        #endregion




    }
}
