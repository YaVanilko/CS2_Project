using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ContosoUI.Order.AddEdit;

namespace ContosoUI.Order
{
    public partial class AddEditOrderView : XtraForm
    {
        AddEditOrderPresenter presenter;
        public AddEditOrderView() : this(-1)
        {
            InitializeComponent();
        }

        public AddEditOrderView(int id)
        {
            InitializeComponent();
            presenter = new AddEditOrderPresenter(this, 3);
        }

        private void AddEditOrderView_Load(object sender, EventArgs e)
        {
            BindingSource bindings = new BindingSource();
            bindings.DataSource = presenter;

            customerComboBox.DataBindings.Clear();
            customerComboBox.DataSource = presenter.customersView;
            //customerComboBoxEdit.DataBindings.Add("DataSource", bindings, "customersView");
            customerComboBox.DataBindings.Add("SelectedItem", bindings, "SelectedCustomer");

            priceEdit.DataBindings.Clear();
            priceEdit.DataBindings.Add("Text", bindings, "TotalCost");

            statusComboBox.DataBindings.Clear();
            statusComboBox.DataSource = presenter.statusesView;
            //statusComboBox.DataBindings.Add("DataSource", bindings, "Statuses");
            statusComboBox.DataBindings.Add("SelectedItem", bindings, "SelectedStatus");

            goodsComboBox.DataBindings.Clear();
            goodsComboBox.DataSource = presenter.goodsView;

            commentsListBox.DataBindings.Clear();
            commentsListBox.DataSource = presenter.commentsView;
            commentsListBox.DataBindings.Add("SelectedIndex", bindings, "CommentIndex");

            commentTextEdit.DataBindings.Clear();
            commentTextEdit.DataBindings.Add("Text", bindings, "Message");

        }

        private void commentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void addCommentButton_Click(object sender, EventArgs e)
        {
            presenter.AddNewComment(presenter.Comment);
        }

        private void editCommentButton_Click(object sender, EventArgs e)
        {
            presenter.UpdateCommentStorage(presenter.Comment);
        }

        private void commentsListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            commentTextEdit.Text = commentsListBox.SelectedItem.ToString();
            
        }
    }
}