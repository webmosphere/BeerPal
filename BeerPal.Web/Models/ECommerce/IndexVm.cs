﻿using System.Collections.Generic;
using BeerPal.Data.Entities;

namespace BeerPal.Web.Models.ECommerce
{
    public class IndexVm
    {
        public List<Beer> Beers { get; set; }

        public IndexVm()
        {
            Beers = new List<Beer>();
        }
    }
}