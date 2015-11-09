
using Domain.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.EFData
{
    public class AddOrderProxy
    {
        public IOrderRepository OrderModel { get; set; }
        public ICustomerRepository CustomerModel { get; set; }
        public IGoodsRepository GoodsModel { get; set; }
        public IGoodsRowRepository GoodsRowModel { get; set; }
        public IOrderStatusRepository OrderStatusModel { get; set; }
        public ICommentRepository CommentModel { get; set; }

        readonly ProjectContext context = new ProjectContext();

        public AddOrderProxy()
        {
            OrderModel = new OrderDao(context);
            CustomerModel = new CustomerDao(context);
            GoodsModel = new GoodsDao(context);
            GoodsRowModel = new GoodsRowDao(context);
            OrderStatusModel = new OrderStatusDao(context);
            CommentModel = new CommentDao(context);
        }

    }
}
