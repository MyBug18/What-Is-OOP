# Which point is better than `Awful`?

* We have seperated each animal type to individual class, so adding new animal function or animal type would not effect the existing code.

# Why is this still bad?

* Since they are still objects of different types there is one problem left: We have to check the type of animal each time we want to call animal function, like `Bark()`. If we want to call other animal function, we have to add one more that messy switch expression. And if we are adding new animal type, we have to expand all existing switch expression to handle newly added type.

We have noticed that in the both way before and now, there remains the same problem: We have to hardly modify existing code when we want to expand the structure. In the next stage, we will definitely fix the problem left.
