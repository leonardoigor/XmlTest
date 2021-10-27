FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env

WORKDIR /dotnet_volume

COPY *.csproj /dotnet_volume

RUN dotnet restore

COPY . /dotnet_volume

RUN dotnet dev-certs https --clean && dotnet dev-certs https --trust

EXPOSE 5001
CMD dotnet watch run --urls http://0.0.0.0:5001
