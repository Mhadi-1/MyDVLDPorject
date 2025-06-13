

using DVLDClsLibraryDataAccesslyr;
using System.Data;

namespace ClsLibraryBussniselayr
{
    public class clsUser 
    {

        public int ID;
        public int PersonID;
        public string Name;
        public string password;
        public bool IsActive; 
        private enum enMode { AddNew , Update};
        enMode Mode; 
        public clsUser ()
        {
            ID = -1;
            PersonID = -1;
            Name = string.Empty;
            password = string.Empty;
            IsActive = false;
        }
        private clsUser(int userId, int personID, string userName, string password, bool isActive)
        {
            this.ID = userId;
            this.PersonID = personID;
            this.Name = userName;
            this.password = password;
            IsActive = isActive;
            Mode = enMode.Update;
        }
        private bool _AddNew()
        {
            this.ID = ClsUserDataAccess.AddNew(this.PersonID, this.Name, this.password, IsActive);
            return (this.ID > 0); 
        }
        private bool _Update()
        {
            return ClsUserDataAccess.Update(this.ID,this.Name, this.password, this.IsActive); 
        }
        public static bool IsAccess (string UserName)
        {
            return ClsUserDataAccess.CheckuserByUserName(UserName);
        }
        public static clsUser GetUser(string UserName)
        {
            int ID = -1, personID = -1;
            string password = "";
            bool IsAcctive = false; 
            if(ClsUserDataAccess.GetUser(ref ID , ref personID , ref UserName ,ref password ,ref IsAcctive))
            {
                return new clsUser(ID, personID, UserName, password, IsAcctive); 
            }
            return null;
        }
        public static string GetUserName(int UserID)
        {
            int personID = -1;
            string password = "" , UserName = "";
            bool IsAcctive = false;
            if (ClsUserDataAccess.GetUserByUserID(UserID, ref personID, ref UserName, ref password, ref IsAcctive))
            {
                return UserName;
            }
            return null;
        }

        public static clsUser GetUser(int personID)
        {
            string UserName = "", password = ""; 
            int UserID = -1;
           
            bool IsAcctive = false;
            if (ClsUserDataAccess.GetUserbyPersonID(ref UserID, ref personID, ref UserName, ref password, ref IsAcctive))
            {
                return new clsUser(UserID, personID, UserName, password, IsAcctive);
            }
            return null;
        }

        public static DataTable GetAllUsers()
        {
            return ClsUserDataAccess.GetAllUsers();
        }

        public static int FindUserIDByPersonID(int personID)
        {
            int UserID = ClsUserDataAccess.FindUserIDByPersonID(personID);
            return UserID; 
        }

        public static clsUser FindByUserID(int UserID)
        {
            int PersonID = -1;
            string UserName = "", Password = "";
            bool IsActive = false;

            bool IsFound = ClsUserDataAccess.GetUserInfoByUserID
                                (UserID, ref PersonID, ref UserName, ref Password, ref IsActive);

            if (IsFound)
                //we return new object of that User with the right data
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            else
                return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew: 
                 if(_AddNew())
                 {
                     return true; 
                 }
                return false;
                case enMode.Update:
                  return _Update();
            }
            return false; 
        }

    }
}
