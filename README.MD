
# 🎓 Institute Management System

A secure and responsive **ASP.NET Core MVC** application designed for managing users and access for educational institutions.

This project demonstrates:

- 🔐 Cookie-based user login system
- 📋 Full CRUD operations for Users
- 👨‍🏫 Dashboard access restricted to logged-in users
- 🌗 Theme toggle with light/dark mode (future scope)
- 💻 Clean, modern UI built with Razor Views + Bootstrap

---

## 🔧 Features

- ASP.NET Core MVC (.NET 8+)
- Razor Views + Model Binding
- Secure login via Cookie Authentication
- CRUD for users with EF Core & SQLite
- Session-based login and route protection
- Responsive Bootstrap layout

---

## 📦 Requirements

- [.NET 8 or 9 SDK](https://dotnet.microsoft.com/en-us/download)
- Visual Studio Code (Recommended)
- SQLite (default, no setup required)

---

## 🚀 Getting Started

### 🛠 Run Locally

1. **Clone the Repository**
   ```bash
   git clone https://github.com/ysd98/InstituteManagementSystem.git
   cd InstituteManagementSystem
   ```

2. **Restore Dependencies**
   ```bash
   dotnet restore
   ```

3. **Apply Migrations & Create DB**
   ```bash
   dotnet ef database update
   ```

4. **Run the App**
   ```bash
   dotnet run
   ```

5. Open in your browser:
   ```bash
   http://localhost:5199
   ```

## 🔐 Default Login
Use the following hardcoded credentials to log in:

```makefile
Username: admin  
Password: admin123
```

🔒 Access to the dashboard is restricted unless you're logged in.

---

## 🧠 How Authentication Works

- ✅ Login form posts to `LoginController`
- ✅ On successful login, cookie is issued via `SignInAsync`
- 🔒 `[Authorize]` attribute protects all secure routes
- ❌ Unauthorized users are redirected to `/Login`

---

## 📁 Project Structure

```text
InstituteManagementSystem/
├── Controllers/
│   ├── LoginController.cs
│   ├── DashboardController.cs
│   └── UserController.cs
├── Models/
│   └── User.cs
├── Views/
│   ├── Login/
│   ├── Dashboard/
│   └── User/ (Index, Create, Edit, Delete)
├── Data/
│   └── AppDbContext.cs
├── wwwroot/
│   └── css/site.css
├── Program.cs
├── appsettings.json
└── README.md
```

---

## ✅ Features Checklist

- [x] Login system using cookie authentication  
- [x] Full CRUD functionality with Entity Framework Core  
- [x] SQLite database integration  
- [x] Responsive layout with fixed header & footer  
- [ ] Theme toggle: dark/light mode (planned)  
- [ ] Role-based access (admin, student, teacher)  
- [ ] Email/password recovery (future)  
- [ ] Dashboard stats & analytics (future)  

---

## 🧪 Sample Code

### 🔒 Protecting Routes

```csharp
[Authorize]
public class DashboardController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
```

### ✅ Login Validation Logic

```csharp
if (model.Username == "admin" && model.Password == "admin123")
{
    var claims = new List<Claim>
    {
        new Claim(ClaimTypes.Name, model.Username)
    };

    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
    var principal = new ClaimsPrincipal(identity);
    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

    return RedirectToAction("Index", "Dashboard");
}
```

---

# 🙌 Contributing

Got suggestions or improvements? Fork the repo and create a pull request.
Open an issue before submitting large changes.
