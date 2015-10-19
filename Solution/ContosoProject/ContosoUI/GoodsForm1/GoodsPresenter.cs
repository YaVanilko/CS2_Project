using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUI
{
    class GoodsPresenter

    {
        private IGoodsModel model;
        private IGoodsView view;

        public List<Goods> forLoad;

       public GoodsPresenter(IGoodsView view, IGoodsModel model)
        {
            this.view = view;
            this.model = model;
            this.view.loadGoodsForm += new EventHandler<EventArgs>(OnGoodsFormLoad);
            this.view.searchButtonClick += new EventHandler<EventArgs>(OnSearchButtonClick);
        }


       private void OnGoodsFormLoad(object sender, EventArgs e)
       {
           forLoad=this.model.GetListGoods();
       }

       private void OnSearchButtonClick(object sender, EventArgs e)
       {
 
       }
    }
}
