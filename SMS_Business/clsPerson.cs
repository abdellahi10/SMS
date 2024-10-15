using SMS_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Business
{
    public class clsPerson
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode = enMode.AddNew;

        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public short Gendor { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ImagePath { get; set; }

        public clsPerson()
        {
            this.PersonID = -1;
            this.FirstName = string.Empty;
            this.LastName = string.Empty;
            this.Gendor = -1;
            this.Phone = string.Empty;
            this.Email = string.Empty;
            this.ImagePath = string.Empty;

            _Mode = enMode.AddNew;
        }

        private clsPerson(int PersonID, string FirstName, string LastName,
            short Gendor, string Phone, string Email, string ImagePath)
        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Gendor = Gendor;
            this.Phone = Phone;
            this.Email = Email;
            this.ImagePath = ImagePath;

            _Mode = enMode.Update;
        }

        public static clsPerson GetPersonInfoByID(int PersonID)
        {
            string FirstName = string.Empty;
            string LastName = string.Empty;
            string Phone = string.Empty;
            string Email = string.Empty;
            string ImagePath = string.Empty;

            short Gendor = -1;


            bool IsFound = clsPersonData.GetPersonInfoByID(PersonID, ref FirstName, ref LastName, ref Gendor, ref Phone, ref Email, ref ImagePath);

            if(IsFound)
            {
                return new clsPerson(PersonID, FirstName, LastName, Gendor, Phone, Email, ImagePath);
            }
            else
            return null;
        }

        public static clsPerson GetPersonInfoByFirstName(string FirstName)
        {
            int PersonID = -1;
            string LastName = string.Empty;
            string Phone = string.Empty;
            string Email = string.Empty;
            string ImagePath = string.Empty;

            short Gendor = -1;

            bool IsFound = clsPersonData.GetPersonInfoByFirstName(FirstName, ref PersonID, ref LastName, ref Gendor, ref Phone, ref Email, ref ImagePath);

            return IsFound ? new clsPerson(PersonID, FirstName, LastName, Gendor, Phone, Email, ImagePath) : null;
        }

        public static clsPerson GetPersonInfoByLastName(string LastName)
        {
            int PersonID = -1;
            string FirstName = string.Empty;
            string Phone = string.Empty;
            string Email = string.Empty;
            string ImagePath = string.Empty;

            short Gendor = -1;

            bool IsFound = clsPersonData.GetPersonInfoByLastName(LastName, ref PersonID, ref FirstName, ref Gendor, ref Phone, ref Email, ref ImagePath);

            return IsFound ? new clsPerson(PersonID, FirstName, LastName, Gendor, Phone, Email, ImagePath) : null;
        }

        private bool _AddNewPerson()
        {
            this.PersonID = clsPersonData.AddNewPerson(this.FirstName.Trim(), this.LastName.Trim(), this.Gendor, this.Phone.Trim(),
                this.Email.Trim(), this.ImagePath.Trim());

            return (this.PersonID != -1);
        }

        private bool UpdatePerson()
        {
            return clsPersonData.UpdatePerson(this.PersonID, this.FirstName.Trim(), this.LastName.Trim(), this.Gendor,
                this.Phone.Trim(), this.Email.Trim(), this.ImagePath.Trim());
        }

        public static DataTable GetAllPeople()
        {
           return clsPersonData.GetAllPeople();
        }

        public static bool DeletePerson(int PersonID)
        {
            return clsPersonData.DeletePerson(PersonID);
        }

        public static bool IsPersonExist(int PersonID)
        {
          return  clsPersonData.IsPersonExist(PersonID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                   if(_AddNewPerson())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false; 
                    }

                case enMode.Update:
                    return UpdatePerson();

            }

            return false;


        }


    }

}


