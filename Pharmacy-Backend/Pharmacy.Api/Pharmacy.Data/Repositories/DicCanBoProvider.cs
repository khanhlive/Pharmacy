using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Pharmacy.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pharmacy.Data.Repositories
{
    public class DicCanBoRepository : RepositoryBase
    {
        public DicCanBoRepository(IConfiguration config) : base(config)
        {
        }
        public IEnumerable<DicCanbo> GetAll()
        {
            return GetDbContext().DicCanbo;
        }

    }
    public abstract class RepositoryBase
    {
        protected readonly IConfiguration _config;
        private string connectionName = "HospitalDatabase";
        public RepositoryBase(IConfiguration config)
        {
            _config = config;
        }
        protected HOSPITALContext GetDbContext()
        {
            var builder = new DbContextOptionsBuilder<HOSPITALContext>();
            builder.UseSqlServer(_config.GetConnectionString(connectionName));
            return new HOSPITALContext(builder.Options);
        }
    }
    public class DicPhongBanRepository : RepositoryBase
    {
        public DicPhongBanRepository(IConfiguration config) : base(config)
        {
        }
        public IEnumerable<DicPhongban> GetAll()
        {
            return GetDbContext().DicPhongban;
        }
    }
}
