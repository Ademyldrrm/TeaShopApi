﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShopApi.EntiyLayer.Concrete
{
    public class Testimonial
    {
        public int TestimonialID { get; set; }
        public string TestimonialName { get; set; }
        public string TestimonialComment { get; set; }
        public string TestimonialImageUrl { get; set; }
    }
}
