﻿using System;
using System.ComponentModel.DataAnnotations;
using SistemaVendas.Models.Enums;

namespace SistemaVendas.Models
{
    public class SalesRecord
    {
        
        public int Id { get; set; }
        [Display(Name = "Data da venda")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }
        [Display(Name = "Valor Total")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Amount { get; set; }
        [Display(Name = "Situação do pedido")]
        public SaleStatus Status { get; set; }
        [Display(Name = "Vendedor")]
        public Seller Seller { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
