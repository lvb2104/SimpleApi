# SimpleApi
---
Guide you through deploying an ASP.NET Core 6 Web API to AWS Elastic Beanstalk using a CI/CD pipeline built with AWS CodePipeline and CodeBuild, fully automated from GitHub pushes to live deployment.
1. **Local dev**: Create ASP.NET Core Web API in VS2022 targeting .NET 9.
2. **Add config files**:  
   - `buildspec.yml` → Build & publish instructions for CodeBuild.  
   - `Procfile` → Tells Elastic Beanstalk which DLL to run.  
3. **Push to GitHub** → triggers pipeline automatically.  
4. **Pipeline stages**:  
   - **Source**: Pull code from GitHub.  
   - **Build**: CodeBuild restores packages, compiles, publishes to `/app`.  
   - **Deploy**: Elastic Beanstalk runs the published app.  
5. **App live** at Beanstalk’s public URL.  
6. **Optional**: Set environment variables (e.g., `ASPNETCORE_ENVIRONMENT=Development` for Swagger in prod).
---
Blog source: https://codewithmukesh.com/blog/deploying-aspnet-core-web-api-to-aws-elastic-beanstalk-using-aws-codepipeline/
