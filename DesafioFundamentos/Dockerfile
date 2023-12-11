FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine

# Set working directory
WORKDIR /app

# Copy .csproj and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy the rest of the files to the working directory
COPY . ./

CMD ["dotnet", "run"]
