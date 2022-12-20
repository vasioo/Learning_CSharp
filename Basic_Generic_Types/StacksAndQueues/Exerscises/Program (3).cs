using System;
using System.Collections.Generic;
using System.Linq;
namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfSongs = Console.ReadLine().
                Split(", ").
                ToList();
           Queue<string> songs = new Queue<string>(listOfSongs);
            while (true)
            {
                List<string> command = Console.ReadLine()
                    .Split(' ').
                    ToList();
                
                if (command[0]=="Play")
                {
                    if (songs.Count == 0)
                    {
                        Console.WriteLine("No more songs!");
                        break;
                    }
                    songs.Dequeue();
                    
                }
                if (songs.Count == 0)
                {
                    Console.WriteLine("No more songs!");
                    break;
                }
                else if (command[0]=="Add")
                {
                    command.Remove(command[0]);
                    string name = "";
                    foreach (var item in command)
                    {
                        name += item+" ";
                    }         
                   name= name.TrimEnd(' ');
                    if (songs.Contains(name))
                    {
                        Console.WriteLine($"{name} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(name);
                    }
                }
                else if (command[0]=="Show")
                {
                    List<string> result = new List<string>();
                    string resu = "";
                    foreach (var item in songs)
                    {
                        resu += (item + ", ");
                    }
                    resu = resu.TrimEnd(' ');
                    Console.WriteLine(resu.TrimEnd(','));
                }
            }
        }
    }
}
