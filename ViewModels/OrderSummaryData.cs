using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TilausDBAdvancedMVCPalautus.Models;
using TilausDBAdvancedMVCPalautus.ViewModels;


namespace TilausDBAdvancedMVCPalautus.ViewModels
{
    public class OrderSummaryData
    {
        public int TilausID { get; set; }
        public int AsiakasID { get; set; }
        public int TuoteID { get; set; }
        public float Ahinta { get; set; }
        public string Toimitusosoite { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd\\.MM\\.yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> Tilauspvm { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd\\.MM\\.yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> Toimituspvm { get; set; }
        public string Postinumero { get; set; }
        public string Postitoimipaikka { get; set; }
        public string Nimi { get; set; }
        public int Maara { get; set; }
        public int TilausriviID { get; set; }

    }
}