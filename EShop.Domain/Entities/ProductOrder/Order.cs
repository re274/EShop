﻿using EShop.Domain.Entities.Account;
using EShop.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EShop.Domain.Entities.ProductOrder
{
    public class Order : BaseEntity
    {
        #region properties
        public int UserId { get; set; }

        public bool IsPay { get; set; }

        [Display(Name = "تاریخ پرداخت")]
        public DateTime PaymentDate { get; set; }

        [Display(Name = "قیمت کل")]
        public int TotalPrice { get; set; }

        [Display(Name = "کد پیگیری")]
        [MaxLength(300, ErrorMessage = "{0} نمی تواند بیش از {1} کاراکتر باشد")]
        public string Recipient { get; set; }

        [Display(Name = "توضیحات")]
        public string Description { get; set; }
        #endregion

        #region relations
        public User User { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        #endregion
    }
}
