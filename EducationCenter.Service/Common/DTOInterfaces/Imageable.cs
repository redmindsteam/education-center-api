using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCenter.Service.Common.DTOInterfaces
{
    public interface Imageable
    {
        public IFormFile Image { get; set; }
    }
}
