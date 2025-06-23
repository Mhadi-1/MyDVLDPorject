# **DVLD (Driving Vehicle License System)**   🚗 
*A Windows Forms Desktop Application for Driver’s License Management*  

**DVLD** is a comprehensive **3-Tier desktop application** built on **.NET Framework** and **SQL Server**, designed to automate and streamline the end-to-end process of **driver’s license applications, testing, and issuance**. The system serves two primary user roles:  
- **Applicants**: Submit and track license applications, schedule exams, and pay fees.  
- **Administrators**: Manage licenses, approve/reject applications, and generate reports.  

Built with **WinForms (UI), C# (Business Logic), and ADO.NET (Data Access)**, DVLD ensures data integrity, security, and compliance with standard licensing workflows.  

---

### **Key Features**  

#### 📝 **License Application Services**  
- Apply for **new local/international driving licenses**.  
- **Renew expired licenses** or **replace** lost/damaged licenses.  
- **Release detained licenses** after legal clearance.  
- **Retake failed tests** (vision, written, or practical exams).  

#### 📋 **Exam Management**  
- Three-stage exam process:  
  1. **Vision Test**  
  2. **Written Test**  
  3. **Driving (Practical) Test**  
- **Fee payment required** before exam scheduling.  

#### 💰 **Payment System**  
- fee structure for each service:  
  - **New License**: $25 | **Renewal**: $120 | **Replacement**: $70  
  - **Exam Fees**: Vision ($10), Written ($10), Driving ($10).  

#### 👥 **User Roles & Workflow**  
- **Applicants**:  
  - Submit applications, upload information , and track status.  
  - View test schedules and results.  
- **Administrators**:  
  - Approve/reject applications.  
  - Issue licenses and manage detainments.    

#### 📊 **Reporting & Analytics**  
- License issuance statistics.  
- Exam pass/fail rates.  
- Financial summaries (fee collections).  

---

### **Technology Stack**  
| **Layer**         | **Technology**              |  
|--------------------|-----------------------------|  
| **Presentation**   | Windows Forms (.NET Framework) |  
| **Business Logic** | C#, OOP, Validation Layers  |  
| **Data Access**    | ADO.NET, Stored Procedures  |  
| **Database**       | SQL Server (Relational DB)  |  

---


### **Setup Guide**  
1. **Prerequisites**:  
   - .NET Framework 4.7+  
   - SQL Server 2019+ (LocalDB supported)  
2. **Database Setup**:  
   - Download [DVLD-Database.Bak](https://github.com/Mhadi-1/Driving-Vehicle-License-System/tree/master/MyDVLDPorject/Databasebackup)  DVLD-Database Backup file.  
   **Open SQL Server and Restore The File**      
   ![2025-06-15_03-18-54](https://github.com/user-attachments/assets/79d9e743-8daf-495a-9d0e-ae4dc28f5828)



3. **Run the App**:  
  
Extract this under a folder name it MyDVLDProject Solution.        
you will find 3 sub folders as flows:      
![2025-06-15_03-07-25](https://github.com/user-attachments/assets/98d5eb23-4007-4820-92f9-aa3b3a074444)      


the first one is for the presentation layer.  
the second one is for business layer.  
the third one is for DataAccess Layer.      
   

then open the MyDVLDProject folder you will find:      
         
![2025-06-15_03-08-07](https://github.com/user-attachments/assets/5a5b831f-4bb2-4536-8a16-fcd8320af68f)      

- Open `MyDVLDProject.sln` in Visual Studio → Build → Run.
- username: Mhadi10
- Password : 12345      
      
## Short Video      
      

https://github.com/user-attachments/assets/68c11d2a-afa6-4936-a128-01027f86ce04

## Full Video       
      

https://drive.google.com/file/d/12-x1IAGu269b4scAghLcqKM6GjwxiSlb


  
