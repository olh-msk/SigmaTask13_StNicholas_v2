using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask13_StNicholas_v2
{
    interface IOperationSendRequest
    {
        public void SendRequestToStNicholas();
    }
    class Child:IOperationSendRequest
    {
        public string Name { get; set; }
        //true - хлопець
        public bool Gender { get; set; }
        public int Age { get; set; }

        public int GoodActions{get;set;}
        public int BadActions{get;set;}



        public Child()
        {
            Name = "doesn`t have";
            Gender = true;
            Age = GetRandomAge();

            GoodActions = GetRandomNumOfAction();
            BadActions = GetRandomNumOfAction();
        }
        public void SendRequestToStNicholas()
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
        public int GetRandomAge()
        {
            Random r = new Random();
            return r.Next(1, 22);
        }
    }
}
