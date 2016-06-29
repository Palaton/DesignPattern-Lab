using System;
using System.Windows.Forms;
using MVP.Example.WinForm.Model.Entity;
using MVP.Example.WinForm.Presenter;

namespace MVP.Example.WinForm.View
{
    public partial class UserAddView : UserControl, IUserAddView
    {
        public IUserAddPresenter Presenter { get; set; }

        public UserAddView()
        {
            InitializeComponent();
        }

        public void AddUser(User user)
        {
            Presenter.AddUser(user);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUser(new User()
            {
                Name=this.txbName.Text,
                Age =int.Parse(this.txbAge.Text)
            });
        }
    }
}
