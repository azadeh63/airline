using System;

namespace Flight_Reservation_System
{
    class User
    {
        public void Search_flight() { }
    }

    class Guest : User
    {
        void register() { }
    }

    class Customer : User
    {
        public
            string FirstName;
        string LastName;
        string UserName;
        string Password;
        DateTime BirthDate;
        string Email;
        private
            void customer_login()
        { }
        void book() { }
        void cancel() { }
        void view_history() { }
    }

    class Admin : User
    {
        public
            string UserName;
        string Password;
        string Email;

        private
            void admin_login()
        { }
        void add_flight() { }
        void add_admin() { }
        void report() { }
    }

}
