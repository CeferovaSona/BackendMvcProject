using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectBackend.Models;

namespace ProjectBackend.ViewModels
{
    public class HomeViewModel
    {
        public Slider Slider { get; set; }
        public Welcome Welcome { get; set; }
        public List<Blog> Blog { get; set; }
        public List<BlogDetail> BlogDetail { get; set; }
        public List<BlogsCategory> BlogsCategory { get; set; }
        public List<BlogsPost> BlogsPost { get; set; }
        public List <Category> Category { get; set; }
        public List<Course>Course { get; set; }
        public List<CourseDetail> CourseDetail { get; set; }
        public List<CourseFeature> CourseFeature { get; set; }
        public List<CoursesCategory> CourseCategory { get; set; }
        public List<CoursesPost> CoursesPost { get; set; }
        public List<Event> Event { get; set; }
        public List<EventDetail> EventDetail { get; set; }
        public List<EventsCategory> EventCategory { get; set; }
        public List<EventsPost> EventPost { get; set; }
        public List<EventsSpiker> EventsSpiker { get; set; }
        public List<Post> Post { get; set; }
        public List<Skill> Skill { get; set; }
        public List<SocialMedia> SocialMedia { get; set; }
        public List<Spiker> Spiker { get; set; }
        public List<Teacher> Teacher { get; set; }
        public List<TeacherDetail> TeacherDetail { get; set; }
        public List<TeachersSkill> TeachersSkill { get; set; }
        public List<SliderImage> SliderImage { get; set; }
        public NoticeVideo NoticeVideo{ get; set; }
        public List<NoticeBoard> NoticeBoard { get; set; }




    }
}
