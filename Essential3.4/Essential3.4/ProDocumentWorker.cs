﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Essential3._4
{
    public class ProDocumentWorker:DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
    }
}