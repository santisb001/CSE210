using System;

class Program
{
    static void Main(string[] args)
    {
        //1st Video
        Video video1 = new Video("Top 5 Best New mobile devices of 2026!","Ern13 ProMax",2457);
        video1.ExpandCommentList("TywinLannnister44","The 1st onm is notr wat I expected, Idnt Recmend");
        video1.ExpandCommentList("XxXMinerPro357XxX","Bro loved ur video, pls upload moreeee :)");
        video1.ExpandCommentList("AnakinLuke71","POV: When you are too poor to afford even one of them but still watch the whole thing. PS: tone down the music");
        video1.ExpandCommentList("Tobias Gutierrez","Yo tengo el primero, lo recomiendo, nada que ver loq ue puso @TywinLannnister44");
        //2nd Video
        Video video2 = new Video("Battlfront 2: Campaing, Chapter 5","X1berCrys74l",7201);
        video2.ExpandCommentList("TywinLannnister44","You are kinda bad at this, I beated this lvl 8 years ago, you noob!");
        video2.ExpandCommentList("XxXMinerPro357XxX","Maybe try using more the special habilities, the recond droid can shock the enemies for a littlewhile. Loved the video");
        video2.ExpandCommentList("AnakinLuke71","lol, bro pls use the cover!!");
        video2.ExpandCommentList("Tobias Gutierrez","Si usas la habilidad del blaster pesado, puedes despejar los pasillos sin problemas.");
        //3rd Video
        Video video3 = new Video("Why GOT deserved better","Nigth's Watch Sorcerer",3547);
        video3.ExpandCommentList("TywinLannnister44","You bunch of %&Q&%@, you ruined my character!!!");
        video3.ExpandCommentList("TywinLannnister44","nOw Im being censoredd!!!");
        video3.ExpandCommentList("XxXMinerPro357XxX","Loved the analysis, great vid!");
        video3.ExpandCommentList("AnakinLuke71","Imo it wasn't that bad.");
        video3.ExpandCommentList("Tobias Gutierrez","No eres el verdadero Tywin @TywinLannnister44, no siquiera hablas con clase!");
        //4th Video
        Video video4 = new Video("WHY I'M THE GREATEST PERSON TO EVER EXIST, AND WHY YOU SHOULD RESPECT MY INTELIGENCE","TywinLannnister44",28800);
        video4.ExpandCommentList("TywinLannnister44","AMAZING VIDEO");
        video4.ExpandCommentList("XxXMinerPro357XxX","I think you should relax, best wishes");
        video4.ExpandCommentList("AnakinLuke71","POV: When @TobiasGutierrez gives you the perfect villain arc");
        video4.ExpandCommentList("Nigth's Watch Sorcerer","Bro @TobiasGutierrez this is your fault...");
        video4.ExpandCommentList("Tobias Gutierrez","No es mi culpa por decir la verdad. NO ERES EL VERDADERO TWYN LANNISTER");

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video v in videos)
        {
            v.DisplayVideo();
        }
    }
}