# [how to implement Clean architecture skeleton step by step](https://www.youtube.com/watch?v=N6cyzeSGlw8)

# project structure
```
project_root/  # Blank Solution
│
├── Core/
│   ├── Applicatoin/           # Class Library
│   │   ├── Extensions/
│   │   │   ├── ApplicationDIRegistration.cs
│   │   ├── Features/
│   │   │   ├── Author/         
│   │   │   ├── Blog/         
│   │   │   │   ├── Commands/         
│   │   │   │   ├── Queries/     
│   │   ├── Interfaces/
│   │   │   ├── IRepository.cs         
│   │   │   └── ...
│   ├── Domain/           # Class Library
│   │   ├── Entites/
│   │   ├── Settings/
├── Infrastructure/
│   ├── Infrastructure/           # Class Library
├── Persentation/
│   ├── WebAPI/           # ASP.NET Core Web API
└── Test/
│   ├── Application.UnitTests/           # xUnit Test Project
```