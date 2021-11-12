using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask13_StNicholas_v2
{
    interface IOperationSendRequest
    {
        public void SendRequest();
    }
    class Child:IOperationSendRequest
    {
        public string Name { get; set; }
        //true - хлопець
        public bool Gender { get; set; }

        public int GoodActions{get;set;}
        public int BadActions{get;set;}



        public Child()
        {
            Name = "doesn`t have";
            Gender = true;

            GoodActions = GetRandomNumOfAction();
            BadActions = GetRandomNumOfAction();
        }
        public void SendRequest()
        {
            StNicholas.Instance().AddKid(this);
        }
        public bool IsGood()
        {
            return GoodActions - BadActions >= 0 ? true : false;
        }

        public int GetRandomNumOfAction()
        {
            Random r = new Random();
            return r.Next(0,10);
        }
    }
}
