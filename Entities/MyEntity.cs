using System;

namespace NetApp.Entities // namespace отсылает к папке проекта
{
    public class MyEntity
    {
        public DateOnly MyDate { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }

    public MyEntity(DateOnly myDate, int id, string title)
    {
        MyDate = myDate;
        Id = id;
        Title = title;
    }

    }
}