using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace foodapp.entity
{
    public class Order
    {
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string PaymentId { get; set; }
        public string ConversationId { get; set; }
        public EnumPaymentType PaymentType { get; set; }
        public EnumOrderState OrderState { get; set; }
        public List<OrderItem> OrderItems{get; set;}

    }

    public enum EnumPaymentType
    {
        
        CreditCard=0,
        BankCard=1,
        Transfer=2

    }

    public enum EnumOrderState
    {
        [Description("Onay Bekleniyor")]
        waiting=0,
        [Description("Ödeme Gerçekleşmedi")]
        unpaid=1,
        [Description("Yolda")]
        onway=2,
        [Description("Tamamlandı")]
        completed=3
    }
}