using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DAO;
using Domain.Entities;


namespace Data.DumbData
{
    public class BaseDao<T> : IRepository<T> where T : class
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
                Data.DumbData.Storage.categoryCollection.Add(entity as ProductCategory);
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
                Data.DumbData.Storage.commentCollection.Add(entity as Comment);
            }
            else if (entityType == typeof(OrderStatus))
            {
                Data.DumbData.Storage.orderStatusCollection.Add(entity as OrderStatus);
            }
        }

        public void Update(T entity)
        {
            System.Type entityType = entity.GetType();
            if (entityType == typeof(PersonalInfo))
            {
                var typedEntity = entity as PersonalInfo;
                var oldEntity = Data.DumbData.Storage.personalInfoCollection.FirstOrDefault(x => x.Id == typedEntity.Id);
                oldEntity = typedEntity;
            }
            else if (entityType == typeof(ContactInfo))
            {
                var typedEntity = entity as ContactInfo;
                var oldEntity = Data.DumbData.Storage.contactInfoCollection.FirstOrDefault(x => x.Id == typedEntity.Id);
                oldEntity = typedEntity;
            }
            else if (entityType == typeof(Customer))
            {
                var typedEntity = entity as Customer;
                var oldEntity = Data.DumbData.Storage.customerCollection.FirstOrDefault(x => x.Id == typedEntity.Id);
                oldEntity = typedEntity;
            }
            else if (entityType == typeof(ProductCategory))
            {
                var typedEntity = entity as ProductCategory;
                var oldEntity = Data.DumbData.Storage.categoryCollection.FirstOrDefault(x => x.Id == typedEntity.Id);
                oldEntity = typedEntity;
            }
            else if (entityType == typeof(User))
            {
                var typedEntity = entity as User;
                var oldEntity = Data.DumbData.Storage.userCollection.FirstOrDefault(x => x.Id == typedEntity.Id);
                oldEntity = typedEntity;
            }
            else if (entityType == typeof(Order))
            {
                var typedEntity = entity as Order;
                var oldEntity = Data.DumbData.Storage.orderCollection.FirstOrDefault(x => x.Id == typedEntity.Id);
                oldEntity = typedEntity;
            }
            else if (entityType == typeof(Goods))
            {
                var typedEntity = entity as Goods;
                var oldEntity = Data.DumbData.Storage.goodsCollection.FirstOrDefault(x => x.Id == typedEntity.Id);
                oldEntity = typedEntity;
            }
            else if (entityType == typeof(GoodsRow))
            {
                var typedEntity = entity as GoodsRow;
                var oldEntity = Data.DumbData.Storage.goodsRowCollection.FirstOrDefault(x => x.Id == typedEntity.Id);
                oldEntity = typedEntity;
            }
            else if (entityType == typeof(Role))
            {
                var typedEntity = entity as Role;
                var oldEntity = Data.DumbData.Storage.roleCollection.FirstOrDefault(x => x.Id == typedEntity.Id);
                oldEntity = typedEntity;
            }
            else if (entityType == typeof(Permission))
            {
                var typedEntity = entity as Permission;
                var oldEntity = Data.DumbData.Storage.permissionCollection.FirstOrDefault(x => x.Id == typedEntity.Id);
                oldEntity = typedEntity;
            }
            else if (entityType == typeof(Comment))
            {
                var typedEntity = entity as Comment;
                var oldEntity = Data.DumbData.Storage.commentCollection.FirstOrDefault(x => x.Id == typedEntity.Id);
                oldEntity = typedEntity;
            }
            else if (entityType == typeof(OrderStatus))
            {
                var typedEntity = entity as OrderStatus;
                var oldEntity = Data.DumbData.Storage.orderStatusCollection.FirstOrDefault(x => x.Id == typedEntity.Id);
                oldEntity = typedEntity;
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
                Data.DumbData.Storage.categoryCollection.Remove(entity as ProductCategory);
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
                Data.DumbData.Storage.commentCollection.Remove(entity as Comment);
            }
            else if (entityType == typeof(OrderStatus))
            {
                Data.DumbData.Storage.orderStatusCollection.Remove(entity as OrderStatus);
            }
        }

        public T GetById(int Id)
        {
            T resultEntity = null;
            if (typeof(T) == typeof(PersonalInfo))
            {
                resultEntity = Data.DumbData.Storage.personalInfoCollection.FirstOrDefault(x => x.Id == Id) as T;
            }
            else if (typeof(T) == typeof(ContactInfo))
            {
                resultEntity = Data.DumbData.Storage.contactInfoCollection.FirstOrDefault(x => x.Id == Id) as T;
            }
            else if (typeof(T) == typeof(Customer))
            {
                resultEntity = Data.DumbData.Storage.customerCollection.FirstOrDefault(x => x.Id == Id) as T;
            }
            else if (typeof(T) == typeof(ProductCategory))
            {
                resultEntity = Data.DumbData.Storage.categoryCollection.FirstOrDefault(x => x.Id == Id) as T;
            }
            else if (typeof(T) == typeof(User))
            {
                resultEntity = Data.DumbData.Storage.userCollection.FirstOrDefault(x => x.Id == Id) as T;
            }
            else if (typeof(T) == typeof(Order))
            {
                resultEntity = Data.DumbData.Storage.orderCollection.FirstOrDefault(x => x.Id == Id) as T;
            }
            else if (typeof(T) == typeof(Goods))
            {
                resultEntity = Data.DumbData.Storage.goodsCollection.FirstOrDefault(x => x.Id == Id) as T;
            }
            else if (typeof(T) == typeof(GoodsRow))
            {
                resultEntity = Data.DumbData.Storage.goodsRowCollection.FirstOrDefault(x => x.Id == Id) as T;
            }
            else if (typeof(T) == typeof(Role))
            {
                resultEntity = Data.DumbData.Storage.roleCollection.FirstOrDefault(x => x.Id == Id) as T;
            }
            else if (typeof(T) == typeof(Permission))
            {
                resultEntity = Data.DumbData.Storage.permissionCollection.FirstOrDefault(x => x.Id == Id) as T;
            }
            else if (typeof(T) == typeof(Comment))
            {
                resultEntity = Data.DumbData.Storage.commentCollection.FirstOrDefault(x => x.Id == Id) as T;
            }
            else if (typeof(T) == typeof(OrderStatus))
            {
                resultEntity = Data.DumbData.Storage.orderStatusCollection.FirstOrDefault(x => x.Id == Id) as T;
            }
            return resultEntity;
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
