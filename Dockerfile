FROM microsoft/aspnetcore-build

WORKDIR /EntidadesApi

COPY . /EntidadesApi


RUN dotnet restore

RUN dotnet publish -o /publish/

WORKDIR /publish


# Build runtime image

ENTRYPOINT ["dotnet", "EntidadesApi.dll"]
