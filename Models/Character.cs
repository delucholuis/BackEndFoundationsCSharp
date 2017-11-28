namespace BackEndFoundationsCSharp.Models{
    public class Customer{
        private int _id = 1;
        public int Id{
            get {return _id; }
            set {_id = value; }
        }

        private string _firstname = "Jon";
        public string FirstName{
            get { return _firstname; }
            set { _firstname = value; }
        }

        private string _lastname = "Snow";

        public string LastName{
            get{ return _lastname; }
            set{ _lastname = value; }
        }
    }
}
