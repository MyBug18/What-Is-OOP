# What is changed from `Still Bad`?

* We have introduced *inheritance*. That's all.

# Why is this better than the structure before?

* With inheritance, we can ensure that every animal can `Bark()` and `Eat()`, if they are inheriting `Animal` class.

As you can see in the `switch` branch in `GetRandomAnimal()`, the function returns diffrent types of object in each branch. But the return type of the function is `Animal`, because every return type **is** `Animal` type. We have ensured this via inheritance.

* We can expect different behaviour even if the object type remains same as `Animal`.

As you can see in the `Main` function, the type of `animal` variable from `GetRandomAnimal()` function is `Animal`. But when we call the method of `animal`, it acts differently: as `Dog`, as `Cat`, as `Elephant`, or as `Animal`. We don't need messy switch type checking. We do not *check* the type of `animal`, but we just *expect* `animal` to act as `Animal`, which can `Bark()` and `Eat()` although it may be different in detail. We call this concept **Polymorphism**, and it is one of the key features of OOP.

* The program is easy to expand. (high scalability)

Let's assume we want to add new animal type, say `Rabbit`. All we have to do is create `Rabbit` class **which inherits** `Animal` class, and override it's `Bark()` and `Eat()` function to act as a rabbit. And adding new `Rabbit` type to `GetRandomAnimal()` would enough. No messy conflict: the only change in existing code is `GetRandomAnimal()`, which means great increase of scalability.

# What we have learned

I hope you have understood what is polymorphism via this chapter.
> We can expect different behaviour even if the variable remains same type.

We will repeat this concept until the end of this lecture. Yes, it's that important. Maybe more than you think. You will eventually understand why this is important, in the end of this lecture.