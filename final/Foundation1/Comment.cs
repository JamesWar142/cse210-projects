class Comment
{
    public string _comment;
    public List<string> _commentList = new List<string>
    {
        "Name: PlantLover, Comment: I think this video is absolutly lovely.",
        "Name: PlantHater, Comment: I hate it",
        "Name: TechWiz, Comment: I know a way you can make this more efficent",
        "Name: ElectricManic, Comment: SICK!",
        "Name: FireFighterNews, Comment: Come to our channel to see firefighters at work.",
        "Name: DramaKing, Comment: Ive seen better.",
        "Name: DaveMan, Comment: Great Video",
        "Name: SpongeKid1, Comment: First!",
        "Name: NotVirus101, Comment: ClickHereToClaim$$$100000",
        "Name: NitroMan, Comment: Love the new idea, will use it in the future",
        "Name: G4m3r, Comment: Not for me personally",
        "Name: PopPow, Comment: It looks nice. Wonderful job",
        "Name: ahahahahaha, Comment: %#$%#$^$#$@$%#$^"
    };

    public string getComment()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_commentList.Count);
        _comment = _commentList[index];
        return _comment;
    }
}
