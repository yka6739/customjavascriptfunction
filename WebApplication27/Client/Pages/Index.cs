using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication27.Client.Componenet;

namespace WebApplication27.Client.Pages
{
    public partial class Index
    {
        private List<Data> d;
        protected override void OnInitialized()
        {
            d = new List<Data>()
            {
                new Data(){Id=101, Name="Aman", Address="Noida"}
            };
        }
        
        private async Task Delete(Data d1)
        {
            await js.MyFunction("Custom Data Validation Function is Working.....");
            var confirmed = await js.Confirm($"Are You Want to Delete");
            if (confirmed)
            {


                d.Remove(d1);
            }
        }
        public void Add(Data d2)
        {
            d.Add(d2);
        }
        public bool check = false;
    }
}
