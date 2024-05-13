using Game.Implementations;
using Game.Support;


var settings = new Settings(10, new NumberRange(10, 20));

var myGame = new RandomNumberGame(settings);

myGame.Start();