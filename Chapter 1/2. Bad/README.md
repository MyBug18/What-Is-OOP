# Why is this better than `Awful`?

* We introduced new `enum` variable, removing multiple `bool` flags. Now we can ensure that there are *really* only four types of animal.

# Why is this still bad?

* As you can see, the basic structure of the function `Bark()` and `Eat()` is not changed. There will be a heavy conflict when there are multiple access tries to the same function by more than one programmer.

In the next stage, we will try to fix the problem left.
