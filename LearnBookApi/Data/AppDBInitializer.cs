namespace LearnBookApi.Data
{
    public class AppDBInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDBContext>();

                if (!context.Books.Any())
                {
                    context.Books.AddRange(new Models.Book()
                    {


                        Title = "Title 1",

                        Description = "Descr 1",

                        IsRead = true,

                        DateRead = DateTime.Now.Date,

                        Rate = 1,

                        CoverUrl = "www.google.com",

                        Genre = string.Empty,

                        Author = "Ashu"
                    }, new Models.Book()
                    {


                        Title = "Title 2",

                        Description = "Descr 2",

                        IsRead = true,

                        DateRead = DateTime.Now.Date,

                        Rate = 1,

                        CoverUrl = "www.google.com",

                        Genre = string.Empty,

                        Author = "Ashu"
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
