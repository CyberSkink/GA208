# GA208

## Devlogs

### W1

1. 10
2. 1 WRONG 
3. Prints "hello world" every frame on runtime
4. MonoBehavior
5. it prints "x = 10" at runtime start
6a. 10 establishes a value with will later be put into x
6b. the x in quotes does not actually equal the variable of x which equals 10, the actual quoted text means print the exact thing typed (minus the quotes)
7. Transform with a capital T means it will take the established variable called "Transform" instead of the "transform" action, this means it will not transform but instead try to access the variable
8. lower case t in Transform ?

### W2

#### Learned Notes

- Input manager is being used for the lecture NOT input system

#### Image

<img width="552" height="692" alt="MG2drawio" src="https://github.com/user-attachments/assets/b876972c-8695-478c-91ec-e0b6a6a20c54" />

### W3

1. This Script : Inherited From Script e.g. (Goblin : Enemy)
2. Orginization is KING!
3. static means it will not need a new variable
4. Inheritance = CHILD classes INHERIT things from a PARENT CLASS
5. Inheritance Benefits: Performance, Editability, Orginization
6. Finite state machines are essetnially rules that dictate actions and "Finite means limited, not ending"  
7. I am good at state machines, lol.
8. State machines and inheritance can be used in tandom for different classes that need the same (or similar) state machines.

<img width="632" height="702" alt="SEEGAUL drawio" src="https://github.com/user-attachments/assets/e98b6a73-f634-42d2-a5ac-fba4aa935db7" />

### W4&5

1. My stuff got deleted because why the fuck not...
2. The TLDR is basically loose connections = more modularity = good

### MG3

Devlog for MG3

What’s the parent NPC class? Which classes are child NPC classes?
What does the NPC’s state change affect?
How do the NPC child classes interpret the states differently?
What’s the point of structuring the NPC code as a finite state machine with 2 unique subclasses?

The parent class in this case would be the angry seagull, which the child class is the normal seagull. I wish I made a third, overarching class, but I didn’t think that far ahead :P
The NPC change affects the sprite of the NPC and plays a noise. Hopefully it won’t affect your eardrums…
The angry seagull, the parent, defines the reaction, where as the child class modifies it to be more tame
Having one state machine for 2 different classes makes it easy to draw from similar actions.

## W6

abstract classes can inherit from monobehavior

Model view controller: Model <=> View <=> Controller

unity follows mvc pattern

Stardew Valley:

Damien and I see that the gameplay for the scriptable objects are on a grid, represented by the different ditritus around the farm, state machines control the animation because they are all unique and they coorespond to the broken objects, using an enum would probably be good for this.

Hatsune Miku:

The beat types are scriptable objects with data that can be interchanged. The data for each note boils down to just a few variables.

## W8

Performance is very interesting, you can also pause time with code. 

## W9

https://github.com/damienzemanek/tacotruckgame 

Logan worked on the following features:

1. made a raycast system that identifies interactable types for the interation mechanic
2. Made Temporary UI, due to the game being mostly diagetic

We finished pretty much everything we planned to

Damien helped me figure out his side of the code and how to integrate it with mine, he also helped me when I was having some trouble with writing and reading some of the code that was needed.
## W10

Scaling well makes it easy to add data to the project, which I feel I said in the metaphor, but I guess not...
You cannot pick random design patterns and expect the program to scale well

## W12

Rendering is the process of drawing things on the screen and the rendering pipleline is written on the CPU's side.
Rendering pipeline is a sequence of steps, allows the rendering to be dictated and processed.
Shader libraries can be determined through rendering pipeline in Untiy.
The most important thing is compatibility with render pipeline
I didn't know what a rendering pipeline was exactly, but I did know how to search for assets that are compatible with the pipeline I was using... How Ironic!

I worked on: The critiques damien gave me on my code, The Cookbook UI system, and the plan moving forward. 

The plan is to work on (in addition to the things already on the list): a sentitivity slider and more greyboxing / placeholder assets if time allows, along with any UI tweaks and additions needed.


