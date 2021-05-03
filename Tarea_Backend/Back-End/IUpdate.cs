using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea_Backend.Models;

namespace Tarea_Backend.Back_End
{
    interface IUpdate
    {
        public void UpdateNameById(int id, string name);
    }
}
