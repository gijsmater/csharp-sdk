using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAYNLSDK.API.Instore.payment
{
    public class Response : ResponseBase
    {
        /// <summary>
        /// Transactions once started using iDeal, MisterCash, Creditcard etc., and are not completed yest, can be completed by PIN. 
        /// Use the transactionId/orderId and entranceCode of the original transaction to start a PIN transaction.
        /// The amount of the PIN transaction is copied from the original transaction and cannot be changed.
        /// If you own multiple PIN terminals, you can provide the ID of the terminal to be used to complete the transaction.
        /// If no terminal ID is provided, a terminal will be selected automatically.
        /// </summary>
        public Objects.Instore.Payment Payment { get; set; }
    }
}
