﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExProduct_HerancaEpolimorfismo.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee) :base(name,price)
        {
            CustomsFee = customsFee;
        }

        public override double PriceTag(double price)
        {
            return base.PriceTag(price) + CustomsFee;
        }


    }
}
