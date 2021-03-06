﻿using MedicalClinicWebApi.DAL.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalClinicWebApi.BLL.DTOs
{
    public class LabOrderDTO
    {
        public int LabOrderId { get; set; }
        public string LabName { get; set; }

        [Column(TypeName = "SmallDateTime")]
        public DateTime OrderDate { get; set; }
        public LabResult Result { get; set; }
        public string PatientId { get; set; }
    }
}
