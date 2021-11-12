using System;

namespace Hope
    {
    public class Expenditure
    {
        public List<Staff> allPayment { get; set; }
        public List<Electricity>TotalPayment { get; set; }
        public List<Lawma> TotalPayment { get; set; }
        double GetTotalBills(List<IBills> TBills)
        {
            var bills = 0d;
            foreach (var Utility in TBills)
            {  
                    bills +=Utility.GetBills();
    
            }
            return bills;
        }
            
            
          double GetTotalSalaries(List<ISalary> Salary)
        {
            var totalSalaries = 0d;
            foreach (var item in Salary)
            {
                totalSalaries += Salary.GetSalary();
            }
            return totalSalaries;
        }
      
         double GetTotalAllowances(List<IAllowances> Allowances)
        {
            var totalAllowances = 0d;
            foreach (var item in Allowances)
            {
                totalAllowances += Allowances.GetAllowances();
            }
            return  totalAllowances;
        }

            
             double GetTotalCommission(List<ICommission>Commissions)
        {
            var totalCommission = 0d;
            foreach (var staff in Commissions)
            {
                totalCommission += staff.GetAllowances();
            }
            return  totalCommission;
        }

    }  

    public class Staff:ISalary,IAllowances,ICommission
        {

            public int StaffId { get; set; }
            public string StaffName { get; set; }
            public string Department { get; set; }

        }

   

    public interface  ISalary
        {
         public double GetSalary(){return 0;}
            }
        

    public interface  IAllowances
            {
         public double GetAllowances(){ return 0d;}
            }


    public interface ICommission

             {
    
             public double GetCommission(){ return 0;}
              }


    public class  Lawma: IBils
        {
            public double GetBills()
            {
                return 10000;
            }
         }


   
   
   
     public class Electricity :IBils
        {
            public double GetBills()
            {
                return 10000;
            }
        }

    public interface IBils
        {
            public double GetBills(){ return 0d;}
        }

       
        
  }
   