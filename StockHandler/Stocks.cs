using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockHandler
{
    enum PortStates
    {
        Normal =0,
        Abnormal, 
    
    }

    class Stocks
    {        
        public string Name { get; set; } //e.g. KSIMP01

        ////Manual Port
        public string InputPort0_ID { get; set; } // e.g. MI1
        public string InputPort1_ID { get; set; }
        public string OutputPort0_ID { get; set; }// e.g. MO1
        public string OutputPort1_ID { get; set; }

        public PortStates InputPort0_State { get; set; } 
        public PortStates InputPort1_State { get; set; }
        public PortStates OutputPort0_State { get; set; }
        public PortStates OutputPort1_State { get; set; }

        public int InputPort0_Capacity { get; set; } 
        public int InputPort1_Capacity { get; set; }
        public int OutputPort0_Capacity { get; set; }
        public int OutputPort1_Capacity { get; set; }


        ////OHT Port
        public string InputOHTPort0_ID { get; set; }  //e.g. SI1
        public string InputOHTPort1_ID { get; set; }
        public string OutputOHTPort0_ID { get; set; } //e.g. SO1
        public string OutputOHTPort1_ID { get; set; }

        public PortStates InputOHTPort0_State { get; set; } 
        public PortStates InputOHTPort1_State { get; set; }
        public PortStates OutputOHTPort0_State { get; set; } 
        public PortStates OutputOHTPort1_State { get; set; }

        public int InputOHTPort0_Capacity { get; set; }
        public int InputOHTPort1_Capacity { get; set; }
        public int OutputOHTPort0_SCapacity { get; set; }
        public int OutputOHTPort1_Capacity { get; set; }


        ////库存剩余量
        public int StorageCapacity { get; set; }
        public int StorageMaxCapacity { get; set; }

       // maxsize

        //minsize







    }
}
