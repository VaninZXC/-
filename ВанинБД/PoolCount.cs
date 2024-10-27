using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ВанинБД
{
    public static class PoolCount
    {
        private static int count = 0;
        public static void GetCount()
        {
            count++; 
            MessageBox.Show(count.ToString());
        }

        
    }
}
