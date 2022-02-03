using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MapParcel_son.Models
{
    [Table("parcels")]
    public class ParcelModel
    {
        [Key]
        [Column("id")]
        public int ParcelID { get; set; }

        [Column("country")]
        public string ParcelCountry { get; set; }

        [Column("city")]
        public string ParcelCity { get; set; }

        [Column("district")]
        public string ParcelDistrict { get; set; }

        [Column("wkt")]
        public string WktString { get; set; }

    }
}
