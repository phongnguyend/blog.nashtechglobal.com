
using IEnumerableVsIQueryable;

var myQueryable = new MyQueryable<Blog>();
myQueryable.Where(x => x.BlogId > 1).Select(x => x.Url).ToList();


//var blogs = new List<Blog> { new Blog { BlogId = 1 }, new Blog { BlogId = 2 }, new Blog { BlogId = 3 } };

//var rs = blogs.Where(x => x.BlogId > 1).ToList();

using (var db = new BloggingContext())
{
    int id = 1;
    var blogs = db.Blogs!.Where(x => x.BlogId > id).OrderBy(x => x.Name).ToList();
}

using (var db = new BloggingContext())
{
    int id = 2;
    var blogs = db.Blogs!.Where(x => x.BlogId > id).OrderBy(x => x.Name).ToList();
}

Console.ReadLine();
