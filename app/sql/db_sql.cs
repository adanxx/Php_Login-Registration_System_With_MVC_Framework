using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Mvc
{
    #region Posts
    public class Posts
    {
        #region Member Variables
        protected int _id;
        protected int _user_id;
        protected string _title;
        protected string _body;
        protected DateTime _created_at;
        #endregion
        #region Constructors
        public Posts() { }
        public Posts(int user_id, string title, string body, DateTime created_at)
        {
            this._user_id=user_id;
            this._title=title;
            this._body=body;
            this._created_at=created_at;
        }
        #endregion
        #region Public Properties
        public virtual int Id
        {
            get {return _id;}
            set {_id=value;}
        }
        public virtual int User_id
        {
            get {return _user_id;}
            set {_user_id=value;}
        }
        public virtual string Title
        {
            get {return _title;}
            set {_title=value;}
        }
        public virtual string Body
        {
            get {return _body;}
            set {_body=value;}
        }
        public virtual DateTime Created_at
        {
            get {return _created_at;}
            set {_created_at=value;}
        }
        #endregion
    }
    #endregion
}