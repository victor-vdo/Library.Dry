# DRY 
<p align="justify">
The DRY (Don't Repeat Yourself) principle is a fundamental concept in software engineering that emphasizes the importance of code reuse and the elimination of duplication. The central idea behind DRY is to avoid repeating logic, reduce redundancy, and foster modularity in software development.</p>

<p align="justify">
In this refactoring, common methods were consolidated into generic functions (<strong><i>RegisterEntity, SearchEntity, RemoveEntity</i></strong>) to avoid repetitions, while the specific methods for each operation retain their dedicated functionality. This approach aims to make the code cleaner, modular, and easier to maintain.</p>

```c#
        private static void RegisterEntity<T>(Action action, List<T> list) where T : Model
        {
            action();
            Console.Clear();
            Console.WriteLine("Registered successfully!");
        }

        private static void SearchEntity<T>(Func<List<T>, bool> func, List<T> list) where T : Model
        {
            var result = func(list);
            if (!result)
            {
                Console.WriteLine("Not found!");
            }
        }
```

<p align="justify">
The generic methods take two parameters: action, which is an action to be executed, and an object or a list of a generic object of type T, restricted to types derived from Model. The where T : Model constraint ensures that type T must be derived from the Model class.</p>

<p align="justify">
Inside the function, action() is invoked to perform the provided action (for example, registering an object). After the action is executed, the screen is cleared, and a success message is displayed, indicating that the registration was completed successfully. This generic method allows registering any type of entity (represented by T) in a generic manner, avoiding code repetition in different parts of the program.</p>
