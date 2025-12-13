class Reception : Event
{
    public Reception(Address address) : base(address){}
    public override void Standard()
    {
        Console.WriteLine("Birthday party.");
        Console.WriteLine("Come to my brother's birthday party.");
    }
    public override void Full()
    {
        Console.WriteLine("We will be selebrating his 16th birthday today! Presents welcomed but not required.");
    }
    public void RSVP()
    {
        Console.WriteLine("To RSVP, send an email to :1234@randomemail.com");
    }
    public override void Short()
    {
        Console.WriteLine("Reception, Birthday Party, 12/11/25");
    }
}