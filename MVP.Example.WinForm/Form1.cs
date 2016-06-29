using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MVP.Example.WinForm.Model;
using MVP.Example.WinForm.Model.Entity;
using MVP.Example.WinForm.Presenter;
using MVP.Example.WinForm.View;

namespace MVP.Example.WinForm
{
    public partial class Form1 : Form
    {
        private IUserModel userModel;
        private UserListPresenter userListPresenter;
        private UserAddPresenter userAddPresenter;

        public Form1()
        {
            InitializeComponent();

            userModel = new UserModel();

            userListPresenter =  new UserListPresenter(userModel, this.userList1);

            userAddPresenter = new UserAddPresenter(userModel, this.userAdd1);

            userAddPresenter.RefreshViewEvent += UserAddPresenter_RefreshViewEvent;
            userListPresenter.RefreshViewEvent += UserListPresenter_RefreshViewEvent;
        }

        private void UserAddPresenter_RefreshViewEvent(object sender, PresenterRereshViewEventArgument e)
        {
            this.userList1.ShowUser(e.Data as User);
        }

        private void UserListPresenter_RefreshViewEvent(object sender, PresenterRereshViewEventArgument e)
        {
            ;
        }
    }
}
