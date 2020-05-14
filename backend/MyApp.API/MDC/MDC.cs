using Reusable.Attachments;
using Reusable.CRUD.Contract;
using Reusable.CRUD.Entities;
using Reusable.CRUD.JsonEntities;
using ServiceStack;
using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyApp.Logic.Entities
{
    [Alias("mdc")]
    [Table("mdcs")]
    public class MDC : BaseDocument
    {
        public MDC()
        {

        }

        public string ControlNumber { get; set; }
        public string DocumentTitle { get; set; }
        public string ProcessType { get; set; }
        public string DepartmentArea { get; set; }
        public string Owner { get; set; }
        public string Approvers { get; set; }
        public string Comments { get; set; }

    }
}