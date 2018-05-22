# Rock Paper Scissors

### Game Rules

A match takes place between 2 players and is made up of 3 games with the overall winner
being the first player to win 2 games (i.e. best of 3).
Each game consists of both players selecting one of Rock, Paper or Scissors; the game
winner is determined based on the following rules:
* Rock beats scissors
* Scissors beats paper
* Paper beats rock

### Requirements

Your application ​ must​ support three types of player:
* Human Player - The user must be prompted for a selection of Rock, Paper or Scissors for each turn
* Random Computer Player - The random computer player should automatically select one of Rock, Paper or Scissors at
random for each turn
* Tactical Computer Player - The tactical computer player should always select the ​ choice that would have beaten its last
choice ​ , ​ e.g. if it played Scissors in game 2, it should play Rock in game 3.

### Approach

* As I am new to C# I first read C# docs to understand the basics of it and then created simple 'Hello World' project to understand how C# works.
* Next was to decide what classes I need, so extracted verbs and nouns from game rules and requirements and made a rough sequence diagram to understand the flow of information between classes, encapsulate similar behaviors and not to assign more than one responsibility to one class.
* Then I had to decide between NUnit and MSTest as these libraries were recommended by Spektrix. While researching about them, I found another testing library XUnit that was the latest and powerful testing library, but chose NUnit because it was recommended by them and it runs much faster as compared to MSTest.
* To complete this task I will make one test project, one class lib project and one console app project.
* To gain familarity with testing in C# first I wrote very basic test that will just check if "Rock" is returned.
* Console app will be responsible for interaction from the commandline and Classlib app will have the logic of the game.
* To mock the console app for testing I used `Moq`. While mocking the ConsoleApp I discovered that I cannot mock non-virtual methods and sealed classes, this [stackoverflow](https://stackoverflow.com/questions/21768767/why-am-i-getting-an-exception-with-the-message-invalid-setup-on-a-non-virtual) post helped me get out of this situation. Then I made IUserInterface in classLib app which is extended in console app to test console app. By making IUserInterface in classLib app will give me the flexibility of adding other types of user interfaces.

### Extensions

The following are some of the possible extensions that may be made to the application at a
later date. You do not need to implement these, but they should be considered in your
design.
* New player types
We may want to add new computer player implementations as tactics improve
* Longer matches
We may want to change the match format to “best of 5” at a later date
* New “moves”
We may expand the possible moves that each player can make (e.g.​ ​ Rock, Paper, Scissors, Lizard, Spock​ )