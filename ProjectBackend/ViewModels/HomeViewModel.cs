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
        public List<Blog> Blogs { get; set; }
        public List<BlogDetail> BlogDetails { get; set; }
        public List<BlogsCategory> BlogsCategories { get; set; }
        public List<BlogsPost> BlogsPosts { get; set; }
        public List <Category> Categories { get; set; }
        public List<Course>Courses { get; set; }
        public List<CourseDetail> CourseDetails { get; set; }
        public List<CourseFeature> CourseFeatures { get; set; }
        public List<CoursesCategory> CourseCategories { get; set; }
        public List<CoursesPost> CoursesPosts { get; set; }
        public List<Event> Events { get; set; }
        public List<EventDetail> EventDetails { get; set; }
        public List<EventsCategory> EventCategories { get; set; }
        public List<EventsPost> EventPosts { get; set; }
        public List<EventsSpiker> EventsSpikers { get; set; }
        public List<Post> Posts { get; set; }
        public List<Skill> Skills { get; set; }
        public List<SocialMedia> SocialMedias { get; set; }
        public List<Spiker> Spikers { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<TeacherDetail> TeacherDetails { get; set; }
        public List<TeachersSkill> TeachersSkills { get; set; }
        public NoticeVideo NoticeVideo{ get; set; }
        public List<NoticeBoard> NoticeBoards { get; set; }




    }
}
