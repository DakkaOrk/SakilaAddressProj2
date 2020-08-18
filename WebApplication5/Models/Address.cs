using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
    public class Address
    {
		[Key]
		public int? address_id { get; set; }
		public string address { get; set; }
		public string address2 { get; set; }
		public string district { get; set; }
		public int city_id { get; set; }
		public string postal_code { get; set; }
		public string phone { get; set; }
		public DateTime last_update { get; set; }
	}
}

/*	[address_id] [int] IDENTITY(1,1) NOT NULL,
	[address] [varchar](50) NOT NULL,
	[address2] [varchar](50) NULL,
	[district] [varchar](20) NOT NULL,
	[city_id] [int] NOT NULL,
	[postal_code] [varchar](10) NULL,
	[phone] [varchar](20) NOT NULL,
	[last_update] [datetime] NOT NULL,
*/