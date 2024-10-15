using Microsoft.Win32;
using SMS_Business;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.Global_Classes
{
    internal class clsGlobal
    {

        public static ClsUser CurrentUser;

        public static bool RememberUsernameAndPassword(string Username, string Password)
        {
            


            string key = "70345YY89UT234AV";


            try
            {
                // Define the path to the Registry where you want to save the data
                string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\SMS\LoginInfo";

                string valueName = "SMSLoginInfo";

                Password = ClsCrypto.SemetricEncrypt(Password, key);

                string valueData = Username + "#//#" + Password;

                Registry.SetValue(keyPath, valueName, valueData, RegistryValueKind.String);

                return true;
            }
            catch (Exception ex)
            {
                ClsUtil.Log("Application", ex.Message, EventLogEntryType.Error);
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }

        }

        public static bool GetStoredCredential(ref string Username, ref string Password)
        {
            

            string key = "70345YY89UT234AV";


            //this will get the stored username and password and will return true if found and false if not found.
            try
            {
                // Path for the SubKey that contains the credential.
                string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\SMS\LoginInfo";

                string valueName = "SMSLoginInfo";

                // Read the value From The Registry
                string Value = Registry.GetValue(keyPath, valueName, null) as string;

                if (Value != null)
                {
                    string[] result = Value.Split(new string[] { "#//#" }, StringSplitOptions.None);

                    Username = result[0];
                    Password = ClsCrypto.SemetricDecrypt(result[1], key);

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                ClsUtil.Log("Application", ex.Message, EventLogEntryType.Error);
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }








        }









    }
}
