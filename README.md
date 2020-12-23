# Randomly-Generated Dungeon
 Name: Sergiu Glingeanu
 Student Number: C18344373
 Class Group: TU984 / DT508
 
 # Description of Project
In this project I experimented with creating a randomly generated dungeon. I managed to create a dungeon that generates in the style of enter the gungeon, and in a different scene a dungeon that generates in the style of binding of Isaac. In the gungeon scene, I added UI ekements that allows you to change how many rooms it will generate, but it won't do anything if you put letters in the input field.

# Instructions for use
Start the Enter the Gungeon scene, and in the top left of the screen put in how many rooms you want to generate.

# How it works
The rooms generate by iteration. The initial room in the scene will spawn a corridor in each cardinal direction, then a room at the end. The rooms spawned at the end of the corridors will then do a raycast check in each direction to see if it can spawn a room there. If the area is free, it will have a 60% chance to sapwn a corridor then a room. If the area already has a room, it will have a 60% chance to spawn a corridor only. After each room is spawned it adds to a static variable that keeps track of how many rooms have been generated. Room generation stops after the static variable is bigger than the chosen rooms to generate.

The way the input field works is, it takes the string that was typed in the field. It then parses it to turn it into an int, if it can't do that, nothing happens. If it can put the value into an int variable, it then changes how many rooms you want to spawn variable in the room object, and restarts the scene, which will then generate the desired amount of rooms.

# What am I most proud of in the assignment
Getting the generation to work. It took me a few hours with tinkering to make it work.
