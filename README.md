# Codename: Nikola Tesla's ACDC

dotnet --info
dotnet --version

dotnet new sln -n TeslaACDC
dotnet new webapi -o TeslaACDC.API
dotnet sln add TeslaACDC.API
dotnet build
