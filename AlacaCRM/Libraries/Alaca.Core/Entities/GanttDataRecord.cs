using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Alaca.Core.Entities
{
	public partial class GanttDataRecord
	{
		[JsonPropertyName("label")]
		public string Label
		{
			get;
			set;
		}
		[JsonPropertyName("dateStart")]
		public string DateStart
		{
			get; set;
		}

		[JsonPropertyName("dateEnd")]
		public string DateEnd
		{
			get; set;
		}

		[JsonPropertyName("class")]
		public string Class
		{
			get; set;
		}


		[JsonPropertyName("type")]
		public string Type
		{
			get; set;
		}
	}
}
