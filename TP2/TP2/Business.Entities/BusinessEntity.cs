using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class BusinessEntity
    {
        private int _ID;
        private States _States;

        public BusinessEntity()
        {
            this.State = States.New;
        }

        public int ID
        {
            get { return _ID; }

            set { _ID = value; }
        }

        public States State
        {
            get { return _States; }
            set { _States = value; }
        }

        public enum States
        {
            Deleted,
            New,
            Modified,
            Unmodified
        }
    }
}
