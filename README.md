# Student Management System using ASP.NET MVC

> A centralized digital platform for managing student records efficiently.

## Project Description
The **Student Management System** is a robust web application designed to streamline the management of student data for educational institutions. Manual handling of student records is often slow, error-prone, and insecure. This system addresses these challenges by providing a secure, user-friendly interface for administrators and faculty staff to perform essential operations such as student registration, record updates, and data retrieval. Built with **ASP.NET Core MVC** and **Entity Framework Core**, it ensures data integrity and offers a responsive experience across devices.

## Key Features
- **CRUD Operations**: Create, Read, Update, and Delete student records seamlessly.
- **Search Functionality**: Quickly find student records by ID.
- **Responsive UI**: Optimized for various screen sizes using Bootstrap.
- **Data Validation**: robust server-side validation using Data Annotations to ensure data accuracy.
- **Database Integration**: Reliable data persistence using Microsoft SQL Server.
- **Department Management**: Organize students by their respective departments.

## Tech Stack
- **Frontend**: HTML5, CSS3, Bootstrap
- **Backend**: ASP.NET Core MVC (C#)
- **Database**: Microsoft SQL Server
- **ORM**: Entity Framework Core
- **Tools**: Visual Studio, Git, IIS Express

## System Architecture Overview
The application follows the **Model-View-Controller (MVC)** architectural pattern, ensuring a clean separation of concerns:
- **Model**: Represents the data and business logic (e.g., `Student` entity, `SubbudbContext`).
- **View**: Handles the presentation layer, rendering the user interface (Razor Views).
- **Controller**: Manages user input, interacts with the model, and selects the appropriate view (e.g., `HomeController`).

Data access is managed via **Entity Framework Core**, which communicates with the SQL Server database.

## Folder Structure Explanation
```
EntityAspMvcFirst/
├── Controllers/          # Handles incoming browser requests and application logic
│   └── HomeController.cs # Main controller for student operations
├── Models/               # Domain classes and database context
│   ├── Student.cs        # Student entity definition
│   └── SubbudbContext.cs # EF Core Database Context
├── Views/                # Razor views for UI rendering
│   ├── Home/             # Views corresponding to HomeController actions
│   └── Shared/           # Shared layouts and partial views
├── wwwroot/              # Static assets (CSS, JS, images)
├── appsettings.json      # Application configuration (Connection Strings)
└── Program.cs            # Application entry point and middleware configuration
```

## Installation & Setup Guide
1. **Prerequisites**:
   - [.NET SDK](https://dotnet.microsoft.com/download) (Compatible version)
   - [Visual Studio](https://visualstudio.microsoft.com/) or VS Code
   - [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

2. **Clone the Repository**:
   ```bash
   git clone <repository-url>
   cd EntityAspMvcFirst
   ```

3. **Restore Dependencies**:
   ```bash
   dotnet restore
   ```

## Environment Configuration
1. Open `appsettings.json`.
2. Update the connection string named `constr` to point to your local SQL Server instance:
   ```json
   "ConnectionStrings": {
     "constr": "Server=YOUR_SERVER_NAME;Database=Subbudb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True"
   }
   ```

## How to Run the Project
1. **Apply Migrations** (if applicable) or ensure the database exists:
   ```bash
   dotnet ef database update
   ```
2. **Run the Application**:
   ```bash
   dotnet run
   ```
   Or press `F5` in Visual Studio.
3. **Access the App**:
   Open your browser and navigate to `https://localhost:7152` (or the port specified in the console).

## Screenshots Section
*(Placeholder: Add screenshots of the Dashboard, Student List, and Edit forms here)*
- **Dashboard**: Overview of system options.
- **Student List**: Tabular view of all students.
- **Add/Edit Student**: Forms for managing student details.

## API Endpoints
The application uses standard MVC routes. Below are the key endpoints handled by `HomeController`:

| Method | Endpoint | Description |
| :--- | :--- | :--- |
| `GET` | `/` | Home page |
| `GET` | `/Home/list` | List all students |
| `GET` | `/Home/list/{id}` | Filter student by ID |
| `GET` | `/Home/Details/{id}` | View details of a specific student |
| `GET` | `/Home/Create` | Show student creation form |
| `POST` | `/Home/Create` | Submit new student data |
| `GET` | `/Home/Edit/{id}` | Show edit form for a student |
| `POST` | `/Home/Edit` | Submit updated student data |
| `GET` | `/Home/Delete/{id}` | Show delete confirmation |
| `POST` | `/Home/Delete` | Execute deletion of a student |

## Database Schema Overview
The primary entity is the **Student** table:

| Column Name | Data Type | Constraints | Description |
| :--- | :--- | :--- | :--- |
| `StudentId` | `INT` | PK, Identity | Unique identifier |
| `FullName` | `NVARCHAR` | Not Null | Student's full name |
| `Email` | `NVARCHAR` | Not Null | Contact email |
| `Age` | `INT` | Nullable | Student's age |
| `Gender` | `NVARCHAR` | Nullable | Gender of the student |
| `Department` | `NVARCHAR` | Nullable | Academic department |
| `DateOfAdmission` | `DATE` | Not Null | Admission date |

## Security Considerations
- **SQL Injection Protection**: Uses Entity Framework Core (parameterized queries) to prevent SQL injection.
- **Input Validation**: Server-side validation using Data Annotations ensures clean data entry.
- **CSRF Protection**: ASP.NET Core MVC automatically includes Anti-Forgery tokens for POST requests (ensure `<form>` tags use tag helpers).
- **Error Handling**: Custom error pages are configured for production environments.

## Performance Optimizations
- **Asynchronous Operations**: (Recommended) Convert controller actions to `async/await` for better scalability under load.
- **Database Indexing**: Ensure `StudentId` is indexed (default for PK) for fast lookups.
- **Asset Minification**: Static assets in `wwwroot` can be minified for faster load times.

## Known Limitations
- **Authentication**: Currently, the system is open and does not have login/role-based access control.
- **Search**: Search is currently limited to Student ID.
- **Pagination**: Large lists of students are not paginated.

## Future Enhancements / Roadmap
- [ ] Implement User Authentication & Authorization (Identity).
- [ ] Add Advanced Search (by Name, Department) and Filtering.
- [ ] Implement Pagination for the Student List.
- [ ] Add Student Profile Image Upload.
- [ ] Generate PDF Reports for Student Records.

## Contribution Guidelines
1. Fork the repository.
2. Create a new feature branch (`git checkout -b feature/AmazingFeature`).
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`).
4. Push to the branch (`git push origin feature/AmazingFeature`).
5. Open a Pull Request.

## License Section
Distributed under the MIT License. See `LICENSE` for more information.

## Author & Contact Information
**Project Author**
- **Email**: contact@example.com
- **GitHub**: [YourProfile](https://github.com/)

---
*Generated for the Student Management System Project.*
