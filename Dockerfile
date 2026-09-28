FROM mcr.microsoft.com/dotnet/sdk:8.0

WORKDIR /App

COPY *.csproj ./

RUN ["dotnet", "restore"]

COPY . .

EXPOSE 8080

ENTRYPOINT ["dotnet", "run"]

# Продакшен-запуск
# FROM mcr.microsoft.com/dotnet/aspnet:8.0

# WORKDIR /App

# COPY ./out .

# EXPOSE 8080

# ENTRYPOINT ["dotnet", "6_C#.dll"]
