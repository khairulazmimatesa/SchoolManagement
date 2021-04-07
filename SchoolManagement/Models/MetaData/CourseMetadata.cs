using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolManagement.Models.MetaData {
    public class CourseMetadata {

        [StringLength(50)]
        public string Title { get; set; }
        [Range(1,8)]
        public int Credits { get; set; }

    }

    [MetadataType(typeof(CourseMetadata))]
    public partial class Course {

    }
}