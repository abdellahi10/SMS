using SMS_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Business
{
    public class ClsUser
    {
        enum enMode { Addnew = 0, Update = 1 }
        enMode _Mode = enMode.Addnew;


        public int UserID { set; get; }
        public int PersonID { set; get; }
        public string UserName { set; get; }
        public byte UserRole { set; get; }
        public string Password { set; get; }
        public bool IsActive { set; get; }

        public clsPerson PersonInfo;
        public ClsUser()
        {
            UserID = -1;
            PersonID = -1;
            UserName = string.Empty;
            UserRole = 0;
            Password = string.Empty;
            IsActive = false;

            _Mode = enMode.Addnew;
        }

        private ClsUser(int UserID, int PersonID, string UserName, byte UserRole, string Password, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.UserRole = UserRole;
            this.Password = Password;
            this.IsActive = IsActive;
            PersonInfo = clsPerson.GetPersonInfoByID(PersonID);

            _Mode = enMode.Update;
        }

        public static ClsUser GetUserInfoByID(int UserID)
        {
          
            string UserName = "";
            string Password = "";
            int PersonID = -1;
            byte UserRole = 0;
            bool IsActive = false;

            bool IsFound = ClsUserData.GetUserInfoByID(UserID, ref PersonID, ref UserName, ref UserRole, ref Password, ref IsActive);

            if (IsFound)
                return new ClsUser(UserID, PersonID, UserName, UserRole, Password, IsActive);
            else
                return null;
        }

        public static ClsUser GetUserInfoByPersonID(int PersonID)
        {
            string UserName = "";
            string Password = "";
            int UserID = -1;
            byte UserRole = 0;
            bool IsActive = false;


            bool IsFound = ClsUserData.GetUserInfoByPersonID(PersonID, ref UserID, ref UserName, ref UserRole, ref Password, ref IsActive);

            if (IsFound)
                return new ClsUser(UserID, PersonID, UserName, UserRole, Password, IsActive);
            else
                return null;
        }

        public static ClsUser GetUserInfoByUserName(string UserName)
        {
            
            int PersonID = -1;
            int UserID = -1;
            byte UserRole = 0;
            bool IsActive = false;
            string Password = "";


            bool IsFound = ClsUserData.GetUserInfoByUserName(UserName, ref UserID, ref PersonID, ref UserRole, ref Password, ref IsActive);

            if (IsFound)
                return new ClsUser(UserID, PersonID, UserName, UserRole, Password, IsActive);
            else
                return null;
        }

        public static ClsUser FindByUsernameAndPassword(string UserName, string Password)
        {

            int PersonID = -1;
            int UserID = -1;
            byte UserRole = 0;
            bool IsActive = false;


            bool isFound = ClsUserData.GetUserInfoByUsernameAndPassword(ref UserID, ref PersonID, UserName, ref UserRole, Password, ref IsActive);

            return isFound ? new ClsUser(UserID, PersonID, UserName, UserRole, Password, IsActive) : null;
        }

        private bool _AddNewUser()
        {
            this.UserID = ClsUserData.AddNewUser(this.PersonID, this.UserName, this.UserRole, this.Password, this.IsActive);

            return (this.UserID != -1);
        }

        private bool _UpdateUser()
        {
            return ClsUserData.UpdateUser(this.UserID,
                this.PersonID, this.UserName, this.UserRole, this.Password, this.IsActive);
        }

        public static DataTable GetAllUsers()
        {
            return ClsUserData.GetAllUsers();
        }

        public static bool DeleteUser(int UserID)
        {
            return ClsUserData.DeleteUser(UserID);
        }

        public static bool IsUserExist(int UserID)
        {
            return ClsUserData.IsUserExist(UserID);
        }

        public static bool IsUserExist(string UserName)
        {
            return ClsUserData.IsUserExist(UserName);
        }

        public static bool IsPersonUser(int PersonID)
        {
            return ClsUserData.IsPersonUser(PersonID);
        }

        public static bool IsUserActive(int UserID)
        {
            return ClsUserData.IsUserActive(UserID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Addnew:
                    if (_AddNewUser())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return true;
                    }
                case enMode.Update:
                    return _UpdateUser();

            }

            return false;

        }

    }
}
