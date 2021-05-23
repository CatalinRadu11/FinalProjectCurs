using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectCurs
{
    public enum CarModelEnum
    {
        [Description("Audi A3")]
        AudiA3,
        [Description("Volkswagen Tiguan")]
        VolkswagenTiguan,
        [Description("BMW I8")]
        BMWI8,
        [Description("Hyundai Tucson")]
        HyundaiTucson,
        [Description("Lamborghini Aventador")]
        LamborghiniAventador,
        [Description("Renault Clio")]
        RenaultClio
    }
}
