# smeerws-PersistentSingleton

A singleton is a design pattern.
The implementation of a singleton design pattern within a class ensures that *only one* instance of the object 
ever exists at any one time. 
There exist several different singleton implementations. 

+ Link to [SimpleSingleton](https://github.com/HS-Teaching/smeerws-SimpleSingleton)
+ Link to [LazySingleton](https://github.com/HS-Teaching/smeerws-LazySingleton)
+ Link to [ConcreteSingleton](https://github.com/HS-Teaching/smeerws-ConcreteSingleton)

This unity project serves as reference for the implementation of a persistent singleton.
The code is based on the simple Singleton, but fixes the persistency problem.

Issues with this simple implementation of a singleton:  
 + 1) All the executable code must be attached to GameObject in the hierarchy.
 + 2) Whenever we need a class to be a singlton we have to copy the singleton mechanic in Awake().
 
 
The singleton design pattern can be used for saving data between scenes. 
Use singletons for controller classes such as GameManager, GameController, etc. where it is important that an instance 
exists only once. 

Dev-platform: Win 10, Unity Version: 2018.2.14f1, Visual Studio Version: VS Community 2017, 15.3.9;
Scripting Runtime Version: .NET 4.x Equivalent
API Compatibility Level: .NET Standard 2.0

Target platform: Standalone (Reference Resolution: 1024 x 768)