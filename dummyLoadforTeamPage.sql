--test seed data
--delete from Players
--delete from Games
--delete from Stadia
--delete from Teams
--delete from Conferences


insert into Teams
(RefNum, Name, SchoolName, ConfRefNum, NumOfNatlChamp, NumOfConfChamp, YearFounded, AllTimeWins, AllTimeLosses, AllTimeTies, BowlWins, BowlLosses, BowlTies, NumOfHeismans, NumOfAllAmericans, HeadCoach, OffCoord, DefCoord, Mascot, TeamUrl, ColorHexCode, Image)
values
('1','Texas Longhorns','University of Texas at Austin','5',4,32,1883,900,300,40,55,37,4,2,52,'Charles Strong','Joseph Wickline','Vance Bedford','Bevo','http://www.texassports.com','CF5300','texas.png'),
('2','Michigan Wolverines','University of Michigan at Ann Arbor','6',4,32,1883,900,300,40,55,37,4,2,52,'Brady Holke','Some Dude','Someother dude','Wolvy the Wolverine','http://www.texassports.com','00274c','michigan.png')


insert into Conferences
(RefNum, Name, Subdivision)
values
('5','Big XII','FBS'),
('6','B1G','FBS')

insert into Stadia
(RefNum, Name, City, State, Capacity, Surface, YearOpen)
values
('1','DKR Memorial Stadium','Austin','TX', 101000,'Turf',1932)

insert into Games
(RefNum, Date, VisitTeamRefNum, HomeTeamRefNum, StadiumRefNum, Site)
values
('2',GETUTCDATE(),'1','2', '1','Neutral')

insert into Players
(RefNum, TeamRefNum, FirstName, LastName, JerseyNum, Class, Position, Height, Weight, Town, State, Country, PrevSchool)
values
('1','1','David', 'Ash', '11', 1930, 'QB','6.1','190','Austin','TX','USA','some high school')

insert into GameStatistics
([GameRefNum],[Attendance],[Duration])
values
('2',99999,180)

select * from GameStatistics

select * from Players

select * from Games

select * from Stadia

select * from Conferences

select * from Teams