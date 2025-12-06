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

- **LinkedIn**: [Your Name](https://www.linkedin.com/in/yourprofile)
- **Email**: your.email@example.com
- **GitHub**: [YourProfile](https://github.com/yourusername)

---
*© 2025 Student Management System. Built for educational purposes.*
