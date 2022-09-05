using Batch1_DET_2022.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Batch1_DET_2022
{
    internal class DatabaseFirst
    {
        static void Main(string[] args)
        {
            //GetAllEmpDetails();
            // GetEmpDetailByID();
            //AddNewEmployee();
            //RemoveNewEmployee();
            //UpdateNewEmployee();
            //GetEmployeesSP();
            //SPWithoutPara();
            //SPWithPara();
         // SPRemoveEmpDetails();
            /*Console.ReadLine();*/
            CallStoredProcwithSQLParamater_insert();
        }

        //WITHOUT PARAMETER
        /*   private static void SPWithoutPara()
           {
               var ctx = new TrainingContext();
               var employee = ctx.Emps.FromSqlRaw($"GetAllEmpsDetails").ToList();

               foreach (var e in employee)
               {
                   Console.WriteLine(e.Ename);
               }
           }*/
        private static void CallStoredProcwithSQLParamater_insert()
        {
            var ctx = new TrainingContext();
            var param = new SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@empno",
                            SqlDbType =  System.Data.SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 9998
                        },
                        new SqlParameter() {
                            ParameterName = "@ename",
                            SqlDbType =  System.Data.
                            SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "LARA"},





                        new SqlParameter() {
                            ParameterName = "@job",
                            SqlDbType =  System.Data.
                            SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "EMPLOYEE"},




                         new SqlParameter() {
                            ParameterName = "@mgr",
                            SqlDbType =  System.Data.
                            SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 7839},

                         new SqlParameter() {
                            ParameterName = "@hiredate",
                            SqlDbType =  System.Data.
                            SqlDbType.DateTime,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = DateTime.Now},




                         new SqlParameter() {
                            ParameterName = "@sal",
                            SqlDbType =  System.Data.
                            SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 15000},


                         new SqlParameter() {
                            ParameterName = "@comm",
                            SqlDbType =  System.Data.
                            SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 1050},



                        new SqlParameter() {
                            ParameterName = "@deptno",
                            SqlDbType =  System.Data.
                            SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 30}
                      };



            try
            {
                var result = ctx.Database.ExecuteSqlRaw("InsertEmployee @empno, @ename, @job, @mgr, @hiredate, @sal, @comm, @deptno", param);
                Console.WriteLine("added");
            }
            catch (Exception ex)
            {
                throw;
            }
            Console.WriteLine("update successful");
        }
        //WITH PARAMETER
        private static void SPWithPara()
                {
                    var ctx = new TrainingContext();

                    var employee = ctx.Emps.FromSqlRaw("GetAllEmpsDetailsByEmpno @p0", 2979).ToList();

                    foreach (var e in employee)
                    {
                        Console.WriteLine(e.Ename);
                    }
                }

//DELETEDETAILS
        private static void SPRemoveEmpDetails()

        {

           var ctx = new TrainingContext();
           var Value = 8951;
           int employee = ctx.Database.ExecuteSqlRaw("DeleteEmpsDetailsByEmpno @p0", Value);
           Console.WriteLine($"No Of Rows Affected {employee}");

        }

        /*
                private static void UpdateNewEmployee()
                {
                    var ctx = new TrainingContext();
                    var employee = ctx.Emps.Where(e => e.Empno == 2979).SingleOrDefault();
                    try
                    {
                        Emp employee1 = new Emp();
                       // employee.Empno = 2979;
                        employee.Ename = "Raj";
                        ctx.Update(employee);
                        ctx.SaveChanges();
                        Console.WriteLine("Updated");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.InnerException.Message);
                    }
                }*/
        /*private static void AddNewEmployee()
        {
            var ctx = new TrainingContext();

            try
            {
                Emp employee = new Emp();
                employee.Empno = 2979;
                employee.Ename = "Sheela";
                employee.Sal = 1000;
                employee.Deptno = 30;
                employee.Job = "Trainer";
                ctx.Add(employee);
                ctx.SaveChanges();
                Console.WriteLine("New employee added");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }*/

        /*private static void RemoveNewEmployee()
        {
            var ctx = new TrainingContext();

            try
            {
                Emp employee = new Emp();
                employee.Empno = 2979;
                employee.Ename = "Sheela";
                employee.Sal = 1000;
                employee.Deptno = 30;
                employee.Job = "Trainer";
                ctx.Remove(employee);
                ctx.SaveChanges();
                Console.WriteLine("New employee Deleted");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }*/

        /*        private static void GetEmpDetailByID()
                {
                    var ctx = new TrainingContext();
                    var employee = ctx.Emps.Where(e=>e.Empno==7499).SingleOrDefault();
                    Console.WriteLine(employee.Ename + "  " + employee.Sal+"  "+ employee.Job);

                }*/
        /*        private static void GetAllEmpDetails()
                {
                    var ctx = new TrainingContext();
                    var emp = ctx.Emps;

                    foreach(var employee in emp)
                    {
                        Console.WriteLine(employee.Ename + " " + employee.Sal);
                    }

                }*/
    }
}
