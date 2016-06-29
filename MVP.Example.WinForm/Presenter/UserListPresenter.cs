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
        private readonly IUserModel model;
        private readonly IUserListView view;

        public UserListPresenter(IUserModel model, IUserListView view)
        {
            this.model = model;
            this.view = view;
            this.view.Presenter = this;
        }

        public event RefreshViewHandler RefreshViewEvent;

        public void ResponseNotification(string message)
        {
        }

        public void ShowUsers(List<User> users)
        {
            view.ShowUsers(users);
            RefreshViewEvent(this, new PresenterRereshViewEventArgument()
            {
                Data = users
            });
        }

        public void ShowUser(User user)
        {
            RefreshViewEvent(this, new PresenterRereshViewEventArgument()
            {
                Data = user
            });
        }
    }
}
