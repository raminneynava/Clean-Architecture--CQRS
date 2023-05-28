﻿
using Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public class TravelerItemNameException : TravelerCheckListException
    {

        public TravelerItemNameException() : base("Traveler item name cannot be empty.")
        {
        }
    }
}
