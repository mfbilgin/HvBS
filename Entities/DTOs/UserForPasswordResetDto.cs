﻿using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class UserForPasswordResetDto : IDto
    {
        public string HvBSNumber { get; set; }
    }
}
