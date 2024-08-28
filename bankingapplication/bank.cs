

//this class is created by kshitij lavhe on 28 Aug 2024
// this class is present in same namespace of the code

namespace bankingapplication
{
    public class Account    
    {
        private int ac_no;          //declaration of variables (private for not be able to accessed outside class)
        private string name;
        private double balance;

        public Account(int ac_no, string name, double balance)  //constructor 
        {
            Ac_no = ac_no;
            Name = name;
            this.balance = balance;

        }


        public void Deposit(double amt)  //deposit function
        {
            balance += amt;
            
        }

        public void Withdraw(double amt)  //withdraw function
        {
            balance -= amt;
        }


        public int Ac_no        //parameter for acno
        {
            get { return ac_no; }
            set { ac_no = value; }
        }
        public string Name  
        {
            get { return name; }
            set { name = value; }  
        }
        public double Balance       //no set used to keep balance read only
        {
            get { return balance; }
        }

    }

}
