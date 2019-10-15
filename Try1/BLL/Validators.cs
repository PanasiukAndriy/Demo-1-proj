using System;
using Try1.DAL.Interfaces;

namespace Try1.BLL
{
    public static class Validators
    {
        public static int GetCurrentCustomer(IUnitOfWork uow)
        {
            uow.Customers.ShowAllCostomers();
            int CurrentCustomerId = 0;
            bool IsValidCustomer = false;
            do
            {
                Console.WriteLine("Choose a current customer Id ");
                if (int.TryParse(Console.ReadLine(), out CurrentCustomerId))
                {
                    if (uow.Customers.IfExist(CurrentCustomerId))
                    {
                        IsValidCustomer = true;
                    }
                    else
                    {
                        Console.WriteLine($"There is no customer with Id { CurrentCustomerId }");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect! \n  Choose a current customer Id ");
                }
            }
            while (!IsValidCustomer);

            return CurrentCustomerId;
        }

        //static public string GetValidString(string fieldPersonalInfo)
        //{
        //    string result = string.Empty;
        //    string tempValue = string.Empty;
        //    bool Valid = false;
        //    do
        //    {
        //        Console.WriteLine($"Enter : { fieldPersonalInfo }");
        //        tempValue = Console.ReadLine();
        //        if (tempValue.Length > 3 && !string.IsNullOrWhiteSpace(tempValue))
        //        {
        //            result = tempValue;
        //            Valid = true;
        //        }
        //    }
        //    while (!Valid);

        //    return result;
        //}
    }
}
