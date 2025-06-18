# 🎓 Institute Management System

A secure and responsive **ASP.NET Core MVC** application designed for managing user authentication and access for educational institutions.

This project demonstrates:

- 🔐 Cookie-based user login system
- 🌗 Theme toggle with light/dark mode
- 👨‍🏫 Dashboard access restricted to logged-in users
- 💻 Clean, modern UI built with Razor Pages & CSS

---

## 🔧 Features

- ASP.NET Core MVC (.NET 8+)
- Razor Views + Model Binding
- Secure authentication using ASP.NET Core Cookie Authentication
- Session-based login and route protection
- Theme toggle: dark/light mode UI
- Fully responsive design

---

## 📦 Requirements

- [.NET 8 or 9 SDK](https://dotnet.microsoft.com/en-us/download)
- Visual Studio 2022+ or Visual Studio Code
- (Optional) SQL Server Express / LocalDB (for future DB integration)

---

## 🚀 Getting Started

### 🛠 Run Locally

1. **Clone the Repository**
   ```bash
   git clone https://github.com/ysd98/InstituteManagementSystem.git
   cd InstituteManagementSystem
2. Restore Dependencies
    ```bash
    dotnet restore
3. Run the App
    ```bash
    dotnet run
4. Open in your browser:
    ```bash
    http://localhost:xxxx

## 🔐 Default Login
Use the following hardcoded credentials to log in:

```makefile
Username: admin  
Password: admin123
```

🔒 Access to the /Home route is restricted unless you're logged in.

---
## 🧠 How Authentication Works
- ✅ Login form posts to LoginController

- ✅ On successful login, cookie is issued via SignInAsync

- 🔒 [Authorize] attribute protects the HomeController

- ❌ Trying to visit /Home without login redirects you to /Login

---

## 📁 Project Structure
```pgsql
InstituteManagementSystem/
├── Controllers/
│   ├── LoginController.cs
│   └── HomeController.cs
├── Models/
│   └── LoginModel.cs
├── Views/
│   ├── Login/Index.cshtml
│   └── Home/Index.cshtml
├── wwwroot/
│   └── css/login.css
├── Program.cs
├── Startup.cs (if applicable)
├── appsettings.json
└── README.md
```
---

## ✅ Project Features Checklist

- [x] Login system using cookie authentication  
- [x] Light/dark theme toggle  
- [ ] 🗃 Add SQL Server database + EF Core integration  
- [ ] 📋 Add student/course management modules  
- [ ] 🔐 Role-based access (admin, student, teacher)  
- [ ] 📧 Email-based password recovery  
- [ ] 📊 Admin dashboard with stats/charts  
- [ ] 🧪 Add unit tests & validation  

---
## 🧪 Sample Code Snippets

### 🔒 Protecting Routes

```csharp
[Authorize]
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
```
### ✅ Checking Login in Controller

```chashrp
if (model.Username == "admin" && model.Password == "admin123")
{
    var claims = new List<Claim>
    {
        new Claim(ClaimTypes.Name, model.Username)
    };

    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
    var principal = new ClaimsPrincipal(identity);
    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

    return RedirectToAction("Index", "Home");
}
```
---

# 🙌 Contributing
Got ideas or improvements? Feel free to fork and submit a pull request.
Make sure to open an issue before making major changes.