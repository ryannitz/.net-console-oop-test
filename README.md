## Thoughts:

* Should interfaces be explicitly defined as "public"? They are by default, but explicit definition seems... better?

* Looks like no primitive type wrapping.

* "calculate" seems too generic, replaced with "calculateVehicleAge".

* Shorthand get/set in classes is very neat.

* Hmmmm. Should I make an empty constructor.. I would like to, but that opens up nullability and much more logic/error checking. 

* I like to use "this" reference in constructors just to have explicit clarity, but visual studio disagrees. Perhaps because of shorthand set/get

* Struggled to name the enums, not going to lie. 

* To use ArrayList or not... No, I would have to loop through and .add() anyway.

* Visual Studio basically writes the code for you with suggestions. Wowowow

* I'm assuming the data is irrelevant... What do you mean Tesla doesn't produce the F-150?

* Using Length instead of GetLength for this example because all arrays will be 1D

* To move the vehicle list outside of the main method into the class-declared variables, or pass them around as an argument?

* The word vehicle is starting to look and sound funny

* Ok, the enum is cool and all but randomly picking an enum value is pretty horrific considering there are so few enum values. Could have kept the values stored in an array, or used a switch statement to select an enum

* Switching the vehicle array to an actual list. The instructions state to use a list, and implementing IComparable allows us to sort.

* Looked through the recommended fixes and adjustments. Accepted some, like: "Make read-only", and ingored others, like: "Random random = new()"

* I left more inline comments than usual to explain things I wouldn't normally do etc.


## Process:

* Pretty much implement the instructions as I would in java, but with c# semantics and techniques. Then at the end, do a deep dive into the visual studio recommendations like "make value read-only". That could be from using the properties set/get?? 

* Not going to bother with namespaces or folder structure. If this was an enterprise/prod solution, I would have implementations/interfaces/etc put into their respective folders.
