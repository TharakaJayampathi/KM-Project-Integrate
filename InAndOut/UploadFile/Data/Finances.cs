﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UploadFile.Data
{
    public partial class Finances
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Reference { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public byte[] Attachment { get; set; }
    }
}
