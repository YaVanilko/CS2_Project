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
                Storage.PersonalInfoCollection.Add(entity as PersonalInfo);
            }
            else if (entityType == typeof(ContactInfo))
            {
                Storage.ContactInfoCollection.Add(entity as ContactInfo);
            }
            else if (entityType == typeof(Customer))
            {
                Storage.CustomerCollection.Add(entity as Customer);
            }
            else if (entityType == typeof(ProductCategory))
	        {
                Storage.categoryCollection.Add(entity as ProductCategory);
	        }
            else if (entityType == typeof(User))
            {
                Storage.UserCollection.Add(entity as User);
            }
            else if (entityType == typeof(Order))
            {
                Storage.OrderCollection.Add(entity as Order);
            }
            else if (entityType == typeof(Goods))
            {
                Storage.goodsCollection.Add(entity as Goods);
            }
            else if (entityType == typeof(GoodsRow))
            {
                Storage.GoodsRowCollection.Add(entity as GoodsRow);
            }
            else if (entityType == typeof(Role))
            {
                Storage.RoleCollection.Add(entity as Role);
            }
            else if (entityType == typeof(Permission))
            {
                Storage.PermissionCollection.Add(entity as Permission);
            }
            else if (entityType == typeof(Comment))
            {
                Storage.CommentCollection.Add(entity as Comment);
            }
            else if (entityType == typeof(OrderStatus))
            {
                Storage.OrderStatusCollection.Add(entity as OrderStatus);
            }
        }

        public void Update(T entity)
        {
            System.Type entityType = entity.GetType();
            if (entityType == typeof(PersonalInfo))
            {
                var typedEntity = entity as PersonalInfo;
                var oldEntity = Storage.PersonalInfoCollection.FirstOrDefault(x => x.Id == typedEntity.Id);
                oldEntity = typedEntity;
            }
            else if (entityType == typeof(ContactInfo))
            {
                var typedEntity = entity as ContactInfo;
                var oldEntity = Storage.ContactInfoCollection.FirstOrDefault(x => x.Id == typedEntity.Id);
                oldEntity = typedEntity;
            }
            else if (entityType == typeof(Customer))
            {
                var typedEntity = entity as Customer;
                var oldEntity = Storage.CustomerCollection.FirstOrDefault(x => x.Id == typedEntity.Id);
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
                var oldEntity = Storage.UserCollection.FirstOrDefault(x => x.Id == typedEntity.Id);
                oldEntity = typedEntity;
            }
            else if (entityType == typeof(Order))
            {
                var typedEntity = entity as Order;
                var oldEntity = Storage.OrderCollection.FirstOrDefault(x => x.Id == typedEntity.Id);
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
                var oldEntity = Storage.GoodsRowCollection.FirstOrDefault(x => x.Id == typedEntity.Id);
                oldEntity = typedEntity;
            }
            else if (entityType == typeof(Role))
            {
                var typedEntity = entity as Role;
                var oldEntity = Storage.RoleCollection.FirstOrDefault(x => x.Id == typedEntity.Id);
                oldEntity = typedEntity;
            }
            else if (entityType == typeof(Permission))
            {
                var typedEntity = entity as Permission;
                var oldEntity = Storage.PermissionCollection.FirstOrDefault(x => x.Id == typedEntity.Id);
                oldEntity = typedEntity;
            }
            else if (entityType == typeof(Comment))
            {
                var typedEntity = entity as Comment;
                var oldEntity = Storage.CommentCollection.FirstOrDefault(x => x.Id == typedEntity.Id);
                oldEntity = typedEntity;
            }
            else if (entityType == typeof(OrderStatus))
            {
                var typedEntity = entity as OrderStatus;
                var oldEntity = Storage.OrderStatusCollection.FirstOrDefault(x => x.Id == typedEntity.Id);
                oldEntity = typedEntity;
            }
        }

        public void Delete(T entity)
        {
            System.Type entityType = entity.GetType();
            if (entityType == typeof(PersonalInfo))
            {
                Storage.PersonalInfoCollection.Remove(entity as PersonalInfo);
            }
            else if (entityType == typeof(ContactInfo))
            {
                Storage.ContactInfoCollection.Remove(entity as ContactInfo);
            }
            else if (entityType == typeof(Customer))
            {
                Storage.CustomerCollection.Remove(entity as Customer);
            }
            else if (entityType == typeof(ProductCategory))
            {
                Storage.categoryCollection.Remove(entity as ProductCategory);
            }
            else if (entityType == typeof(User))
            {
                Storage.UserCollection.Remove(entity as User);
            }
            else if (entityType == typeof(Order))
            {
                Storage.OrderCollection.Remove(entity as Order);
            }
            else if (entityType == typeof(Goods))
            {
                Storage.goodsCollection.Remove(entity as Goods);
            }
            else if (entityType == typeof(GoodsRow))
            {
                Storage.GoodsRowCollection.Remove(entity as GoodsRow);
            }
            else if (entityType == typeof(Role))
            {
                Storage.RoleCollection.Remove(entity as Role);
            }
            else if (entityType == typeof(Permission))
            {
                Storage.PermissionCollection.Remove(entity as Permission);
            }
            else if (entityType == typeof(Comment))
            {
                Storage.CommentCollection.Remove(entity as Comment);
            }
            else if (entityType == typeof(OrderStatus))
            {
                Storage.OrderStatusCollection.Remove(entity as OrderStatus);
            }
        }

        public T GetById(int Id)
        {
            T resultEntity = null;
            if (typeof(T) == typeof(PersonalInfo))
            {
                resultEntity = Storage.PersonalInfoCollection.FirstOrDefault(x => x.Id == Id) as T;
            }
            else if (typeof(T) == typeof(ContactInfo))
            {
                resultEntity = Storage.ContactInfoCollection.FirstOrDefault(x => x.Id == Id) as T;
            }
            else if (typeof(T) == typeof(Customer))
            {
                resultEntity = Storage.CustomerCollection.FirstOrDefault(x => x.Id == Id) as T;
            }
            else if (typeof(T) == typeof(ProductCategory))
            {
                resultEntity = Storage.categoryCollection.FirstOrDefault(x => x.Id == Id) as T;
            }
            else if (typeof(T) == typeof(User))
            {
                resultEntity = Storage.UserCollection.FirstOrDefault(x => x.Id == Id) as T;
            }
            else if (typeof(T) == typeof(Order))
            {
                resultEntity = Storage.OrderCollection.FirstOrDefault(x => x.Id == Id) as T;
            }
            else if (typeof(T) == typeof(Goods))
            {
                resultEntity = Storage.goodsCollection.FirstOrDefault(x => x.Id == Id) as T;
            }
            else if (typeof(T) == typeof(GoodsRow))
            {
                resultEntity = Storage.GoodsRowCollection.FirstOrDefault(x => x.Id == Id) as T;
            }
            else if (typeof(T) == typeof(Role))
            {
                resultEntity = Storage.RoleCollection.FirstOrDefault(x => x.Id == Id) as T;
            }
            else if (typeof(T) == typeof(Permission))
            {
                resultEntity = Storage.PermissionCollection.FirstOrDefault(x => x.Id == Id) as T;
            }
            else if (typeof(T) == typeof(Comment))
            {
                resultEntity = Storage.CommentCollection.FirstOrDefault(x => x.Id == Id) as T;
            }
            else if (typeof(T) == typeof(OrderStatus))
            {
                resultEntity = Storage.OrderStatusCollection.FirstOrDefault(x => x.Id == Id) as T;
            }
            return resultEntity;
        }

        public IEnumerable<T> GetAll()
        {
            List<PersonalInfo> newPersonStor = new List<PersonalInfo>();
            if (typeof(T) == typeof(PersonalInfo))
            {
                
                foreach (var item in Storage.PersonalInfoCollection)
                {
                    newPersonStor.Add(item);
                }
            }

            return (IEnumerable<T>)newPersonStor;
        }
    }
}
