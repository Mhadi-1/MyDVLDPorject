
using System.Data;
using System;
using DVLDClsLibraryDataAccesslyr; 
namespace ClsLibraryBussniselayr
{
    public class clsPerson : clsCountries
    {
        private struct _PersonInfo
        {
            public string
            nationalNo, firstName,
            secondName, thirdName,
            lastName, address,
            phone, email, ImagePath;
            public  int nationalityCountryID , personID , gendor;
            public DateTime dateOfBirth; 
        }
        private static _PersonInfo _Info; 
        private enum enMode { AddNew , Update}
        private enMode Mode ; 

        public int ID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Gendor { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string CountryName { get; set; }
        public string ImagePath { get; set; }
        public int nationalityCountryID;
        public string FullName
        {
            get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; }

        }

        private bool _AddNew()
        {
            this.ID =  clsPepoleDataAccess.AddNew(this.NationalNo , this.FirstName , this.SecondName , 
                this.ThirdName , this.LastName , this.DateOfBirth , this.Gendor , this.Address , 
                this.Phone , this.Email , this.nationalityCountryID , this.ImagePath ) ;
            return this.ID > 0; 
        }
        private bool _Update()
        {
            return clsPepoleDataAccess.Update(this.ID , this.NationalNo, this.FirstName, this.SecondName,
                this.ThirdName, this.LastName, this.DateOfBirth, this.Gendor, this.Address,
                this.Phone, this.Email, this.nationalityCountryID, this.ImagePath); 
        }
        public clsPerson()
        {
            ID = 0;
            NationalNo = string.Empty;
            FirstName = string.Empty;
            SecondName = string.Empty;
            ThirdName = string.Empty;
            LastName = string.Empty;
            DateOfBirth = DateTime.Now;
            Gendor = -1; 
            Address = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
            CountryName = "";
            ImagePath = string.Empty;
            Mode = enMode.AddNew;
        }

        private clsPerson(int personID, string nationalNo, string firstName,
            string secondName, string thirdName,
            string lastName, DateTime dateOfBirth,
            int gendor, string address, string phone,
            string email, int nationalityCountryID, string imagePath)
        {
            ID = personID;
            NationalNo = nationalNo;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Gendor = gendor ;
            Address = address;
            Phone = phone;
            Email = email;
            CountryName = clsCountries.GetCountryName(nationalityCountryID);
            ImagePath = imagePath;
            Mode = enMode.Update;
        }

        public void Clear()
        {
            ID = 0;
            NationalNo = string.Empty;
            FirstName = string.Empty;
            SecondName = string.Empty;
            ThirdName = string.Empty;
            LastName = string.Empty;
            DateOfBirth = DateTime.Now;
            Gendor = -1;
            Address = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
            CountryName = "";
            ImagePath = string.Empty;
            Mode = enMode.AddNew;
        }
        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:

                    if (_AddNew())
                    {
                        Mode = enMode.AddNew; 
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return _Update();
            }
            return false; 
        }
        public static DataTable GetAllPeople()
        {
            return clsPepoleDataAccess.GetAllPepole(); 
        }
        public static bool IsNationalNoExit(string NationalNo)
        {

           return clsPepoleDataAccess.IsExitNationNo(NationalNo); 

        }

        public static clsPerson FindByID(int ID)
        {
            _Info.personID = ID; 

            if (clsPepoleDataAccess.FindPerson(ref _Info.personID , ref _Info.nationalNo ,  ref _Info.firstName , ref _Info.secondName , 
                ref _Info.thirdName , ref _Info.lastName , ref _Info.dateOfBirth , ref _Info.gendor , ref _Info.address ,
                ref _Info.phone , ref _Info.email , ref _Info.nationalityCountryID , ref _Info.ImagePath))
            {

                return new clsPerson(_Info.personID, _Info.nationalNo, _Info.firstName, _Info.secondName, _Info.thirdName, _Info.lastName,
                     _Info.dateOfBirth, _Info.gendor, _Info.address, _Info.phone, _Info.email, _Info.nationalityCountryID,
                     _Info.ImagePath); 
            }
            return null;
        }
        public static clsPerson FindByFirsName(string FristName)
        {
            _Info.firstName = FristName;
            if (clsPepoleDataAccess.FindByFirstName(ref _Info.personID, ref _Info.nationalNo, ref _Info.firstName, ref _Info.secondName,
                 ref _Info.thirdName, ref _Info.lastName, ref _Info.dateOfBirth, ref _Info.gendor, ref _Info.address,
                 ref _Info.phone, ref _Info.email, ref _Info.nationalityCountryID, ref _Info.ImagePath))
            {

                return new clsPerson(_Info.personID, _Info.nationalNo, _Info.firstName, _Info.secondName, _Info.thirdName, _Info.lastName,
                     _Info.dateOfBirth, _Info.gendor, _Info.address, _Info.phone, _Info.email, _Info.nationalityCountryID,
                     _Info.ImagePath);
            }
            return new clsPerson();
        }
        public static bool Delete(int PersonID)
        {
            if(!clsPepoleDataAccess.Delete(PersonID))
            {
                return false; 
            }
                return true; 
        }
        public static clsPerson FindByNationalNo(string NationalNo)
        {
            _Info.nationalNo = NationalNo; 
            if (clsPepoleDataAccess.FindNationalNo(ref _Info.personID , ref _Info.nationalNo , ref _Info.firstName , ref _Info.secondName ,
               ref _Info.thirdName , ref _Info.lastName , ref _Info.dateOfBirth , ref _Info.gendor , ref _Info.address , ref _Info.phone 
                , ref _Info.email , ref _Info.nationalityCountryID , ref _Info.ImagePath))
            {

                return new clsPerson(_Info.personID, _Info.nationalNo, _Info.firstName, _Info.secondName, _Info.thirdName, _Info.lastName,
                    _Info.dateOfBirth, _Info.gendor, _Info.address, _Info.phone, _Info.email, _Info.nationalityCountryID,
                    _Info.ImagePath);
            }
            return new clsPerson(); 
        }
        

    }
}
