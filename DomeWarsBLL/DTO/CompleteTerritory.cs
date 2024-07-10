using DomeWarsDomain.Entities;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomeWarsBLL.DTO
{
    public class CompleteTerritory : Territory
    {
        public Gang? gang;
    }
}
