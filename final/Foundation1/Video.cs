using System;
class Video
{
    public string _video;
    public List<string> _videoList = new List<string>
    {
        "Title: Growing Plants, Author: PlantLover, Length: 600 seconds",
        "Title: Killing Plants, Author: PlantHater, Length: 1200 seconds",
        "Title: NewUpdateInstaller, Author: TechWiz, Length: 180 seconds",
        "Title: How to Remove Malware, Author: TechWiz, Length: 200 seconds",
        "Title: How to Set Up Your Own Lights, Author: ElecticManic, Length: 1000 seconds",
        "Title: My House Burn Down, Author: ElecticManic, Length: 300 seconds",
        "Title: Firefighters Put Out a Burning Building, Author: FireFighterNews, Length: 2000 seconds",
        "Title: My Neigbors an Idiot, Author: DramaKing, Length: 500 seconds"
    };

    public string getVideo()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_videoList.Count);
        _video = _videoList[index];
        return _video;
    }
}
