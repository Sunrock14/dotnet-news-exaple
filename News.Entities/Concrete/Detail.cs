using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Entities.Concrete
{
    public class Detail
    {

        public int errorCode { get; set; }
        public object errorMessage { get; set; }
        public Data data { get; set; }

        public class Data
        {
            public Headerad headerAd { get; set; }
            public Newsdetail newsDetail { get; set; }
            public Footerad footerAd { get; set; }
            public Multimedia multimedia { get; set; }
            public Itemlist[] itemList { get; set; }
            public Relatednews relatedNews { get; set; }
            public Video video { get; set; }
            public Photogallery photoGallery { get; set; }
        }

        public class Headerad
        {
            public string itemType { get; set; }
            public string adUnit { get; set; }
            public int itemWidth { get; set; }
            public int itemHeight { get; set; }
        }

        public class Newsdetail
        {
            public string resource { get; set; }
            public string bodyText { get; set; }
            public bool hasPhotoGallery { get; set; }
            public bool hasVideo { get; set; }
            public string publishDate { get; set; }
            public string fullPath { get; set; }
            public string shortText { get; set; }
            public Category category { get; set; }
            public string itemId { get; set; }
            public string title { get; set; }
            public string video { get; set; }
            public string imageUrl { get; set; }
            public string itemType { get; set; }
        }

        public class Category
        {
            public string categoryId { get; set; }
            public string title { get; set; }
            public string slug { get; set; }
            public string color { get; set; }
        }

        public class Footerad
        {
            public string itemType { get; set; }
            public string adUnit { get; set; }
            public int itemWidth { get; set; }
            public int itemHeight { get; set; }
        }

        public class Multimedia
        {
            public string sectionType { get; set; }
            public string repeatType { get; set; }
            public int itemCountInRow { get; set; }
            public bool lazyLoadingEnabled { get; set; }
            public bool titleVisible { get; set; }
            public object title { get; set; }
            public object titleColor { get; set; }
            public object titleBgColor { get; set; }
            public object sectionBgColor { get; set; }
        }

        public class Relatednews
        {
            public bool hasPhotoGallery { get; set; }
            public bool hasVideo { get; set; }
            public string publishDate { get; set; }
            public string shortText { get; set; }
            public Category1 category { get; set; }
            public string itemId { get; set; }
            public string title { get; set; }
            public string imageUrl { get; set; }
            public string itemType { get; set; }
            public bool titleVisible { get; set; }
        }

        public class Category1
        {
            public string categoryId { get; set; }
            public string title { get; set; }
            public string slug { get; set; }
        }

        public class Video
        {
            public string shortText { get; set; }
            public string bodyText { get; set; }
            public string videoUrl { get; set; }
            public string itemId { get; set; }
            public string title { get; set; }
            public string imageUrl { get; set; }
            public string itemType { get; set; }
            public bool titleVisible { get; set; }
        }

        public class Photogallery
        {
            public object itemList { get; set; }
            public string itemId { get; set; }
            public string title { get; set; }
            public string imageUrl { get; set; }
            public string itemType { get; set; }
            public bool titleVisible { get; set; }
        }

        public class Itemlist
        {
            public object itemList { get; set; }
            public string itemId { get; set; }
            public string title { get; set; }
            public string imageUrl { get; set; }
            public string itemType { get; set; }
            public bool titleVisible { get; set; }
            public string shortText { get; set; }
            public string bodyText { get; set; }
            public string videoUrl { get; set; }
        }

    }
}
