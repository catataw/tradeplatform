#property copyright "Copyright TradePlatform, 2005-2013"
#property link      "http://tradeplatform.codeplex.com/"

int Bridge_NET_API_Init()
{
	string result = Bridge_NET_CallFunction(Bridge_NET_HandlerName, "Init");
	return(StrToInteger(result));
}

int Bridge_NET_API_Start()
{
	string result = Bridge_NET_CallFunction(Bridge_NET_HandlerName, "Start");
	return(StrToInteger(result));
}

int Bridge_NET_API_DeInit()
{
	string result = Bridge_NET_CallFunction(Bridge_NET_HandlerName, "DeInit");
	return(StrToInteger(result));
}