//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Oops_practice
//{
//    public class EncapsulationExample
//    {
//        private double balance;
//        public void Deposit(double amount)
//        {
//            if (amount > 0) {
//                balance += amount;


//            }
//        }
//        public void Withdraw(double amount) 
//        {
//            if (amount < balance) 
//            { 
//              balance -= amount;
//            }
//        }

//        public double GetBalance(){
//        return balance;

//        }

//        public static void Main(String[] args) 
//        {
//           EncapsulationExample acc = new EncapsulationExample();
//            acc.Deposit(9000);
//            Console.WriteLine("Current Balance :" + acc.balance);

//            acc.Withdraw(500);
//            Console.WriteLine(" Balance After Withdrawl  :" + acc.balance);

//           //Console.WriteLine(acc.GetBalance());  o r 
//            Console.WriteLine(" Final Balance :" + acc.balance);
//        }

//    }
//}
