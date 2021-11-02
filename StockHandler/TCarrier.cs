using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockHandler
{
    enum CarrierStates
    {
        Installed,
        WaitIn,
        WaitOut,
        Transferring,
        Stored,
        Completed,
        Alternate,
        None,
    }
    class TCarrier
    {
        public string ID { get; set; } = "";
        public string Location { get; set; } = "";
        public CarrierStates CarrierStatus { get; set; } = CarrierStates.None;
        public string Lottype { get; set; } = "";
        public string CleanTime { get; set; } = "";
        public string BatteryState { get; set; } = "";
        public bool Dup { get; set; } = false;


        // Console.WriteLine(CarrierStates.WaitOut.ToString())用这个代替public string GetCarrierStateStr()



    }
}
