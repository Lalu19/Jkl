using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.DTO.App
{
    public class PatientTypeDTO
    {
        public string TypeOfPatient { get; set; }
        public int CreatedBy { get; set; }

    }
    public class PatientTypeUpdateDTO
    {
        public int PatientTypeId { get; set; }
        public string TypeOfPatient { get; set; }
        public int? UpdatedBy { get; set; }

    }
}
