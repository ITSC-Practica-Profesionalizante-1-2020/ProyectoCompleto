﻿using SharedModels.UserService;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharedModels.StreamingService
{
	public class ConferenceRecordFile : EntityBase
	{
		public UserEMPRESA Duenio { get; set; }
		public string NombreArchivo { get; set; }
		public string Direccion { get; set; }
		public VideoRoom VideoRoom { get; set; }
	}
}
