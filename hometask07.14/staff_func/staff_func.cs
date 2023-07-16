using hometask07._14.data;

using hometask07._14.model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Npgsql.EntityFrameworkCore.PostgreSQL.Infrastructure.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace hometask07._14.DbFunctions
{
    public class AllDbFunctions
    {
        public void AddNewStaff(string name, string description)
        {
            using (UserDB contexts = new UserDB())
            {
                staff staff = new staff();

                staff.staffname = name;
                staff.staffdescription = description;

                contexts.Add(staff);
                contexts.SaveChanges();
            }
        }
        public void AddNewEmployee(string firstName, string lastName, string email, string password, int StaffId)
        {
            using (UserDB contexts = new UserDB())
            {
                employee emp = new employee();

                emp.firstname = firstName;
                emp.lastname = lastName;
                emp.email = email;
                emp.password = password;
                emp.staffid = StaffId;

                contexts.Add(emp);
                contexts.SaveChanges();
            }
        }
        public void DeleteEmployeeId(int id)
        {
            using (UserDB contexts = new UserDB())
            {
                employee emplyee = new employee();

                var result = contexts.employees.FirstOrDefault((x => x.staffid == id));

                contexts.employees.Remove(result);
                contexts.SaveChanges();
            }
        }
        public void GetAll()
        {
            using (UserDB contexts = new UserDB())
            {
                employee employee = new employee();

                var result = contexts.employees.ToList();


                foreach (employee i in result)
                {
                    Console.WriteLine($"{i.employeeid} {i.firstname} {i.lastname} {i.email} {i.password} {i.staffid}");
                }
            }
        }

        public void UpdateEmployee(int id, string firstName, string lastName, string email, string password, int staffID)
        {
            using (UserDB contexts = new UserDB())
            {
                employee employee = new employee();

                var result = contexts.employees.FirstOrDefault(x => x.employeeid == id);


                result.firstname = firstName;
                result.lastname = lastName;
                result.email = email;
                result.password = password;
                result.staffid = staffID;

                contexts.SaveChanges();
            }
        }
        public void GetAllStaffs()
        {
            using (UserDB contexts = new UserDB())
            {
                staff stafs = new staff();

                var result = contexts.staffs.ToList();

                foreach (var i in result)
                {
                    Console.WriteLine($"{i.staffname}\n{i.staffdescription}");
                }
            }
        }
    }
}