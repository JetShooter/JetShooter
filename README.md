# JetShooter
## Developed by: Petar Mladenovski 211264 and Filip Petkovski 211267
### Game Explanation
The game consists of a plane, which can be customized with a skin, tasked with destroying meteors moving at a certain speed depending on the game's level. Each meteor is destroyed if at least one bullet hits it. At the beginning, a skin for the plane is chosen, followed by selecting the game difficulty (easy, medium, hard). Each level consists of a certain number of meteors that need to be destroyed to avoid losing the game. Each player has 5 lives, which can be lost if a meteor passes the bottom of the screen or collides with the plane. Destroying a meteor earns 1 point. After destroying all meteors in a level, the main meteor (boss) appears, requiring more time to destroy. Destroying the main meteor earns an additional 20 points and advances to the next level. With each subsequent level, the number and movement of meteors increase. At the end, the highest score is saved, allowing players to restart the game with the same skin, start a new game, or exit the application. The goal of the game is to achieve the highest possible high score.

### Description of the Problem Solution

The game consists of a player class (PlayerClass) storing the plane's strength, location, a list of bullet objects (Bullets class), and some methods for drawing the plane, moving the plane, etc. 
Then there's a class for bullets (Bullets) storing the bullet's location and some methods for drawing, moving, etc. 
A class for meteors (Meteor) stores the meteor's location, level, and some methods for drawing, moving, etc. 
A class for the main meteor (MeteorBoss) stores the main meteor's location, health, level, and some methods for drawing, moving, etc. 
Finally, there's a scene class (Scene) storing a list of meteor objects, earned points, highest score, player object, main meteor object, as well as some methods for drawing, moving the plane, moving meteors, and deleting them.

### Description of at least one function or class from the source code of the project

The Scene Class:
This class holds a list of objects from the meteor class, earned points, highest score, a player object, a main meteor object, the width of the form, the height of the form, and the game's difficulty.
In the constructor, the height, width, and highest score are passed. Inside, an object of the player class is initialized.
There is a method for adding a meteor to the meteor list, a method for drawing the player, meteors, and the main meteor, a method for moving the player by creating a new Point with a change in the Y coordinate, a method for shooting the bullets which invokes a method from the player class, a method for moving the bullets which calls a method from the player class, a method for moving the meteors which iterates through the list and calls a method from the meteor class for each meteor in the list, a method that returns whether the bullet hit a meteor, a method that returns whether the bullet hit the main meteor, a method that checks if the meteor has crossed its boundary or if it has been hit by a bullet, a method that checks if the bullet has crossed its boundary or hit a meteor, a method for adding the main meteor, and a method for moving the main meteor which calls another method from the main meteor class.

### Screenshots of the Application/Game Interface and Brief Instructions on How to Use/Play

![image](https://github.com/JetShooter/JetShooter/assets/132352865/4bfac75e-e151-43d0-8a7c-39794f8cfeb5)

By pressing the PLAY button, another form opens to select the game difficulty.
![image](https://github.com/JetShooter/JetShooter/assets/132352865/012e5341-b8eb-42fb-a66f-a44bbc1b9f73)

After selecting the difficulty, a form for selecting a plane skin opens.
![image](https://github.com/JetShooter/JetShooter/assets/132352865/29949bf3-d03d-4f4c-9112-32760ddb0bcb)

Upon selecting the skin, the game starts. The plane moves left and right only by moving the mouse. Pressing the left click shoots. Meteors and the main meteor appear from the top of the form, needing to be destroyed. At the bottom of the form, there's a level status, remaining lives, and points.
![image](https://github.com/JetShooter/JetShooter/assets/132352865/7e23f0da-0cce-4539-9d60-a92b1241f29a)
![image](https://github.com/JetShooter/JetShooter/assets/132352865/6afa6ec5-f3e2-4a1f-976c-646945b753fa)

Upon losing all lives, a new form opens where you can choose to restart, start a new game, or exit the game.
![image](https://github.com/JetShooter/JetShooter/assets/132352865/2d5f77b5-3435-4a7a-9350-beb3c8e6e73c)




