using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShopApi.DtoLayer.AboutDtos
{
    public class UpdateAboutDto
    {
        public int AboutID { get; set; }
        public string AboutComment { get; set; }
        public string AboutImage { get; set; }
    }
}
