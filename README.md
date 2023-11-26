# Last Stop

A world where everything but the train isn't working, inspired by me getting stuck at 161 Yankee Stadium yet again because the train is "not on schedule"

Almost all of the models will be replaced, and the textures will albe replaced. The map will change according to what ever I make up in blender, and concept art will be uploaded soon.

## End

A duplication of Menu.cs with the methods slightly changed to end the game.

## Main

The game it self, it handles the timer and game GUI.

## Menu

Methods for buttons on menu, used to change scenes.

## MenuMove

Simple animation to imitate train movment, not the best tbh.

## UserInput

Translates user input into character movement, also detects collisions and provides actions for different collisions.

## CameraMove

The original problem child, rotates camera along with chracter. Fixed the main problem by dumping the camera into an empty game object and rotating that instead.

## door_open

Animation for transition scene where doors open.

## instrReturn

Button methods for instruction scene.

## problemChild

Problem Child. Delays the scene change from transitionin to main. Kept loading main even after main is loaded. This used o be a part of door open until I got sick of the mess of comment out and transfered it to a blank script.

## spawn

Spawns objects, there are true random sone by the tree (constricted by some axis), and not really random ones for the rest of the map
