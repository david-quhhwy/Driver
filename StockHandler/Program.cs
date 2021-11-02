using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonTools;


namespace StockHandler
{
    class Program
    {
        static void Main(string[] args)
        {

            //TCarrier t = new TCarrier();
            //t.CarrierState = CarrierStates.Completed;

            //Console.WriteLine(t.CarrierState.ToString());

            //  Console.WriteLine(t.PortName);

            //string str = IniFileHelper.ReadIniData("Subject", "AMHS", "", @"C:\WorkFolder\SSIMP01.ini");

            //Console.WriteLine(str);

            //Console.WriteLine(IniFileHelper.WriteIniData("Subject", "AMHS", "hihi", @"C:\WorkFolder\SSIMP01.ini").ToString());

            //MoveAction a = new MoveAction();

            //TCarrier b = new TCarrier();


            //LogHelper.WriteLogInfo("hi loginfo");

            //try
            //{
            //    string a = "FF";
            //    int b = Convert.ToInt32(a);
            //}
            //catch (Exception ex)
            //{

            //    LogHelper.WriteLogErr(ex.Message.ToString(), ex);


            //}

            PortStates e = PortStates.Abnormal;

            Console.WriteLine(e);

            PortStates a = (PortStates)2;


            Console.WriteLine(a);


            Console.ReadKey();
        }
    }
}
