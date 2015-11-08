using Data.DumbData;
using Data.EFData;
using Domain.DAO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUI.GoodsAll.AddGoods
{
    public class AddGoodsPresenter : INotifyPropertyChanged
    {
        AddGoods view;
        public GoodsCategoryService service = new GoodsCategoryService();

        Goods thisGoods;
        public List<ProductCategory> Categories { get; private set; }
        public List<Comment> Comments { get { return thisGoods.Coments.ToList(); } set { } }

        public AddGoodsPresenter(AddGoods view, int id)
        {
            Categories = new List<ProductCategory>();
            Categories.AddRange(service.CategoryDao.GetAll());

            this.view = view;
            if (id < 1)
            {
                thisGoods = new Goods();
            }
            else
            {
                thisGoods = service.GoodsDao.GetById(id);
            }
        }

        public string Name
        {
            get { return thisGoods.Name; }
         
            set
            {
                if (thisGoods.Name != value)
                {
                    thisGoods.Name = value;
                    NotifyPropertyChanged("Name");
                }
            }
        }

        public string SKU
        {
            get { return thisGoods.SKU; }
            set
            {
                if (thisGoods.SKU != value)
                {
                    thisGoods.SKU = value;
                    NotifyPropertyChanged("SKU");
                }
            }
        }

        public double Price
        {
            get { return thisGoods.Price; }
            set
            {
                if (thisGoods.Price != value)
                {
                    thisGoods.Price = value;
                    NotifyPropertyChanged("Price");
                }
            }
        }

        public int Count
        {
            get { return thisGoods.Count; }
            set
            {
                if (thisGoods.Count != value)
                {
                    thisGoods.Count = value;
                    NotifyPropertyChanged("Count");
                }
            }
        }

        public ProductCategory Category
        {
            get { return thisGoods.Category; }
            set
            {
                if (thisGoods.Category != value)
                {
                    thisGoods.Category = value;
                    NotifyPropertyChanged("Category");
                }
            }
        }

        //public string Coments
        //{
        //    get { return thisGoods.Coments.ToString(); }
        //    //set
        //    //{
        //    //    if (thisGoods.Coments != value)
        //    //    {
        //    //        thisGoods.Name = value;
        //    //        NotifyPropertyChanged("FirstName");
        //    //    }
        //    //}
        //}

        public bool IsActive
        {
            get { return thisGoods.IsActive; }
            set
            {
                if (thisGoods.IsActive != value)
                {
                    thisGoods.IsActive = value;
                    NotifyPropertyChanged("IsActive");
                }
            }
        }

        private string currentComment = string.Empty;
        public string CurentComment
        {
            get { return currentComment; }
            set
            {
                if (currentComment != value)
                {
                    currentComment = value;

                } NotifyPropertyChanged("CurentComment");
            }
        }

        public void Save()
        {
            //когда попадаю сюда, нективный товар становится активным
            if (!string.IsNullOrWhiteSpace(currentComment))
            {
                thisGoods.Coments.Add(new Comment() { Message = currentComment, Type = CommentType.Goods });
                currentComment = string.Empty;
            }
            if (thisGoods.Id > 0)
            {
                service.GoodsDao.Update(thisGoods);
            }
            else
            {
                service.GoodsDao.Add(thisGoods);//???
            }
            NotifyPropertyChanged("Save");
        }

        //public void Update(Goods goods)
        //{
        //    service.GoodsDao.Update(goods);
        //}

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        public void SaveAndNew(Goods g)
        {
            this.Save();
           // thisGoods = new Goods();
            NotifyPropertyChanged("New goods");
        }
    }
}
