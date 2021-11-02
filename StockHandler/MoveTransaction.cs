using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockHandler
{
    //class MoveTransaction
    //{
    //}
    enum TransactionStatuses
    {
        None = 0,
        Pending = 1,
        Order = 2,
        Queued = 3,
        Waiting = 4,
        Active_ = 5,
        Transferring = 6,
        Canceling_ = 7,
        Paused = 8,
        Aborting = 9,
        Completed = 10

    }

    struct MoveTransactions
    {
        public TCarrier Carrier { get; set; }
        public int Priority { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public TransactionStatuses TransactionStatus { get; set; }
        public string CreateTmst { get; set; }
        public string CommandID { get; set; }
        public int SystemBytes { get; set; }
        // public string CarrierJobID,CarrierTypeFull,CarrierTypeClean
        public string LcdDisplayState { get; set; }
        public Stocks Stock { get; set; }
        //public string EqName { get; set; }
        //public string EqPort { get; set; }
        public string UserName { get; set; }
        public string ErrorMsg { get; set; }
        public string MES_Msg { get; set; }

    }





}
