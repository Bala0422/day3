using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    public class Class1
    {
        // Used List to dynamically add 
        public List<string> company = new List<string>();
        public List<int> NoOfWorkingDays = new List<int>();
        public List<int> WagePerHour = new List<int>();
        public List<int> TotalWages = new List<int>();

        // used to store the length of the list
        public int noOfCompany = 0;

        public void AddEmployee(String company_name, int workingdays, int perhourwage)
        {

            this.company.Add(company_name);
            this.NoOfWorkingDays.Add(workingdays);
            this.WagePerHour.Add(perhourwage);
            this.TotalWages.Add(0);
            this.noOfCompany++;
        }

        // this function is used to retrive the Total wages stored by the ComputeAllWage and display the data
        public void ComputeEmployeeWage(string company)
        {
            for (int i = 0; i < noOfCompany; i++)
            {
                if (company == this.company[i])
                {
                    Console.WriteLine("Total wage for the Employee for the company {0} is  {1}", this.company[i], this.TotalWages[i]);
                }

            }

        }


        // THis function will computer wahes for the employee for all the company and store the total wages 
        public void ComputeAllWage()
        {

            Random random = new Random();

            for (int i = 0; i < noOfCompany; i++)

            {
                const int present = 1;
                const int absent = 0;
                int FullTime = 1;
                int TotalWages = 0;
                int WorkingDays = 0;


                while (WorkingDays < NoOfWorkingDays[i])
                {

                    int HourWorked = 0;
                    // use to know wether the employee is present or not
                    int check = random.Next(0, 2);

                    // used to know wether he worked for full time or half time
                    int check2 = random.Next(0, 2);


                    switch (check)
                    {

                        case absent:
                            break;

                        case present:
                            WorkingDays += 1;

                            // Full day
                            if (check2 == FullTime)
                            {
                                HourWorked = 12;
                            }
                            else
                            {
                                HourWorked = 8;
                            }
                            break;


                    }

                    TotalWages += HourWorked * WagePerHour[i];

                }

                this.TotalWages[i] = TotalWages;

               // Console.WriteLine("The Employee Worked for 20 days for the company {1} and his Total Wages is {0}", TotalWages, company[i]);


            }

        }



    }
}