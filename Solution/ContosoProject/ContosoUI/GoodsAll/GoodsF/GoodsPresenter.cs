using Data.DumbData;
using Domain.DAO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUI.GoodsAll.GoodsF
{
    class GoodsPresenter:INotifyPropertyChanged
    {
        private IGoodsRepository model = new GoodsDao();
        private IProductCategoryRepository modelCategory = new ProductCategoryDao();
        private GoodsForm goodsView;

        public List<GoodsListViewModel> viewModel = new List<GoodsListViewModel>();
        List<Goods> goodsForLoad = new List<Goods>();
        public List<Goods> GoodsForLoad { get { return goodsForLoad; } set { } }
        public List<string> productCategoryList = new List<string>();

        public GoodsPresenter(GoodsForm goodsView)
        {
            this.goodsView = goodsView;
            foreach (ProductCategory pc in Storage.categoryCollection)
            {
                productCategoryList.Add(pc.CategoryName);
            }
        }

        public List<GoodsListViewModel> SearchGoodsOnActivity(bool isActive)
        {
            goodsForLoad = model.GetAll().ToList();
            viewModel.Clear();
            foreach (Goods g in goodsForLoad)
            {
                if (g.Category.IsActive==isActive)
                {
                    viewModel.Add(new GoodsListViewModel
                    {
                        Id = g.Id,
                        Name = g.Name,
                        SKU = g.SKU,
                        Price = g.Price,
                        Count = g.Count,
                        Category = g.Category.CategoryName,
                        Coment = g.Coments.ToString(),
                        isActive = g.IsActive,
                        User = g.User.Login
                    });
                }
            }

            return viewModel;
        }

        public List<GoodsListViewModel> SearchGoodsOnCategory(string category)
        {
            goodsForLoad = model.GetAll().ToList();
            viewModel.Clear();
            if (category == "Все")
            {
                
                foreach (Goods g in goodsForLoad)
                {
                    viewModel.Add(new GoodsListViewModel
                        {
                            Id = g.Id,
                            Name = g.Name,
                            SKU = g.SKU,
                            Price = g.Price,
                            Count = g.Count,
                            Category = g.Category.CategoryName,
                            Coment = g.Coments.ToString(),
                            isActive = g.IsActive,
                            //User = g.User.Login
                        });
                }
            }

                else
                {
                    foreach (Goods g in goodsForLoad)
                {
                   
                        if(g.Category.CategoryName==category)
                        {
                            viewModel.Add(new GoodsListViewModel
                                {
                                    Id = g.Id,
                                    Name = g.Name,
                                    SKU = g.SKU,
                                    Price = g.Price,
                                    Count = g.Count,
                                    Category = g.Category.CategoryName,
                                    Coment = g.Coments.ToString(),
                                    isActive = g.IsActive,
                                    //User = g.User.Login
                                });
                        }
                }

                
            }

            return viewModel;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }
}
