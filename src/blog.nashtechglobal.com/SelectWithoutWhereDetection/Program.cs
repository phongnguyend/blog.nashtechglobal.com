using SelectWithoutWhereDetection;

using var db = new BloggingContext();

var blogs = db.Blogs.ToList().Where(x => x.BlogId == 1).ToList();