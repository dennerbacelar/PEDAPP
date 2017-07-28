using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PED.Views.Navigation
{

    public class MasterDetailMainMenuItem
    {
        public MasterDetailMainMenuItem()
        {
            
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}