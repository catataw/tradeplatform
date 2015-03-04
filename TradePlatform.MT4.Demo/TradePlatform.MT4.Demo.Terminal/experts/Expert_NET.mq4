#property copyright "Copyright TradePlatform, 2005-2013"
#property link      "http://tradeplatform.codeplex.com/"

#property show_inputs

extern bool Bridge_NET_IsActive = true;
extern string Bridge_NET_Server="127.0.0.1";
extern int Bridge_NET_Port=2007;
extern string Bridge_NET_HandlerName = "QuoteListener";

int Ext_Operator_MagicNumber;

// .NET Integration
#include <Bridge_NET_API.mqh>
#include <Bridge_NET_MQL.mqh>
#include <Bridge_NET.mqh>

int init()
{
	MathSrand(TimeLocal());
	Ext_Operator_MagicNumber = MathRand();
	
	Bridge_NET_Init();
	Bridge_NET_API_Init();

	Comment(Bridge_NET_HandlerName);
}

int start()
{
	Bridge_NET_API_Start();
}

int deinit()
{
	Bridge_NET_API_DeInit();
	Bridge_NET_DeInit();
}

string Bridge_NET_MQL_Custom(string message[])
{
	if(message[1] == "METHOD_NAME")
	return("RETURN_VALUE");
	
	return("###NORESULT###");
}