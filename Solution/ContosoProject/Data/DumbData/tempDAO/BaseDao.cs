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
                Storage.personalInfoCollection.Add(entity as PersonalInfo);
            }
            else if (entityType == typeof(ContactInfo))
            {
                Storage.contactInfoCollection.Add(entity as ContactInfo);
            }
            else if (entityType == typeof(Customer))
            {
                Storage.customerCollection.Add(entity as Customer);
            }
            else if (entityType == typeof(ProductCategory))
	        {
                Storage.categoryCollection.Add(entity as ProductCategory);
	        }
            else if (entityType == typeof(User))
            {
                Storage.userCollection.Add(entity as User);
            }
            else if (entityType == typeof(Order))
            {
                Storage.orderCollection.Add(entity as Order);
            }
            else if (entityType == typeof(Goods))
            {
                Storage.goodsCollection.Add(entity as Goods);
            }
            else if (entityType == typeof(GoodsRow))
            {
                Storage.goodsRowCollection.Add(entity as GoodsRow);
            }
            else if (entityType == typeof(Role))
            {
                Storage.roleCollection.Add(entity as Role);
            }
            else if (entityType == typeof(Permission))
            {
                Storage.permissionCollection.Add(entity as Permission);
            }
            else if (entityType == typeof(Comment))
            {
                Storage.commentCollection.Add(entity as Comment);
            }
            else if (entityType == typeof(OrderStatus))
            {
                Storage.orderStatusCollection.Add(entity as OrderStatus);
            }
        }

        public void Update(T entity)
        {
            System.Type entityType = entity.GetType();
            if (entityType == typeof(PersonalInfo))
            {
                var typedEntity = entity as PersonalInfo;
                var oldEntity = Storage.personalInfoCollection.FirstOrDefault(x => x.Id == typedEntity.Id);
                oldEntity = typedEntity;
            }
            else if (entityType == typeof(ContactInfo))
            {
                var typedEntity = entity as ContactInfo;
                var oldEntity = Storage.contactInfoCollection.FirstOrDefault(x => x.Id == typedEntity.Id);
                oldEntity = typedEntity;
            }
            else if (entityType == typeof(Customer))
            {
                var typedEntity = entity as Customer;
                var oldEntity = Storage.customerCollection.FirstOrDefault(x => x.Id == typedEntity.Id);
                oldEntity = typedEntity;
            }
            else if (entityType == typeof(ProductCategory))
            {
                var typedEntity = entity as ProductCategory;
                var oldEntity = Storage.categoryCollection.FirstOrDefault(x => x.Id == typedEntity.Id);
                oldEntity = typedEntity;
            }
            else if (entityType == typeof(User))
            {
                var typedEntity = entity as User;
                var oldEntity = Storage.userCollection.FirstOrDefault(x => x.Id == typedEntity.Id);
                oldEntity = typedEntity;
            }
            else if (entityType == typeof(Order))
            {
                var typedEntity = entity as Order;
                var oldEntity = Storage.orderCollection.FirstOrDefault(x => x.Id == typedEntity.Id);
                oldEntity = typedEntity;
            }
            else if (entityType == typeof(Goods))
            {
                var typedEntity = entity as Goods;
                var oldEntity = Storage.goodsCollection.FirstOrDefault(x => x.Id == typedEntity.Id);
                oldEntity = typedEntity;
            }
            else if (entityType == typeof(GoodsRow))
            {
                var typedEntity = entity as GoodsRow;
                var oldEntity = Storage.goodsRowCollection.FirstOrDefault(x => x.Id == typedEntity.Id);
                oldEntity = typedEntity;
            }
            else if (entityType == typeof(Role))
            {
                var typedEntity = entity as Role;
                var oldEntity = Storage.roleCollection.FirstOrDefault(x => x.Id == typedEntity.Id);
                oldEntity = typedEntity;
            }
            else if (entityType == typeof(Permission))
            {
                var typedEntity = entity as Permission;
                var oldEntity = Storage.permissionCollection.FirstOrDefault(x => x.Id == typedEntity.Id);
                oldEntity = typedEntity;
            }
            else if (entityType == typeof(Comment))
            {
                var typedEntity = entity as Comment;
                var oldEntity = Storage.commentCollection.FirstOrDefault(x => x.Id == typedEntity.Id);
                oldEntity = typedEntity;
            }
            else if (entityType == typeof(OrderStatus))
            {
                var typedEntity = entity as OrderStatus;
                var oldEntity = Storage.orderStatusCollection.FirstOrDefault(x => x.Id == typedEntity.Id);
                oldEntity = typedEntity;
            }
        }

        public void Delete(T entity)
        {
            System.Type entityType = entity.GetType();
            if (entityType == typeof(PersonalInfo))
            {
                Storage.personalInfoCollection.Remove(entity as PersonalInfo);
            }
            else if (entityType == typeof(ContactInfo))
            {
                Storage.contactInfoCollection.Remove(entity as ContactInfo);
            }
            else if (entityType == typeof(Customer))
            {
                Storage.customerCollection.Remove(entity as Customer);
            }
            else if (entityType == typeof(ProductCategory))
            {
                Storage.categoryCollection.Remove(entity as ProductCategory);
            }
            else if (entityType == typeof(User))
            {
                Storage.userCollection.Remove(entity as User);
            }
            else if (entityType == typeof(Order))
            {
                Storage.orderCollection.Remove(entity as Order);
            }
            else if (entityType == typeof(Goods))
            {
                Storage.goodsCollection.Remove(entity as Goods);
            }
            else if (entityType == typeof(GoodsRow))
            {
                Storage.goodsRowCollection.Remove(entity as GoodsRow);
            }
            else if (entityType == typeof(Role))
            {
                Storage.roleCollection.Remove(entity as Role);
            }
            else if (entityType == typeof(Permission))
            {
                Storage.permissionCollection.Remove(entity as Permission);
            }
            else if (entityType == typeof(Comment))
            {
                Storage.commentCollection.Remove(entity as Comment);
            }
            else if (entityType == typeof(OrderStatus))
            {
                Storage.orderStatusCollection.Remove(entity as OrderStatus);
            }
        }

        public T GetById(int Id)
        {
            T resultEntity = null;
            if (typeof(T) == typeof(PersonalInfo))
            {
                resultEntity = Storage.personalInfoCollection.FirstOrDefault(x => x.Id == Id) as T;
            }
            else if (typeof(T) == typeof(ContactInfo))
            {
                resultEntity = Storage.contactInfoCollection.FirstOrDefault(x => x.Id == Id) as T;
            }
            else if (typeof(T) == typeof(Customer))
            {
                resultEntity = Storage.customerCollection.FirstOrDefault(x => x.Id == Id) as T;
            }
            else if (typeof(T) == typeof(ProductCategory))
            {
                resultEntity = Storage.categoryCollection.FirstOrDefault(x => x.Id == Id) as T;
            }
            else if (typeof(T) == typeof(User))
            {
                resultEntity = Storage.userCollection.FirstOrDefault(x => x.Id == Id) as T;
            }
            else if (typeof(T) == typeof(Order))
            {
                resultEntity = Storage.orderCollection.FirstOrDefault(x => x.Id == Id) as T;
            }
            else if (typeof(T) == typeof(Goods))
            {
                resultEntity = Storage.goodsCollection.FirstOrDefault(x => x.Id == Id) as T;
            }
            else if (typeof(T) == typeof(GoodsRow))
            {
                resultEntity = Storage.goodsRowCollection.FirstOrDefault(x => x.Id == Id) as T;
            }
            else if (typeof(T) == typeof(Role))
            {
                resultEntity = Storage.roleCollection.FirstOrDefault(x => x.Id == Id) as T;
            }
            else if (typeof(T) == typeof(Permission))
            {
                resultEntity = Storage.permissionCollection.FirstOrDefault(x => x.Id == Id) as T;
            }
            else if (typeof(T) == typeof(Comment))
            {
                resultEntity = Storage.commentCollection.FirstOrDefault(x => x.Id == Id) as T;
            }
            else if (typeof(T) == typeof(OrderStatus))
            {
                resultEntity = Storage.orderStatusCollection.FirstOrDefault(x => x.Id == Id) as T;
            }
            return resultEntity;
        }

        public IEnumerable<T> GetAll()
        {
            List<PersonalInfo> newPersonStor = new List<PersonalInfo>();
            if (typeof(T) == typeof(PersonalInfo))
            {
                
                foreach (var item in Storage.personalInfoCollection)
                {
                    newPersonStor.Add(item);
                }
            }

            return (IEnumerable<T>)newPersonStor;
        }
    }
}
