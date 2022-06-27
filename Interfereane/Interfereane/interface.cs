using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewQuestion

{

    public class PartTime_Employee_Wage
    {
        public int IS_Empolyee_Present = 1;
        public int Full_time = 1;
        public int Wage_Per_hour = 20;
        public int Full_Day_Hour = 16;
        public int Part_Day_Hour = 8;
        public int DailyWage = 0;

        public void CheckDailyEmpWage()
        {
            Random CheckEmp = new Random();
            int value = CheckEmp.Next(0, 2);
            if (value == IS_Empolyee_Present)
            {
                Random Timecheck = new Random();
                int Workinghour = Timecheck.Next(0, 2);
                if (Workinghour == Full_time)
                {
                    DailyWage = Workinghour * Full_Day_Hour;
                    Console.WriteLine("Employee is present, in full time and Dailywage = {0}", DailyWage);
                }

                else
                {
                    DailyWage = Workinghour * Part_Day_Hour;
                    Console.WriteLine("Employee is present, in part time and Dailywage = {0}", DailyWage);

                }
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }

        }
    }
    public class DailyEmployeewage : PartTime_Employee_Wage
    {
        int IS_Empolyee_Present1 = 1;
        int Wage_Per_hour1 = 20;
        int Full_Day_Hour1 = 8;
        int DailyWage1 = 0;

        public void CheckDailyEmpWage1()
        {
            Random CheckEmp = new Random();
            int value = CheckEmp.Next(0, 2);
            if (value == IS_Empolyee_Present1)
            {
                DailyWage = Full_Day_Hour1 * Wage_Per_hour1;

                Console.WriteLine("Employee Present and Dailywage = {0}", DailyWage1);
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
