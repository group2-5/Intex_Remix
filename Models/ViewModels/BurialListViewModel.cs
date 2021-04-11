using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intex_Remix.Models.ViewModels
{
    public class BurialListViewModel
    {
        //these are the fields which will be passed to the strongly-typed view. This class is basically a bundle that gets passed to the view

        //needs a public IEnumerable for each table that is being passed to the view
        public IEnumerable<Main> Burials { get; set; }
        public PageNumberingInfo PageNumberingInfo { get; set; }


        //maybe a nullable field for each category of filter that we will use
        public string? HairColor { get; set; }
    }
}
