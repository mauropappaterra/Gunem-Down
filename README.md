<h1 id="up"> Gun'em Down </h1>
A 3D, never-ending, machine gun, survival game created using Unity3D's engine and C#.<br>
<h1>Index</h1>
<a href="#run">Instructions to download and run the game</a><br>
<a href="#intro">Game Overview</a><br>
<a href="#objectives">Game Objectives</a><br>
<a href="#feature">Feature List</a><br>
&nbsp;&nbsp;&nbsp;<a href="#feature_player">Player</a><br>
&nbsp;&nbsp;&nbsp;<a href="#feature_monsters">Monsters</a><br>
&nbsp;&nbsp;&nbsp;<a href="#feature_ammo">Ammo Boxes</a><br>
&nbsp;&nbsp;&nbsp;<a href="#feature_crates">Crates</a><br>
&nbsp;&nbsp;&nbsp;<a href="#feature_world">Game World</a><br>
&nbsp;&nbsp;&nbsp;<a href="#feature_camera">Camera</a><br>
&nbsp;&nbsp;&nbsp;<a href="#feature_controller">Game Controller</a><br>
<a href="#graphics">Graphics and Animations</a><br>
<a href="#architecture">Game Architecture</a><br>
<a href="#physics">Physics</a><br>
<a href="#assets">List of Assets</a><br>
<br>

<h2 id="run">Instructions to run the game</h2>
You can download this game for free. <a href="https://www.dropbox.com/sh/nrkd4lo5xq2ne5c/AAC7Ug149DK6lMnsTn9crcnMa?dl=0" target="_blank">You can download the full game from Dropbox following this link!</a>. This is a multiplatform game and it can run on Windows, Mac and Linux systems.<br>

<h3>On a MS Windows system</h3>
-Download the game from <a href="https://www.dropbox.com/sh/nrkd4lo5xq2ne5c/AAC7Ug149DK6lMnsTn9crcnMa?dl=0" target="_blank"> the link provided above</a><br>
-Execute the file <i>Play.exe</i> <br>

<h3>On a Mac system</h3>
-Download the game from <a href="https://www.dropbox.com/sh/nrkd4lo5xq2ne5c/AAC7Ug149DK6lMnsTn9crcnMa?dl=0" target="_blank"> the link provided above</a><br>
-Execute the file <i>Play.exe</i> <br>

<h3>On a Linux system</h3>
-Download the game from <a href="https://www.dropbox.com/sh/nrkd4lo5xq2ne5c/AAC7Ug149DK6lMnsTn9crcnMa?dl=0" target="_blank"> the link provided above</a><br>
-Execute the file <i>Play.exe</i>
<br><br>
<a href="#up">Go Up</a>
<br><br>
<br>
<img src="https://i.imgur.com/05atcuM.png">
<br><br>
<h2 id="intro">Game Overview</h2>
Gun’em Down is a 3D, never ending, machine gun survival, horror themed game. The player object will be a machine gun nest that can rotate (but not move) 360 degrees, and shoot the approaching hordes of enemies. Endless waves of monsters will spawn in random corners of the screen and attack the player. You can try to get a high score but, as the apocalypse engulfs the earth, you know deep inside that there’s no way out alive on the game!
<br><br>
<a href="#up">Go Up</a>
<br><br>
<h2 id="objectives">Game Objectives</h2>
Hell broke loose. Gun down as many creatures as you can, avoid being destroyed by the monsters as you strive to survive. Use power ups to increase shooting speed or upgrade your weapon, but be careful not to infuriate one dark deity that dwells in the jungle. There is no way to win, but you can try to take down to hell with you as many monsters as you can.
<br><br>
<a href="#up">Go Up</a>
<br><br>

<br>
<img src="https://i.imgur.com/0wTb7OD.png">
<br><br>
<h2 id="feature">Feature Lists</h2>
This is an outline of all the features in different components of the game.
<br>
<h3 id="feature_player">Player</h3>
<ul>
<li>A machine gun nest.</li>
<li>Can only rotate 360 degrees. But cannot move</li>
<li>Press right arrow key to rotate to the right, press left arrow key to rotate to the left.</li>
<li>Alternatively, press up arrow key to rotate to the right, and press down arrow key to rotate to the left</li>
<li>ss</li>
<li>ss</li>
<li>ss</li>
<li>ss</li>
</ul>
<h3 id="feature_monsters">Monsters</h3>
<ul>
<li>ss</li>
<li>ss</li>
<li>ss</li>
<li>ss</li>
</ul>
<h3 id="feature_ammo">Ammo Boxes</h3>
<ul>
<li>ss</li>
<li>ss</li>
<li>ss</li>
<li>ss</li>
</ul>
<h3 id="feature_crates">Crates</h3>
<ul>
<li>ss</li>
<li>ss</li>
<li>ss</li>
<li>ss</li>
</ul>
<h3 id="feature_camera">Camera</h3>
<ul>
<li>ss</li>
<li>ss</li>
<li>ss</li>
<li>ss</li>
</ul>
<h3 id="feature_world">Game World</h3>
<ul>
<li>ss</li>
<li>ss</li>
<li>ss</li>
<li>ss</li>
</ul>
<h3 id="feature_controller">Game Controller</h3>
<ul>
<li>ss</li>
<li>ss</li>
<li>ss</li>
<li>ss</li>
</ul>
<br><br>
<a href="#up">Go Up</a>

<br>
<img src="https://i.imgur.com/gHRGXYb.png">
<br><br>
<h2 id="graphics">Graphics and Animations</h2>
Gun’em Down is a 3D game, the elements of the game wold where lay out as indicated on the
game description and Unity3D graphic engines delivers the rendering. All VFX were
downloaded from the asset store, and were created by graphic designer at professional levels.
Nonetheless, there were some parameters that I modified on my own in order to achieve a
graphical interface I found suitable for the game. For instance, I decided that there should be
two different sources of light: one that is from above, so all the elements where easy to
identify, and there was a second light source from the front and with an downwards angle in
order to generate shadows that will add a dramatic effect to the stage. I configured Unity3D
for optimal high performance and low memory in mind.
Some of the graphics where kept in the background, such as the trees that made the forest that
did not had any physics of scripts applied to them. There is only one short animation that
does not depends on physics on my game implementation: that is the animation of the
zombies walking. These animation is very well done, it follows logics of a rag doll physics
scheme. Animation frame rate are the same on every instantiated object, the animation loops
continuously, there were no transitions necessary, and is played at normal speed. I achieved
this by creating a prefab and an Animator object.
<br><br>
<img src="https://i.imgur.com/dDjpLQK.png">
<br><br>
<br><br>
<a href="#up">Go Up</a>
<br><br>
<h2 id="architecture">Game Architecture</h2>
Most of the architecture of the game relies on Unity3D’s engine. Unity3D’s architectures
provides with some sort of encapsulation, so I guess the essential engines, that provides the graphic rendering and physics, are hidden to me. But there were some patterns and
organization that I implemented on my game specific code. I tried to avoid an ad hoc
architecture and strive for a modular architecture system instead. I guess I end up with
something in the middle, most of my efforts were dedicated to the understanding of the
Unity3D engine. For instance, I tried to keep all assets separated in different folders as
recommended on the lecture, and all my scripts separated and as independent form each other
as possible, I avoided cluttered code, and strived for low coupling for all scripts handling different functionalities and controllers of the game. Furthermore, I could group my scripts in the following manner:

<h4>Control Scripts</h4>
All scripts that dealt with the direct control of different parts of the game, these are:<br>
<b><i>GameController.cs</i></b>: all functionalities that control the video game interface, including,
keeping a score displaying ammunition, when the game was over and restart menu.<br>
<b><i>PlayerController.cs</i></b>: all functionalities that control the main character (player object) in this case a machine gun nest. This includes not only rotation of the character but spawning shots and other fire related methods, such as upgrade, downgrade, keep track of ammo, fire rate and a special weapon too.<br>
<b><i>ZombieController.cs</i></b>: all functionalities that control the enemies (zombies), including speed and physics.

<h4>Spawn Scripts</h4>
All scripts that were used to provide game flow by spawning different object in the game:<br>
<b><i>SpawnAmmo.cs</i></b>: everything necessary to spawn ammo boxes, including where, when and at what rate.<br>
<b><i>SpawnBoxes.cs</i></b>: everything necessary to spawn crates, including where, when and at what rate.<br>
<b><i>SpawnZombies.cs</i></b>: everything necessary to spawn enemies, including where, when and at what rate.

<h4>Physics and Collision Scripts</h4>
All scripts that dealt directly with physics on Unity3D and the collision of different objects in the game:<br>
<b><i>Shot.cs</i></b>: speed and physics used on the projectiles.<br>
<b><i>Rotate.cs</i></b>: tumbler speed and physics used on the rotation of different objects in the game.<br>
<b><i>ContactDestroy.cs</i></b>: this is one of the central scripts to the unfolding of the game. This script deals with the collision of the projectiles with every possible game object and the spawning of special items.<br>
<b><i>BoundaryDestroy.cs</i></b>: this is a workaround for destroying objects that are no longer relevant to the game.
<br>
<br>
There is a small number design patterns that I have implemented, directly or indirectly, in my project. The main player could have been a singleton as there is only one instance in the entire game. All three spawn scripts (SpawnAmmo, SpawnBoxes, SpawnZombies) implement
a factory pattern. Moreover, some sort of observer pattern is implemented to update the shots fired from the PlayerController script to the GameController script in order to display correctinformation on the score and ammunition left. Most of these patterns were implemented using Unity3D build in capabilities, for example using the method Instantiate for the factory pattern. Moreover, object oriented programming is applied all around the game. The simulation models real life and imaginary objects and characters. Inheritance and
polymorphism are also implemented. One example is the content of the crates, that have
similar functionalities an work in a similar way. This is provided on Unity3D with a very
intuitive user interface, where game objects can be easily duplicated and modified from the
parameters options on the component system, and different prefabs can be created of a
seemingly similar game object that olds different parameters and characteristics.
<br><br>
<a href="#up">Go Up</a>
<br><br>
<br>
<img src="https://i.imgur.com/IDE3p9a.png">
<br><br>
<h2 id="physics">Physics</h2>
Once again, all physics were handled by Unity3D engine. But in order to use the framework
provided, I had to include a RigidBody element to the objects that required some action
involving physics. In order to handle physics and collisions without any major problems, I
separated both parts, graphical and physical. This was particularly useful for the content of
the crates, where the VFX part is a rotating prefab, but I wouldn’t want the collision volumes
(ObjectCollider) to collide with the player or each other, so the colliders are separated and the
final prefab is unified using an empty game object. Most of the collisions, that are central in a
game of this nature, are in the script ContactDestroy. Since there are lots of objects on the
screen, Unity3D Tags system is implemented to differentiate among all different objects in
the game world.
Direction and velocity to determining the trajectory of a moving objects, such as the shots
and the zombies, and rotation of pick up objects were handled on the scripts Shot.cs and
Rotate.cs. Different factors come into play for different game objects. For instance, allenemies needed to be instantiated in a rotation that would present a real threat to the player,
velocities should not be too slow or too fast, same with the rotation of the player and the pick
up items. Mostly rigid body dynamics were modified on each of the prefabs instance, this
includes gravity, mass, and angular drag.
For all game objects involved, I used simplified collision volumes in order the optimize
collision detection, including, spheres, capsules and boxes. This will save computation time
and, since there is only one static camera angle, it won’t interfere with the user experience.
<br><br>
<a href="#up">Go Up</a>
<br><br>
<br>
<img src="https://i.imgur.com/ydzjzyx.png">
<br><br>
<h2 id="assets">List of Assets</h2>
Here's a detailed list of all the assets I used from Unity3D asset store<br>
<ul>
<li>ss</li>
<li>ss</li>
<li>ss</li>
<li>ss</li>
<li>ss</li>
<li>ss</li>
<li>ss</li>
<li>ss</li>
<li>ss</li>
<li>ss</li>
<li>ss</li>
<li>ss</li>
</ul>
<br><br>
<a href="#up">Go Up</a>


