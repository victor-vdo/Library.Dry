# DRY 
<p align="justify">
The DRY (Don't Repeat Yourself) principle is a fundamental concept in software engineering that emphasizes the importance of code reuse and the elimination of duplication. The central idea behind DRY is to avoid repeating logic, reduce redundancy, and foster modularity in software development.</p>
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
