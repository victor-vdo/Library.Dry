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
