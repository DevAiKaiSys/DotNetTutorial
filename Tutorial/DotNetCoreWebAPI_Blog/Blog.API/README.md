# [how to implement Clean architecture skeleton step by step](https://www.youtube.com/watch?v=N6cyzeSGlw8)

# project structure

```
project_root/  # Blank Solution
│
├── Core/
│   ├── Applicatoin/           # Class Library
│   │   ├── Extensions/
│   │   │   ├── ApplicationDIRegistration.cs    # AddApplicationService
│   │   ├── Features/
│   │   │   ├── Author/         
│   │   │   ├── Blog/         
│   │   │   │   ├── Commands/         
│   │   │   │   ├── Queries/     
│   │   ├── Interfaces/
│   │   │   ├── IRepository.cs         # interface
│   │   │   └── ...
│   │   ├── Profiles/
│   │   │   ├── MappingProfile.cs  
│   │   ├── Responses/
│   │   │   ├── BaseResponse.cs  
│   ├── Domain/           # Class Library
│   │   ├── Entites/
│   │   │   ├── Author.cs  
│   │   │   ├── Blog.cs  
│   │   ├── Settings/
├── Infrastructure/
│   ├── Infrastructure/           # Class Library
│   │   ├── Extensions/
│   │   │   ├── InfrastructureDIRegistration.cs    # AddInfrastructureServices
│   │   ├── Repositories/
│   │   │   ├── Repository.cs      # implement interface
│   │   ├── SeedData/
│   │   │   ├── DBInitializerSeedData.cs     
│   │   ├── Services/
│   │   │   ├── AzureServiceBusService.cs      
│   │   ├── BlogDbContext.cs        
├── Persentation/
│   ├── WebAPI/           # ASP.NET Core Web API
└── Test/
│   ├── Application.UnitTests/           # xUnit Test Project
```

# test all file ok

right click main solution run Build Solution (Ctrl+Shift+B)