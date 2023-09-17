using SingletonPractise;

Singleton s1 = new Singleton();
s1.PrintMessage("This is first Message");

Singleton s2 = new Singleton();
s2.PrintMessage("This is second message");



// See above we are creating 2 objects that's a very bad way of coding, lets say we were 
// requring to use the objects in multiple classes, then againa and again memory creation is not
// at all a good idea


// SingletonImplementaion singletonImplementaion = new SingletonImplementaion(); 

// due to private level access the above line 16 won't work

/*

SingletonImplementaion singletonImplementaion = SingletonImplementaion.GetInstance();
singletonImplementaion.PrintMessge("SingleTonImplementaion Message1");

SingletonImplementaion singletonImplementaion1 = SingletonImplementaion.GetInstance();
singletonImplementaion.PrintMessge("SingleTonImplementaion Message2");

SingletonImplementaion.DerivedClass z = new SingletonImplementaion.DerivedClass();
singletonImplementaion.PrintMessge("SingleTonImplementaion Message3");

*/

// Singleton is not Thread Safe
/*
StudentImplementation();
TecherImplementation();
*/

// Issue with MultiThreaded Application

Parallel.Invoke(()=> StudentImplementation(), ()=> TecherImplementation());

Console.ReadLine();

static void StudentImplementation()
{
    SingletonImplementaion forStudent = SingletonImplementaion.GetInstance();
    forStudent.PrintMessge("I'm a Student");
}

static void TecherImplementation()
{
    SingletonImplementaion forTeacher = SingletonImplementaion.GetInstance();
    forTeacher.PrintMessge("I'm a Teacher");
}