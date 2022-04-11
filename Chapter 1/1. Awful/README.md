# Why is this awful?

* The program is prone to human errors. program is handling properties with multiple `bool` flag values which must be exclusive. In reality, if the animal is a dog it cannot be a cat. But the program allows the animal to be both dog or cat, by setting `IsDog` and `IsCat` true.
* The program is hard to expand. If we want to add a new animal type, say rabbit, we have to change all the **existing** functions to add new rabbit feature. If multiple programmer is trying to add animal types, there must be conflicts because there will be multiple code-change access in the same function same time.

In the next stage, we will try to fix the problem 1.
