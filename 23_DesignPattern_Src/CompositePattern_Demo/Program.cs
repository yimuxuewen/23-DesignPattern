using System;

namespace CompositePattern_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            DomainNode Compan = new DomainNode() { Name = "Compan", Percent = 90 };
            DomainNode CEO = new DomainNode() { Name = "CEO", Percent = 70 };
            DomainNode Team = new DomainNode() { Name = "Team", Percent = 30 };
            DomainNode TeamA = new DomainNode() { Name = "TeamA", Percent = 40 };
            DomainNode TeamB = new DomainNode() { Name = "TeamB", Percent = 60 };
            DomainNode TeamAManager = new DomainNode() { Name = "ManagerA", Percent = 40 };
            DomainNode ProgrammerTeamA = new DomainNode() { Name = "ProgrammerTeamA", Percent = 60 };
            DomainNode ImplementersTeamA = new DomainNode() { Name = "ImplementersTeamA", Percent =40 };
            DomainLeaf ProgrammerAA = new DomainLeaf() { Name = "ProgrammerAA", Percent = 60 };
            DomainLeaf ProgrammerAB = new DomainLeaf() { Name = "ProgrammerAB", Percent = 40 };
            DomainLeaf ImplementersAA = new DomainLeaf() { Name = "ImplementersAA", Percent = 70 };
            DomainLeaf ImplementersAB = new DomainLeaf() { Name = "ImplementersAB", Percent = 30 };

            DomainNode TeamBManager = new DomainNode() { Name = "ManagerB", Percent = 40 };
            DomainNode ProgrammerTeamB = new DomainNode() { Name = "ProgrammerTeamB", Percent = 40 };
            DomainNode ImplementersTeamB = new DomainNode() { Name = "ImplementersTeamB", Percent = 60 };
            DomainLeaf ProgrammerBA = new DomainLeaf() { Name = "ProgrammerBA", Percent = 40 };
            DomainLeaf ProgrammerBB = new DomainLeaf() { Name = "ProgrammerBB", Percent = 60 };
            DomainLeaf ImplementersBA = new DomainLeaf() { Name = "ImplementersBA", Percent = 60 };
            DomainLeaf ImplementersBB = new DomainLeaf() { Name = "ImplementersBB", Percent = 40 };

            Compan.AddDomain(CEO,Team);
            Team.AddDomain(TeamA, TeamB);
            TeamA.AddDomain(TeamAManager, ProgrammerTeamA, ImplementersTeamA);
            TeamB.AddDomain(TeamBManager, ProgrammerTeamB, ImplementersTeamB);
            ProgrammerTeamA.AddDomain(ProgrammerAA, ProgrammerAB);
            ImplementersTeamA.AddDomain(ImplementersAA, ImplementersAB);

            ProgrammerTeamB.AddDomain(ProgrammerBA, ProgrammerBB);
            ImplementersTeamB.AddDomain(ImplementersBA, ImplementersBB);


            Compan.Commission(1000000);
            Console.ReadLine();
        }
    }
}
