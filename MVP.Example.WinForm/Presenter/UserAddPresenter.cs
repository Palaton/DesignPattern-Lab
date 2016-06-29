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
        private readonly IUserModel model;
        private readonly IUserAddView view;

        public UserAddPresenter(IUserModel model, IUserAddView view)
        {
            this.model = model;
            this.view = view;
            view.Presenter = this;
        }

        public event RefreshViewHandler RefreshViewEvent;

        public void AddUser(User user)
        {
            model.AddItem(user);
            RefreshViewEvent(this,new PresenterRereshViewEventArgument()
            {
                Data = user
            });
        }

        public void ResponseNotification(string message)
        {
            throw new NotImplementedException();
        }
    }
}
