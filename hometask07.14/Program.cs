using hometask07._14.data;

using hometask07._14.model;


Console.WriteLine("Hello, World!");

void addwithusing()
{
    using (var db = new UserDB())
    {
        db.staffs.Add(new staff()
        {
            staffid = 1,
            staffname = "Oquv bolimi",
            staffdescription = "Oquv bolimi",
        });


        db.SaveChanges();
    }

}


void Add()
{
    var db = new UserDB();
    db.staffs.Add(new staff()
    {
        staffid = 2,
        staffname = "hr bolimi",
        staffdescription = "dd"
    });

}