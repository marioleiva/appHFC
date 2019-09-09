﻿using Shop.Services.Interfaces.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Services.Interfaces.Handlers
{
    public interface ICanalesHandler
    {
        IEnumerable<RegisteredCanales> GetAllCanales();
        IEnumerable<RegisteredCanalesPlus> GetAllCanalesPlus();
        IEnumerable<RegisteredCanalesTotal> GetAllCanalesTotal();
        IEnumerable<RegisteredGenero> GetAllGenero();
        IEnumerable<RegisteredCanalesTotal> GetCanalesByCategory(string category);
        
    }
}
