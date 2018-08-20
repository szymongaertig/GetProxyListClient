#!/bin/bash

dotnet build --configuration=Release

if [ $? -ne 0 ]
then 
    exit 1
fi

dotnet pack

if [ $? -ne 0 ]
then 
    exit 1
fi

dotnet nuget push src/GarfSG.GetProxyListClient/bin/Release/*.nupkg -s="https://api.nuget.org/v3/index.json" -k="$apiKey"