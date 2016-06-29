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
        private IUserBusinessModel userModel;
        private UserListPresenter userListPresenter;
        private UserAddPresenter userAddPresenter;

        public Form1()
        {
            InitializeComponent();

            userModel = new UserBusinessModel();

            userListPresenter =  new UserListPresenter(userModel, this.userList1);

            userAddPresenter = new UserAddPresenter(userModel, this.userAdd1,this.userList1);
        }
    }
}
