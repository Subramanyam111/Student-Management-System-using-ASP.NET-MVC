# 🎓 Student Management System using ASP.NET MVC

![.NET Core](https://img.shields.io/badge/.NET%20Core-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![ASP.NET MVC](https://img.shields.io/badge/ASP.NET%20MVC-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Bootstrap](https://img.shields.io/badge/Bootstrap-563D7C?style=for-the-badge&logo=bootstrap&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)
![Status](https://img.shields.io/badge/Status-Completed-success?style=for-the-badge)

> **A centralized, secure digital platform for managing student records, featuring a premium Glassmorphism UI and role-based security.**

---

## 📖 Project Overview
The **Student Management System** is a full-stack web application developed to modernize the handling of student data in educational institutions. Moving away from manual, error-prone record-keeping, this system offers a **secure, role-based environment** for Administrators and Users.

**What makes this project unique?**
Unlike standard CRUD applications, this project focuses heavily on **User Experience (UX)**. It implements a custom **Glassmorphism Design System**—utilizing translucency, blurs, and vibrant backgrounds to create a modern, app-like feel on the web.

## ✨ Key Features & Highlights
### 🎨 UI/UX Design
- **Glassmorphism Interface**: Custom CSS implementing blur filters, semi-transparent cards, and dynamic gradients.
- **Responsive Layout**: Built with Bootstrap 5 and custom media queries to work seamlessly on Mobile, Tablet, and Desktop.
- **Visual Feedback**: Interactive hover effects, smooth transitions, and intuitive navigation.

### 🔐 Security & Architecture
- **Role-Based Access Control (RBAC)**:
  - **🛡️ Admin Panel**: Complete control over student records (Create, Edit, Delete) and user management.
  - **👤 User Panel**: Restricted access tailored for standard users.
- **Session Management**: Secure session handling for persisting user states (Login/Logout).
- **Architecture**: Follows the **MVC (Model-View-Controller)** pattern for clean code separation.

### ⚙️ Core Functionality
- **CRUD Operations**: Full lifecycle management of student data.
- **Search System**: Efficient ID-based search for quick record retrieval.
- **Data Integrity**: Server-side validation using Data Annotations to prevent invalid entries.

---

## 🛠️ Tech Stack
| Component | Technology |
| :--- | :--- |
| **Framework** | ASP.NET Core MVC (C#) |
| **Database** | Microsoft SQL Server |
| **ORM** | Entity Framework Core (Code-First) |
| **Frontend** | HTML5, CSS3, Bootstrap 5 |
| **Tools** | Visual Studio 2026, Git |

---

## 🏗️ System Architecture
The application is structured around the **MVC Pattern**, ensuring scalability and maintainability.

### Folder Structure
```bash
EntityAspMvcFirst/
├── 📂 Controllers
│   ├── AdminController.cs    # Admin Auth & Logic
│   ├── HomeController.cs     # Student Management (CRUD)
│   └── LoginController.cs    # User Auth & Logic
├── 📂 Models
│   ├── Admins.cs             # Admin Schema
│   ├── LoginUser.cs          # User Schema
│   └── Student.cs            # Core Student Schema
├── 📂 Views
│   ├── 📂 Shared             # Layouts (_Layout.cshtml)
│   ├── 📂 Admin              # Admin Specific Views
│   └── ...
└── 📂 wwwroot                # Static Assets (CSS, JS, Images)
```

---

## 🚀 How to Run Locally

### 1. Prerequisites
- [.NET 10.0 SDK](https://dotnet.microsoft.com/download) (or compatible version)
- SQL Server (LocalDB or Express)

### 2. Setup
1. **Clone the repo**:
   ```bash
   git clone <your-repo-url>
   ```
2. **Configure Database**:
   Update `appsettings.json` with your connection string:
   ```json
   "ConnectionStrings": {
     "constr": "Server=YOUR_SERVER;Database=Subbudb;Trusted_Connection=True;TrustServerCertificate=True"
   }
   ```
3. **Apply Migrations**:
   ```bash
   dotnet ef database update
   ```
4. **Run the App**:
   ```bash
   dotnet run
   ```
   *Navigate to `https://localhost:7152` (check console for port).*

---

## 🔗 API Routes
The application exposes the following MVC routes:

| Feature | Method | Route | Description |
| :--- | :--- | :--- | :--- |
| **Auth** | `GET/POST` | `/Login/LoginUser` | User Login |
| **Auth** | `GET/POST` | `/Admin/AdminLogin` | Admin Login |
| **Student** | `GET` | `/Home/list` | View All Students |
| **Student** | `POST` | `/Home/Create` | Register New Student |
| **Student** | `POST` | `/Home/Edit` | Update Student Record |

---

## 📬 Contact & Connect
If you found this project interesting or have any feedback, feel free to reach out!

- **LinkedIn**: [Subramanyam Sirisala](https://www.linkedin.com/in/subramanyam-sirisala-3860b4219/)
- **Email**: sirisalasubramanyam@gmail.com
- **GitHub**: [Subramanyam Sirisala](https://github.com/Subramanyam111/Student-Management-System-using-ASP.NET-MVC.git)

---
*© 2025 Student Management System. Built for educational purposes.*



<img width="1920" height="1014" alt="Screenshot 2025-12-12 095425" src="https://github.com/user-attachments/assets/5ced2c9b-48c2-44cd-a426-6a42a607439f" />
<img width="1920" height="1014" alt="Screenshot 2025-12-12 095442" src="https://github.com/user-attachments/assets/245062c0-f18b-47e3-b2ec-ded432d5021c" />
<img width="1920" height="1014" alt="Screenshot 2025-12-12 095456" src="https://github.com/user-attachments/assets/55491a4a-c5c0-4b43-8d02-bc6c8822812b" />
<img width="1920" height="1014" alt="Screenshot 2025-12-12 095524" src="https://github.com/user-attachments/assets/08987445-ef24-4a37-9af1-19caea090295" />
<img width="1920" height="1014" alt="Screenshot 2025-12-12 095541" src="https://github.com/user-attachments/assets/6d4ab90b-a979-44ef-bbc1-0500a1d79396" />
<img width="1920" height="1014" alt="Screenshot 2025-12-12 095607" src="https://github.com/user-attachments/assets/a8a25e74-d689-4edb-89ab-d95df2e11838" />
<img width="1920" height="1014" alt="Screenshot 2025-12-12 095623" src="https://github.com/user-attachments/assets/13521bbe-fc5d-44fb-86ba-f3192796a70d" />
<img width="1920" height="1014" alt="Screenshot 2025-12-12 095642" src="https://github.com/user-attachments/assets/49a79130-b62f-4304-8249-8eb925fca10c" />
<img width="1920" height="1014" alt="Screenshot 2025-12-12 095658" src="https://github.com/user-attachments/assets/7d47ad08-2e08-48a2-93c5-f852634fef71" />
<img width="1920" height="1014" alt="Screenshot 2025-12-12 095714" src="https://github.com/user-attachments/assets/f859d41f-3d97-4404-8ef8-44978e42a69d" />












