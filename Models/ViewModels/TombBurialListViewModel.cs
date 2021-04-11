using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intex_Remix.Models.ViewModels
{
    public class TombBurialListViewModel
    {
        //these are the fields which will be passed to the strongly-typed view. This class is basically a bundle that gets passed to the view

        //needs a public IEnumerable for each table that is being passed to the view
        //public IEnumerable<Summary> Mummies { get; set; }
        public PageNumberingInfo PagingInfo { get; set; }
    }
}
