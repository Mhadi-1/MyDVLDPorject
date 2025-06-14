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


### **Screenshots (Optional)**  
*(Add UI screenshots here, e.g.:)*  
- Application Form  
- Exam Scheduling Interface  
- License Issuance Dashboard  

---

### **Setup Guide**  
1. **Prerequisites**:  
   - .NET Framework 4.7+  
   - SQL Server 2019+ (LocalDB supported)  
2. **Database Setup**:  
   - Download [DVLD-Database.Bak]( https://github.com/Mhadi-1/Driving-Vehicle-License-System/tree/master/MyDVLDPorject/DataBaseBakUp)  DVLD-Database file.  
3. **Run the App**:  
   - Open `DVLD.sln` in Visual Studio → Build → Run.  
