# GarfSG.GetProxyListClient
Simple C#/.Net Standard wrapper for https://getproxylist.com/ API

## Get it on NuGet:
```
PM> Install-Package GarfSg.GetProxyListClient
```

## Usage
```
var apiKey = "apiKeyFromGetProxyListCom";
var proxyData = new GetProxyListClient().GetProxy(new GetProxySearchCriteria
                {
                    ApiKey = apiKey,
                    AllowsHttps = true,
                    Protocol = new[] { ProtocolEnum.Http }
                });
```

List of all criteria parameters are available here: https://getproxylist.com/#the-api
