using System;
using System.Collections.Generic;
using System.Reflection;
using MVP.Example.WinForm.Model;
using MVP.Example.WinForm.Model.Entity;
using MVP.Example.WinForm.View;

namespace MVP.Example.WinForm.Presenter
{
    public class UserListPresenter : IUserListPresenter
    {
        private readonly IUserBusinessModel model;
        private readonly IUserListView view;

        public UserListPresenter(IUserBusinessModel model, IUserListView view)
        {
            this.model = model;
            this.view = view;
            this.view.Presenter = this;
        }

        public void ResponseNotification(string message)
        {
        }

        public void ShowUsers(List<User> users)
        {
            view.ShowUsers(users);
            OnListUsersFinish(this, users);
        }

        public void ShowUser(User user)
        {
            view.ShowUser(user);
            OnListUserFinish(this,user);
        }

        public void OnListUserFinish(IUserListPresenter sender, User user)
        {
            ;
        }

        public void OnListUsersFinish(IUserListPresenter sender, List<User> users)
        {
            ;
        }
    }
}
