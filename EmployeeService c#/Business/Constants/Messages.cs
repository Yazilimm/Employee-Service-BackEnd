using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string EmployeeAdded = "Employee Added Successfully";
        public static string EmployeeDeleted = "Employee Deleted Successfully";
        public static string EmployeeUpdated = "Employee Updated Successfully";
        public static string UserNotFound = "User Not Found";
        public static string PasswordError = "Wrong Password";
        public static string SuccessfulLogin = "Login Successful";
        public static string UserAlreadyExists = "User Already Exist";
        public static string UserRegistered = "Register Successful";
        public static string AccessTokenCreated = "Access Token Created";
    }
}
