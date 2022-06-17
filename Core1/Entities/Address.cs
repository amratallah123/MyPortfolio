﻿using System;


namespace Core.Entities
{
    public class Address : EntityBase
    {
       public string Street { get; set; }
       public string City { get; set; }
       public int PostalCode { get; set; }
    }
}
