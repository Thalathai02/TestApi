# ใช้ .NET 8 SDK เป็น base image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 52462

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# คัดลอกไฟล์โปรเจคไปยัง container
COPY ["backend.csproj", "./"]
RUN dotnet restore "./backend.csproj"

# คัดลอกโค้ดทั้งหมดและคอมไพล์
COPY . .
RUN dotnet publish "backend.csproj" -c Release -o /app/publish

# ใช้ base image เพื่อรันแอป
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "backend.dll"]
