using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.DAO;

namespace Data.EFData
{
    public class GoodsDao: EfBaseDao<Goods>, IGoodsRepository
    {

    }
}
