# User Registration System

An ASP.NET Core Razor Pages application developed to demonstrate user registration and validation using Data Annotations, server-side validation, and client-side validation.

---

# Overview

This project demonstrates:

- Razor Pages architecture
- User registration form handling
- Data Annotation validations
- Server-side validation
- Client-side validation
- Validation summary and error messages
- Password confirmation validation

---

# Features

- User registration form
- Username validation
- Email validation
- Password length validation
- Confirm password matching validation
- Validation error messages
- Validation summary display
- Client-side validation support
- Success message after registration

---

# Technologies Used

- ASP.NET Core Razor Pages
- C#
- HTML
- CSS
- .NET 10.0

---

# Project Structure

```text
UserRegistrationSystem
│
├── Models
│   └── UserRegistration.cs
│
├── Pages
│   ├── Index.cshtml
│   ├── Index.cshtml.cs
│   └── Shared
│       └── _ValidationScriptsPartial.cshtml
│
├── wwwroot
├── Program.cs
└── appsettings.json
```

---

# User Stories Implemented

## User Story 1: Basic Validation with Data Annotations

Implemented validation for:

- Username
- Email
- Password

Used Data Annotations:

- Required
- EmailAddress
- StringLength

---

## User Story 2: Custom Validation

Implemented Confirm Password validation using:

- Compare attribute

Ensures:

- Password and Confirm Password must match

---

## User Story 3: Display Validation Errors

Implemented:

- Individual validation messages
- Validation summary

Used:

```html
<span asp-validation-for=""></span>
```

and

```html
<div asp-validation-summary="All"></div>
```

---

## User Story 4: Client-Side Validation

Enabled client-side validation using:

```html
<partial name="_ValidationScriptsPartial" />
```

This provides:

- Instant browser validation
- Validation before form submission

---

# Validation Features

The application validates:

- Required fields
- Valid email format
- Password length constraints
- Password confirmation matching

Validation is performed on both:

- Client-side
- Server-side

---

# How to Run the Project

## Prerequisites

- Visual Studio 2022 or later
- .NET 10.0 SDK

---

## Steps

1. Clone the repository

```bash
git clone <repository-url>
```

2. Open the project in Visual Studio

3. Restore NuGet packages

4. Run the application using:

```bash
Ctrl + F5
```

5. Open the browser and access the application

---

# Expected Output

The application displays:

- Username field
- Email field
- Password field
- Confirm Password field
- Validation messages
- Validation summary
- Registration success message

---

# Learning Outcomes

This project demonstrates:

- Razor Pages development
- Data Annotations in ASP.NET Core
- Client-side validation
- Server-side validation
- Password comparison validation

