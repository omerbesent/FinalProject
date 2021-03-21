﻿using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Constans
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Kategoriye eklenen ürün sayısı en fazla 15 olabilir";
        public static string ProductNameAllreadyExists = "Bu isimde zaten ürün var";
        public static string CategoryLimitExceded = "Kategori limiti aşıldı";
    }
}
