using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MVP.Example.WinForm.Model.Entity;
using MVP.Example.WinForm.Presenter;


namespace MVP.Example.WinForm.View
{
    public partial class UserListView : UserControl, IUserListView
    {
        public IUserListPresenter Presenter { get; set; }

        public UserListView()
        {
            InitializeComponent();
        }

        public void ShowUsers(List<User> users)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = users;
            //Presenter.ShowUsers(users);
        }

        public void ShowUser(User user)
        {
            int rowIndex=this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows[rowIndex].Cells[0].Value = user.Name;
            this.dataGridView1.Rows[rowIndex].Cells[1].Value = user.Age;
            //Presenter.ShowUser(user);
        }
    }
}
