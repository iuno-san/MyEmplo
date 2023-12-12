# <a href="#"><img width="40" height="40" src="https://raw.githubusercontent.com/iuno-san/MyEmplo/master/MyEmplo/wwwroot/img/icons/Logo.png" /></a> MyEmplo - employee management system
<a href="#"><img width="1000" src="https://raw.githubusercontent.com/iuno-san/MyEmplo/master/MyEmplo/wwwroot/img/site/maain-site.png" /></a>

# 🍂 About
MyEmplo is a modern web application built on the ASP.NET Core MVC framework, designed for efficient employee data management within a company. The application stands out not only for its aesthetically pleasing and responsive interface but also for its robust security foundations and advanced clean architecture based on SOLID principles.<br><br>

## 🔒 Security:
- The use of the *Identity* package ensures a secure login system and account management, guaranteeing the protection of user data.<br>

## 📱 Responsiveness and Accessibility:
- The application is optimized for responsiveness, allowing seamless operation on various devices.<br>

## ⚡️ Intuitive Interface:
- The user interface is designed for simplicity, contributing to an intuitive user experience without the need for extensive training.<br>

## 🧑‍💼 Employee Management:
- The application enables efficient addition, editing, and removal of employee data, streamlining the personnel management process.<br>

## 🌱 Clean Architecture:
- The application is developed based on clean architecture, indicating well-organized code that is easy to maintain.<br>

## ⭐️ SOLID Principles:
- The application adheres to *SOLID* principles, demonstrating a professional approach to programming, resulting in flexibility and ease of extending functionality.<br><br><br>

# 🛠️What I did

- Created a comprehensive application using modern technologies.
- Implemented a secure login system and account management using *Identity*.
- Designed a user interface that is not only aesthetically pleasing but also intuitive.
- Applied clean architecture principles for modular and scalable code.
- Implemented features for adding, editing, and removing employees, aligning with the main purpose of the application.
- Utilized *SOLID* principles, showcasing a professional programming approach.<br><br><br>

# 🍃What I Learned 

- Effectively applied *ASP.NET Core MVC* technologies.
- Implemented a secure login system and account management.
- Designed a responsive user interface.
- Developed an application adhering to clean architecture principles and *SOLID* patterns.
- Efficiently managed employee data in a business application.<br><br><br>

# 🔥Application Structure
```
|-- MyEmplo.Application
|   |-- ApplicationUser
|   |   |-- CurrentUser.cs
|   |   |-- UserContext.cs
|   |
|   |-- Extensions
|   |   |-- ServiceCollectionExtensions.cs
|   |
|   |-- Mappings
|   |   |-- MyEmploMappingProfile.cs
|   |
|   |-- Commands
|   |   |-- CreateMyEmplo
|   |   |   |-- ...
|   |   |
|   |   |-- EditMyEmplo
|   |       |-- ...
|   |
|   |-- Queries
|       |-- GetAllMyEmplo
|       |   |-- ...
|       |
|       |-- GetMyEmploByEncodedName
|           |-- ...
|
|-- MyEmplo.Domain
|   |-- Entities
|   |   |-- MyEmplo.cs
|   |   |-- MyEmploService.cs
|   |
|   |-- Interfaces
|       |-- IMyEmploRepository.cs
|       |-- IMyEmploServiceRepository.cs
|
|-- MyEmplo.Infrastructure
|   |-- Extensions
|   |   |-- ServiceCollectionExtension.cs
|   |
|   |-- Migrations
|   |   |-- ...
|   |
|   |-- Persistance
|   |   |-- MyEmploDbContext.cs
|   |
|   |-- Repositories
|       |-- MyEmploRepository.cs
|       |-- MyEmploServiceRepository.cs
|   
|-- MyEmplo.MVC
|   |-- Controllers
|   |   |-- HomeController.cs
|   |   |-- MyEmploController.cs
|   |
|   |-- Models
|   |   |-- ErrorViewModel.cs
|   |   |-- Notification.cs
|   |
|   |-- Views
|   |   |-- Home
|   |   |   |-- ...
|   |   |
|   |   |-- MyEmplo
|   |       |-- ...
|   |
|   |-- wwwroot
|       |-- ...
|
|-- appsettings.json
|-- Program.cs
|-- ...

```
<br><br>

# 🤖Technologies used
## MyEmplo.MVC (Presentation Layer)
```
- Dependencies:
  - Microsoft.AspNetCore.Components.QuickGrid.EntityFrameworkAdapter v8.0.0
  - Microsoft.AspNetCore.Identity.EntityFrameworkCore v8.0.0
  - Microsoft.AspNetCore.Identity.UI v8.0.0
  - Microsoft.EntityFrameworkCore v8.0.0
  - Microsoft.EntityFrameworkCore.SqlServer v8.0.0
  - Microsoft.EntityFrameworkCore.Tools v8.0.0
  - Microsoft.VisualStudio.Web.CodeGeneration.Design v8.0.0
- Project References:
  - MyEmplo.Application
  - MyEmplo.Infrastructure
```
### MyEmplo.Application (Application Layer)
```
- Dependencies:
  - AutoMapper v12.0.1
  - AutoMapper.Extensions.Microsoft.DependencyInjection v12.0.1
  - FluentValidation.AspNetCore v11.3.0
  - MediatR.Extensions.Microsoft.DependencyInjection v11.1.0
  - Microsoft.Extensions.DependencyInjection.Abstractions v8.0.0
- Project References:
  - MyEmplo.Domain
```

## MyEmplo.Domain (Domain Layer)
```
- Dependencies:
  - Microsoft.Extensions.Identity.Stores v8.0.0
```

## MyEmplo.Infrastructure (Infrastructure Layer)
```
- Dependencies:
  - Microsoft.AspNetCore.Identity.EntityFrameworkCore v8.0.0
  - Microsoft.AspNetCore.Identity.UI v8.0.0
  - Microsoft.EntityFrameworkCore v8.0.0
  - Microsoft.EntityFrameworkCore.SqlServer v8.0.0
  - Microsoft.EntityFrameworkCore.Tools v8.0.0
- Project References:
  - MyEmplo.Application
```

<br><br><br>

# 🌌Gallery of MyEmplo
<a href="#"><img width="1000" src="https://raw.githubusercontent.com/iuno-san/MyEmplo/master/MyEmplo/wwwroot/img/site/details-site.png" /></a>
<a href="#"><img width="1000" src="https://raw.githubusercontent.com/iuno-san/MyEmplo/master/MyEmplo/wwwroot/img/site/servicee-site.png" /></a>
<a href="#"><img width="1000" src="https://raw.githubusercontent.com/iuno-san/MyEmplo/master/MyEmplo/wwwroot/img/site/faqq-site.png" /></a>
<a href="#"><img width="1000" src="https://raw.githubusercontent.com/iuno-san/MyEmplo/master/MyEmplo/wwwroot/img/site/index-site.png" /></a>
<a href="#"><img width="1000" src="https://raw.githubusercontent.com/iuno-san/MyEmplo/master/MyEmplo/wwwroot/img/site/create-site.png" /></a>
<a href="#"><img width="1000" src="https://raw.githubusercontent.com/iuno-san/MyEmplo/master/MyEmplo/wwwroot/img/site/edit-site.png" /></a>
<a href="#"><img width="1000" src="https://raw.githubusercontent.com/iuno-san/MyEmplo/master/MyEmplo/wwwroot/img/site/search-site.png" /></a>
<a href="#"><img width="1000" src="https://raw.githubusercontent.com/iuno-san/MyEmplo/master/MyEmplo/wwwroot/img/site/contact-site.png" /></a>
<a href="#"><img width="1000" src="https://raw.githubusercontent.com/iuno-san/MyEmplo/master/MyEmplo/wwwroot/img/site/account-site.png" /></a>
<a href="#"><img width="1000" src="https://raw.githubusercontent.com/iuno-san/MyEmplo/master/MyEmplo/wwwroot/img/site/login-site.png" /></a>
<a href="#"><img width="1000" src="https://raw.githubusercontent.com/iuno-san/MyEmplo/master/MyEmplo/wwwroot/img/site/register-site.png" /></a><br><br>

## 🌻 Feedback

If you have any feedback, please reach out to us at ignacysan27@gmail.com
