using BLL.IRepositories;
using BLL.Repositories.Common;
using DAL.Context;
using Inventory_Api.Models;
using Inventory_Api.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class BranchRepository:Repository<Branch>,IBranchRepository
    {
        private readonly ApplicationDbContext _db;
        public BranchRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }
    }
}
