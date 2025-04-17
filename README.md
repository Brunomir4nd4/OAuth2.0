# 🔐 OAuth 2.0 Authentication with Google in ASP.NET Core

![.NET Version](https://img.shields.io/badge/.NET-7.0-blueviolet)
![Google OAuth](https://img.shields.io/badge/OAuth-Google-red)
![Bootstrap](https://img.shields.io/badge/UI-Bootstrap%205-7952B3)

A complete implementation of Google OAuth 2.0 authentication in ASP.NET Core with protected routes, user profile display, and privacy policy.

## ✨ Features
- ✅ Google OAuth 2.0 login/logout flow
- ✅ Protected resources page
- ✅ Modern UI with Bootstrap 5 and Font Awesome
- ✅ Privacy policy page
- ✅ User profile display (name, email, photo)

## 🚀 Quick Start

### Prerequisites
- [.NET 7.0 SDK](https://dotnet.microsoft.com/download)
- Visual Studio 2022 or VS Code
- Google account (for OAuth credentials)
- Modern browser (Chrome, Edge, Firefox)

### Google Cloud Console Setup
1. **Create a new project** in [Google Cloud Console](https://console.cloud.google.com/)
2. **Enable Google+ API** in "APIs & Services" > "Library"
3. **Create OAuth 2.0 credentials**:
   - Application type: Web application
   - Add authorized redirect URIs:
     ```
     https://localhost:8080/signin-google
     ```
4. **Save your Client ID and Client Secret**

### Project Setup
```bash
git clone https://github.com/your-username/OAuthDemo.git
cd OAuthDemo
````
