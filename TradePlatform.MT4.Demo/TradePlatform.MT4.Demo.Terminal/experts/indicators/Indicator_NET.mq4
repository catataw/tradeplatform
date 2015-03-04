#property copyright "Copyright TradePlatform, 2005-2013"
#property link      "http://tradeplatform.codeplex.com/"

#property indicator_chart_window
#property indicator_minimum 1
#property indicator_maximum 10
#property indicator_buffers 2
#property indicator_color1 Green
#property indicator_color2 Red

#property show_inputs

extern bool Bridge_NET_IsActive = true;
extern string Bridge_NET_Server="127.0.0.1";
extern int Bridge_NET_Port=2007;
extern string Bridge_NET_HandlerName = "PrevDayHighLowIndicator";

int Ext_Operator_MagicNumber = 0;
int Ext_Operator_Point = 0;
int Ext_Operator_Slippage = 0;

// MQL Extensions
//#include <Ext_Helpers.mqh>

//--- buffers
double ExtMapBuffer1[];
double ExtMapBuffer2[];

// .NET Integration
#include <Bridge_NET.mqh>
#include <Bridge_NET_MQL.mqh>
//#include <Bridge_NET_MQL_System.mqh>
#include <Bridge_NET_API.mqh>

int init()
{
	MathSrand(TimeLocal());
	Ext_Operator_MagicNumber = MathRand();
	
	SetIndexStyle(0,DRAW_LINE);
	SetIndexBuffer(0,ExtMapBuffer1);
	SetIndexStyle(1,DRAW_LINE);
	SetIndexBuffer(1,ExtMapBuffer2);

	Bridge_NET_Init();
	Bridge_NET_API_Init();
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
	if(message[1] == "ExtMapBuffer1")
	{
		ExtMapBuffer1[StrToInteger(message[2])] = StrToDouble(message[3]);
		return("");
	}
	
	if(message[1] == "ExtMapBuffer2")
	{
		ExtMapBuffer2[StrToInteger(message[2])] = StrToDouble(message[3]);
		return("");
	}
	
	return("###NORESULT###");
}