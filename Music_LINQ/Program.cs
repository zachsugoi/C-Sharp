using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
                //Collections to work with
            List<Artist> Artists = JsonToFile<Artist>.ReadJson();
            List<Group> Groups = JsonToFile<Group>.ReadJson();

                //Grab all artists from Mount Vernon
            var mtVernon =  from match in Artists
                            where match.Hometown == "Mount Vernon"
                            select new { match.ArtistName, match.RealName, match.Age };
            foreach(var result in mtVernon){
                Console.WriteLine("Artists from Mount Vernon");
                Console.WriteLine("Artist: "+result.ArtistName);
                Console.WriteLine("Artist's real name: "+result.RealName);
                Console.WriteLine("Age: "+result.Age);
            }

                //Grab the youngest artist
            int youngest_age = Artists.Select( age => new { age.Age }).Min( num => num.Age);  //The Select clause is unnecessary--just including it for reference
            var youngest_artist = Artists.Where(artist => artist.Age == youngest_age);
            Console.WriteLine("Youngest Artist");
            foreach(var artist in youngest_artist){
                Console.WriteLine($"Artist: {artist.ArtistName}");
                Console.WriteLine($"Artist's real name: {artist.RealName}");
                Console.WriteLine($"Age: {artist.Age}");
            }
            
                //Display all artists with 'William' somewhere in their real name
            var williams = Artists.Where(william => william.RealName.IndexOf("William") != -1);
            Console.WriteLine("The Williams");
            foreach(var artist in williams){
                Console.WriteLine($"Artist: {artist.ArtistName}");
                Console.WriteLine($"Artist's real name: {artist.RealName}");
            }

                //Display the 3 oldest artists from Atlanta
            var old_atlanta = Artists.Where(atl => atl.Hometown =="Atlanta").OrderByDescending(age => age.Age).Take(3);
            Console.WriteLine("Oldest Three Artists from Atlanta");
            foreach(var artist in old_atlanta){
                Console.WriteLine($"Artist: {artist.ArtistName}");
                Console.WriteLine($"Artist's real name: {artist.RealName}");
                Console.WriteLine($"Age: {artist.Age}");
            }

                //Display the Group Name of all groups that have members that are not from New York City
            var groups_no_nyc = Artists.Where(nonyc => nonyc.Hometown != "New York City").Join(Groups,
                                                                                                artist_group => artist_group.GroupId,
                                                                                                group => group.Id,
                                                                                                (artist_group, group) =>
                                                                                                    new { group.GroupName }
                                                                                                ).Distinct();
            Console.WriteLine("Groups with no Members from NYC");
            foreach(var group in groups_no_nyc){
                Console.WriteLine($"Group Name: {group.GroupName}");
            }

                //Display the artist names of all members of the group 'Wu-Tang Clan'
            var wutang = Groups.Where(clan => clan.GroupName =="Wu-Tang Clan").Join(Artists,
                                                                                    group => group.Id,
                                                                                    artist_grp => artist_grp.GroupId,
                                                                                    (group, artist_grp) =>
                                                                                        new { group.GroupName, artist_grp.ArtistName }
                                                                                    );
            Console.WriteLine("Wu-Tang Clan members");
            foreach(var mbr in wutang){
                Console.WriteLine($"Group name: {mbr.GroupName}");
                Console.WriteLine($"Artist name: {mbr.ArtistName}");
            }
        }
    }
}
