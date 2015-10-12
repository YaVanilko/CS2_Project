using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DAO;
using Domain.Entities;


namespace Data.DumbData
{
    public class BaseDao<T>: IRepository<T>
    {
        public void Add(T entity)
        {
            System.Type entityType = entity.GetType();
            if (entityType == typeof(PersonalInfo))
            {
                Data.DumbData.Storage.personalInfoCollection.Add(entity as PersonalInfo);
            }
            else if (entityType == typeof(ContactInfo))
            {
                Data.DumbData.Storage.contactInfoCollection.Add(entity as ContactInfo);
            }
            else if (entityType == typeof(Customer))
            {
                Data.DumbData.Storage.customerCollection.Add(entity as Customer);
            }
            else if (entityType == typeof(ProductCategory))
	        {
                Data.DumbData.Storage.categoryCollection.Add(entity as string);
	        }
            else if (entityType == typeof(User))
            {
                Data.DumbData.Storage.userCollection.Add(entity as User);
            }
            else if (entityType == typeof(Order))
            {
                Data.DumbData.Storage.orderCollection.Add(entity as Order);
            }
            else if (entityType == typeof(Goods))
            {
                Data.DumbData.Storage.goodsCollection.Add(entity as Goods);
            }
            else if (entityType == typeof(GoodsRow))
            {
                Data.DumbData.Storage.goodsRowCollection.Add(entity as GoodsRow);
            }
            else if (entityType == typeof(Role))
            {
                Data.DumbData.Storage.roleCollection.Add(entity as Role);
            }
            else if (entityType == typeof(Permission))
            {
                Data.DumbData.Storage.permissionCollection.Add(entity as Permission);
            }
            else if (entityType == typeof(Comment))
            {
                Data.DumbData.Storage.commentList.Add(entity as Comment);
            }
            else if (entityType == typeof(OrderStatus))
            {
                Data.DumbData.Storage.statusList.Add(entity as OrderStatus);
            }

        }

        public void Update(T entity)
        {
            System.Type entityType = entity.GetType();
            if (entityType == typeof(PersonalInfo))
            {
                PersonalInfo personInfo = Data.DumbData.Storage.personalInfoCollection.Find(x => x.GetHashCode() == entity.GetHashCode());
            }
        }

        public void Delete(T entity)
        {
            System.Type entityType = entity.GetType();
            if (entityType == typeof(PersonalInfo))
            {
                Data.DumbData.Storage.personalInfoCollection.Remove(entity as PersonalInfo);
            }
            else if (entityType == typeof(ContactInfo))
            {
                Data.DumbData.Storage.contactInfoCollection.Remove(entity as ContactInfo);
            }
            else if (entityType == typeof(Customer))
            {
                Data.DumbData.Storage.customerCollection.Remove(entity as Customer);
            }
            else if (entityType == typeof(ProductCategory))
            {
                Data.DumbData.Storage.categoryCollection.Remove(entity as string);
            }
            else if (entityType == typeof(User))
            {
                Data.DumbData.Storage.userCollection.Remove(entity as User);
            }
            else if (entityType == typeof(Order))
            {
                Data.DumbData.Storage.orderCollection.Remove(entity as Order);
            }
            else if (entityType == typeof(Goods))
            {
                Data.DumbData.Storage.goodsCollection.Remove(entity as Goods);
            }
            else if (entityType == typeof(GoodsRow))
            {
                Data.DumbData.Storage.goodsRowCollection.Remove(entity as GoodsRow);
            }
            else if (entityType == typeof(Role))
            {
                Data.DumbData.Storage.roleCollection.Remove(entity as Role);
            }
            else if (entityType == typeof(Permission))
            {
                Data.DumbData.Storage.permissionCollection.Remove(entity as Permission);
            }
            else if (entityType == typeof(Comment))
            {
                Data.DumbData.Storage.commentList.Remove(entity as Comment);
            }
            else if (entityType == typeof(OrderStatus))
            {
                Data.DumbData.Storage.statusList.Remove(entity as OrderStatus);
            }
        }

        public T GetById(int Id)
        {
            if (typeof(T) == typeof(PersonalInfo))
            {
               PersonalInfo info = Data.DumbData.Storage.personalInfoCollection.FirstOrDefault(x => x.Id == Id);               
            }
            else if (typeof(T) == typeof(ContactInfo))
            {
                Data.DumbData.Storage.contactInfoCollection.FirstOrDefault(x => x.Id == Id);
            }
            else if (typeof(T) == typeof(Customer))
            {
                Data.DumbData.Storage.customerCollection.FirstOrDefault(x => x.Id == Id);
            }
            else if (typeof(T) == typeof(ProductCategory))
            {
                Data.DumbData.Storage.categoryCollection.FirstOrDefault(x => x[Id] == Id);
            }
            else if (typeof(T) == typeof(User))
            {
                Data.DumbData.Storage.userCollection.FirstOrDefault(x => x.Id == Id);
            }
            else if (typeof(T) == typeof(Order))
            {
                Data.DumbData.Storage.orderCollection.FirstOrDefault(x => x.Id == Id);
            }
            else if (typeof(T) == typeof(Goods))
            {
                Data.DumbData.Storage.goodsCollection.FirstOrDefault(x => x.Id == Id);
            }
            else if (typeof(T) == typeof(GoodsRow))
            {
                Data.DumbData.Storage.goodsRowCollection.FirstOrDefault(x => x.Id == Id);
            }
            else if (typeof(T) == typeof(Role))
            {
                Data.DumbData.Storage.roleCollection.FirstOrDefault(x => x.Id == Id);
            }
            else if (typeof(T) == typeof(Permission))
            {
                Data.DumbData.Storage.permissionCollection.FirstOrDefault(x => x.Id == Id);
            }
            else if (typeof(T) == typeof(Comment))
            {
                Data.DumbData.Storage.commentList.FirstOrDefault(x => x.Id == Id);
            }
            else if (typeof(T) == typeof(OrderStatus))
            {
                Data.DumbData.Storage.statusList.FirstOrDefault(x => x.Id == Id);
            }
        }

        public IEnumerable<T> GetAll()
        {
            List<PersonalInfo> newPersonStor = new List<PersonalInfo>();
            if (typeof(T) == typeof(PersonalInfo))
            {
                
                foreach (var item in Data.DumbData.Storage.personalInfoCollection)
                {
                    newPersonStor.Add(item);
                }
            }
            return (IEnumerable<T>)newPersonStor;
        }
    }
}
