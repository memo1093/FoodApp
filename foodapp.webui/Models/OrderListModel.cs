using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using foodapp.entity;

namespace foodapp.webui.Models
{
    public class OrderListModel
    {
        
        public int OrderId { get; set; }
        [Display(Name="Sipariş Numarası")]
        public string OrderNumber { get; set; }
        [Display(Name="Sipariş Tarihi")]
        public DateTime OrderDate { get; set; }
        public string UserId { get; set; }
        [Display(Name="Alıcı Adı")]

        public string FirstName { get; set; }
        [Display(Name="Alıcı Soyadı")]

        public string LastName { get; set; }
        [Display(Name="Sipariş Adresi")]

        public string Address { get; set; }
        [Display(Name="Alıcının Telefon Numarası")]

        public string Phone { get; set; }
        [Display(Name="Email adresi")]

        public string Email { get; set; }
        [Display(Name="Ödeme Türü")]

        public EnumPaymentType PaymentType { get; set; }
        public string PaymentTypeName { get{
            switch (PaymentType)
            {
                case EnumPaymentType.BankCard:
                return "Banka Kartı";
                case EnumPaymentType.CreditCard:
                return "Kredi Kartı";
                case EnumPaymentType.Transfer:
                return "Havale/EFT";
                default:
                return "Hatalı işlem";
            }
        } }

        [Display(Name="Sipariş Durumu")]

        public EnumOrderState OrderState { get; set; }
        public string OrderStateName { get{
            switch (OrderState)
            {
                case EnumOrderState.waiting:
                return "Onay Bekleniyor";
                case EnumOrderState.unpaid:
                return "Ödenmemiş";
                case EnumOrderState.onway:
                return "Yolda";
                case EnumOrderState.completed:
                return "Tamamlandı";
                default:
                return "Hatalı işlem";
            }
        } }
        [Display(Name="Alınan Ürünler")]

        public List<OrderItemModel> OrderItems{get; set;}
        public double CargoPrice { get; set; }
        public double OrderTotal()
        {
            return OrderItems.Sum(i=>i.Price*i.Quantity)+CargoPrice;
        }

        
    }

    public class OrderItemModel
    {
        public int OrderItemId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string ImageUrl { get; set; }
    }
}