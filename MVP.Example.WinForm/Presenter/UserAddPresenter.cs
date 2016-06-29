using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVP.Example.WinForm.Model;
using MVP.Example.WinForm.Model.Entity;
using MVP.Example.WinForm.View;

namespace MVP.Example.WinForm.Presenter
{
    public class UserAddPresenter : IUserAddPresenter
    {
        private readonly IUserBusinessModel model;
        private readonly IUserAddView userAddView;
        private readonly IUserListView userListView;

        public UserAddPresenter(IUserBusinessModel model, IUserAddView userAddView,IUserListView userListView)
        {
            this.model = model;
            this.userAddView = userAddView;
            this.userListView = userListView;
            userAddView.Presenter = this;
        }

        public void AddUser(User user)
        {
            model.AddItem(user);
            OnAddUserFinish(this, user);
        }

        public void OnAddUserFinish(IUserAddPresenter sender, User user)
        {
            userListView.ShowUser(user);
        }
    }
}
